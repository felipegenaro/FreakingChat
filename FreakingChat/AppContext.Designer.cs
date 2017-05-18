using System;
using System.Windows.Forms;
using FreakingChat;
using FreakingChat.Properties;

namespace NotificationIconTemplate
{
    partial class AppContext
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                MainIcon.Visible = false;
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainIcon = new NotifyIcon(this.components);
            this.MainIcon.ContextMenuStrip = new ContextMenuStrip();
            // 
            // TrayIcon
            // 
            this.MainIcon.Text = "FreakingChat";
            this.MainIcon.Visible = true;
            this.MainIcon.Icon = Resources.trayIcon;
            //this.MainIcon.DoubleClick += MainIconOnDoubleClick;
            // 
            // MenuItem Open
            // 
            var showMenuItem = new ToolStripMenuItem
            {
                Text = "Open",
                Name = "openMenuItem",
            };
            showMenuItem.Click += OpenMenuItem_Click;
            MainIcon.ContextMenuStrip.Items.Add(showMenuItem);
            //
            // Separator
            MainIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            //
            // 
            // MenuItem Exit
            // 
            var exitMenuItem = new ToolStripMenuItem
            {
                Text = "Exit",
                Name = "exitMenuItem",
            };
            exitMenuItem.Click += CloseMenuItem_Click;
            MainIcon.ContextMenuStrip.Items.Add(exitMenuItem);
        }

        //
        // DoubleClick
        //
        //private void MainIconOnDoubleClick(object sender, EventArgs eventArgs)
        //{
        //    if (Check == false)
        //    {
        //        var form = new LogonUI();
        //        form.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show(@"Another instance of the program is already open.");
        //        return;
        //    }
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private NotifyIcon MainIcon;

        #endregion
    }
}
