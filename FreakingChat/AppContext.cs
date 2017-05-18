using System;
using System.Windows.Forms;
using FreakingChat;

namespace NotificationIconTemplate
{
    public partial class AppContext : ApplicationContext
    {
        private LogonUI log;

        public bool logLog = false;
        //public bool logUI = true;
        public bool mainUI = false;
        public bool close;
        public AppContext()
        {
            InitializeComponent();

            var form = new LogonUI();
            form.ShowDialog();
            //logUI = true;
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
            //logUI == false &&
            if (logLog == false && close == true)
            {
                var form = new LogonUI();
                form.ShowDialog();
            }
            else if (mainUI == false && logLog == true)
            {
                var form = new MainUI();
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
