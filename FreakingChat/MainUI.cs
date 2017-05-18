using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat;

namespace FreakingChat
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private Color textColor;
        public Color TextColor
        {
            get
            {
                return textColor;
            }
            set
            {
                textColor = value;
                txtMessage.ForeColor = textColor;
            }
        }

        private void AddClientMessage(string message)
        {
            AddClientMessage(null, message, Color.Black);
        }
        private void InvokeForm(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void AddClientMessage(string nick, string message, Color color)
        {
            InvokeForm(() =>
            {
                if (rtbChat.TextLength > 0)
                {
                    rtbChat.AppendText(Environment.NewLine);
                }

                rtbChat.SelectionColor = Color.Gray;
                rtbChat.AppendText(DateTime.Now.ToLongTimeString() + " ");
                rtbChat.SelectionColor = Color.Black;

                if (!string.IsNullOrEmpty(nick))
                {
                    rtbChat.AppendText(nick + ": ");
                    rtbChat.SelectionColor = color;
                }

                rtbChat.AppendText(message);
                rtbChat.ScrollToCaret();
            });
        }

        private Server server;
        private ChatManager chat;
        private void ClientSendMessage()
        {
            chat.SendMessage(txtMessage.Text, txtMention.Text, TextColor);
            txtMessage.ResetText();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ckEnter.Checked)
            {
                e.SuppressKeyPress = true;
                ClientSendMessage();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ClientSendMessage();
        }
    }
}
