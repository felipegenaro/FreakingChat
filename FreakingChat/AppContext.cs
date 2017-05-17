using System;
using System.Windows.Forms;
using FreakingChat;

namespace NotificationIconTemplate
{
    public partial class AppContext : ApplicationContext
    {
        public bool Check = false;
        public AppContext()
        {
            InitializeComponent();

            Check = true;

            var form = new LogonUI();
            form.ShowDialog();
        }

        public void CloseMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Do you really want to leave ??",
                                @"Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MainIcon.Visible = false;
                Application.Exit();
            }
        }

        public void OpenMenuItem_Click(object sender, EventArgs e)
        {
            if (Check == false)
            {
                var form = new LogonUI();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"Another instance of the program is already open.");
                return;
            }
        }
    }
}
