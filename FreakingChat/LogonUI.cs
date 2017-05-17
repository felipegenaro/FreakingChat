using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Chat;
using NotificationIconTemplate;

namespace FreakingChat
{
    public partial class LogonUI : Form
    {
        public LogonUI()
        {
            InitializeComponent();
        }

        private void btnOpenConection_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private Server server;
        private void StartServer()
         {
            if (txtPort.TextLength > 0 && !string.IsNullOrEmpty(txtNick.Text))
            {
                server = new Server(Int32.Parse(txtPort.Text), txtNick.Text, txtPass.Text);
                server.StartServer();

                MessageBox.Show("Connected to Created Server");

                MainUI main = new MainUI();
                main.Show();
            }
            else
            {
                MessageBox.Show("Review your Credentials");
            }
        }


        private void btnClientConnect_Click(object sender, EventArgs e)
        {
            ClientConnect();
        }

        private ChatManager chat;
        private void ClientConnect()
        {
            if (!string.IsNullOrEmpty(txtIP.Text) && txtPort.TextLength > 0 && !string.IsNullOrEmpty(txtNick.Text))
            {
                chat = new ChatManager(txtIP.Text, Int32.Parse(txtPort.Text), txtNick.Text);
                chat.Connect(txtPass.Text);
            }
        }
    }
}