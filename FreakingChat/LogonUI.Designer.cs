using FreakingChat.Properties;
using System;
using System.Windows.Forms;


namespace FreakingChat
{
    partial class LogonUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        public bool openDoubleClick = false;
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.components = new System.ComponentModel.Container();
            this.MainIcon = new NotifyIcon(this.components);
            this.MainIcon.ContextMenuStrip = new ContextMenuStrip();
            // 
            // notifyIcon1
            // 
            this.MainIcon.Text = "FreakingChat";
            this.MainIcon.Visible = true;
            //this.MainIcon.Icon = Resources._trayIcon;
            this.MainIcon.Icon = MainIcon.Icon;
            this.MainIcon.DoubleClick += MainIconOnDoubleClick;
            // 
            // MenuItem
            // 
            var showMenuItem = new ToolStripMenuItem
            {
                Text = "Open",
                Name = "abrirMenuItem",
            };
            showMenuItem.Click += showMenuItem_Click;
            MainIcon.ContextMenuStrip.Items.Add(showMenuItem);
            MainIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());


            // 
            // MenuItemSair
            // 
            var exitMenuItem = new ToolStripMenuItem
            {
                Text = "Exit",
                Name = "exitMenuItem",
            };
            exitMenuItem.Click += CloseMenuItem_Click;
            MainIcon.ContextMenuStrip.Items.Add(exitMenuItem);

            MainIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());

            //
            //
            //
            this.btnConect = new System.Windows.Forms.Button();
            this.btnOpenConection = new System.Windows.Forms.Button();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConect
            // 
            this.btnConect.Location = new System.Drawing.Point(174, 211);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(98, 38);
            this.btnConect.TabIndex = 0;
            this.btnConect.Text = "Conect";
            this.btnConect.UseVisualStyleBackColor = true;
            // 
            // btnOpenConection
            // 
            this.btnOpenConection.Location = new System.Drawing.Point(12, 211);
            this.btnOpenConection.Name = "btnOpenConection";
            this.btnOpenConection.Size = new System.Drawing.Size(98, 38);
            this.btnOpenConection.TabIndex = 1;
            this.btnOpenConection.Text = "Open Conection";
            this.btnOpenConection.UseVisualStyleBackColor = true;
            this.btnOpenConection.Click += new System.EventHandler(this.btnOpenConection_Click);
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(159, 28);
            this.txtNick.MaxLength = 20;
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(113, 20);
            this.txtNick.TabIndex = 2;
            this.txtNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(159, 70);
            this.txtIP.MaxLength = 15;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(113, 20);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(159, 108);
            this.txtPort.MaxLength = 6;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(113, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "56863";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(159, 149);
            this.txtPass.MaxLength = 16;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(113, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nick Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP Adress";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogonUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.btnOpenConection);
            this.Controls.Add(this.btnConect);
            this.Name = "LogonUI";
            this.Text = "Conection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.Button btnOpenConection;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;


        private void MainIconOnDoubleClick(object sender, EventArgs eventArgs)
        {
            if ((openDoubleClick == false) && (openMenuAbrir == false))
            {
                using (var form = new MainUI())
                {
                    openDoubleClick = true;
                    form.ShowDialog();
                }
                openDoubleClick = false;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private NotifyIcon MainIcon;

        #endregion
    }
}

