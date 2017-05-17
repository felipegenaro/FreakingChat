using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Chat
{
    public class ChatManager
    {
        public delegate void MessageEventHandler(Info messageInfo);
        public event MessageEventHandler MessageReceived;

        public delegate void StringEventHandler(string text);
        public event StringEventHandler Notification;

        public delegate void UserConnectedEventHandler(UserInfo userInfo);
        public event UserConnectedEventHandler UserConnected;

        public delegate void UserDisconnectedEventHandler(UserInfo userInfo);
        public event UserDisconnectedEventHandler UserDisconnected;

        public delegate void UserListReceivedEventHandler(UserInfo[] userList);
        public event UserListReceivedEventHandler UserListReceived;

        public delegate void KickedEventHandler(string reason);
        public event KickedEventHandler Kicked;

        public event Action<long> Pong;

        public bool IsConnected { get; private set; }
        public bool IsAuthenticated { get; private set; }

        public string IPAddress { get; set; }
        public int Port { get; set; }
        public string Nickname { get; set; }

        private Client client;
        private Stopwatch pingTimer;

        public ChatManager(string ip, int port, string nickname)
        {
            IPAddress = ip;
            Port = port;
            Nickname = nickname;
        }

        public void Connect(string password = "")
        {
            try
            {
                client = new Client(IPAddress, Port);
                client.UserInfo.Nickname = Nickname;
                client.MessageReceived += client_MessageReceived;
                client.Disconnected += client_Disconnected;
                PackInfo packetInfo = new PackInfo("Connect");
                packetInfo.AddParameter("Nickname", Nickname);
                if (!string.IsNullOrEmpty(password)) packetInfo.AddParameter("Password", password);
                client.SendPacket(packetInfo);
                IsConnected = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void client_Disconnected(Client client, string reason)
        {
            IsConnected = IsAuthenticated = false;
            OnNotification("Disconnected.");
        }

        public void Disconnect()
        {
            PackInfo packetInfo = new PackInfo("Disconnect");
            packetInfo.AddParameter("Reason", "User disconnect");
            client.SendPacket(packetInfo);
            client.Disconnect();
        }

        private void OnUserConnected(UserInfo info)
        {
            if (UserConnected != null) UserConnected(info);
        }

        private void OnUserDisconnected(UserInfo info)
        {
            if (UserDisconnected != null) UserDisconnected(info);
        }

        private void OnUserListReceived(UserInfo[] userList)
        {
            if (UserListReceived != null) UserListReceived(userList);
        }

        private void OnKicked(string reason)
        {
            if (Kicked != null) Kicked(reason);
        }

        private void OnPong(long elapsed)
        {
            if (Pong != null) Pong(elapsed);
        }

        private void client_MessageReceived(Client client, string text)
        {
            PackInfo packetInfo = JsonConvert.DeserializeObject<PackInfo>(text);

            if (packetInfo != null && !string.IsNullOrEmpty(packetInfo.Command))
            {
                switch (packetInfo.Command)
                {
                    case "Connected":
                        UserInfo connectedUserInfo = packetInfo.GetData<UserInfo>();
                        OnNotification(connectedUserInfo.Nickname + " connected.");
                        OnUserConnected(connectedUserInfo);
                        break;
                    case "Disconnected":
                        UserInfo disconnectedUserInfo = packetInfo.GetData<UserInfo>();
                        OnNotification(disconnectedUserInfo.Nickname + " disconnected.");
                        OnUserDisconnected(disconnectedUserInfo);
                        break;
                    case "Message":
                        Info messageInfo = packetInfo.GetData<Info>();
                        OnMessageReceived(messageInfo);
                        break;
                    case "UserList":
                        UserInfo[] userList = packetInfo.GetData<UserInfo[]>();
                        OnUserListReceived(userList);
                        break;
                    case "Kick":
                        string reason = packetInfo.GetParameter("Reason");
                        OnKicked(reason);
                        break;
                    case "Pong":
                        if (pingTimer != null) OnPong(pingTimer.ElapsedMilliseconds);
                        break;
                }
            }
        }

        public void SendMessage(string message, string toUser, Color color)
        {
            if (!string.IsNullOrEmpty(message))
            {
                PackInfo packetInfo = new PackInfo("Message");
                Info messageInfo = new Info(message);
                if (!string.IsNullOrEmpty(toUser)) messageInfo.ToUser = new UserInfo(toUser);
                messageInfo.TextColor = color;
                packetInfo.Data = messageInfo;
                client.SendPacket(packetInfo);
            }
        }

        public void SendPing()
        {
            pingTimer = Stopwatch.StartNew();
            client.SendPacket(new PackInfo("Ping"));
        }

        protected void OnNotification(string text)
        {
            if (Notification != null)
            {
                Notification(text);
            }
        }

        protected void OnMessageReceived(Info messageInfo)
        {
            if (MessageReceived != null)
            {
                MessageReceived(messageInfo);
            }
        }
    }
}