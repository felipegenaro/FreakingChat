namespace FreakingChat
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.lvUsers = new System.Windows.Forms.ListView();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.ckEnter = new System.Windows.Forms.CheckBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMention = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvUsers
            // 
            this.lvUsers.Location = new System.Drawing.Point(517, 12);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(224, 477);
            this.lvUsers.TabIndex = 0;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(12, 12);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(499, 477);
            this.rtbChat.TabIndex = 1;
            this.rtbChat.Text = "";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 521);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(499, 20);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // ckEnter
            // 
            this.ckEnter.AutoSize = true;
            this.ckEnter.Location = new System.Drawing.Point(372, 498);
            this.ckEnter.Name = "ckEnter";
            this.ckEnter.Size = new System.Drawing.Size(101, 17);
            this.ckEnter.TabIndex = 3;
            this.ckEnter.Text = "Send with Enter";
            this.ckEnter.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(479, 495);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(32, 20);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(652, 521);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(89, 20);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMention
            // 
            this.txtMention.Location = new System.Drawing.Point(517, 521);
            this.txtMention.Name = "txtMention";
            this.txtMention.Size = new System.Drawing.Size(129, 20);
            this.txtMention.TabIndex = 6;
            // 
            // btnPing
            // 
            this.btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPing.Location = new System.Drawing.Point(697, 495);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(44, 20);
            this.btnPing.TabIndex = 7;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 553);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.txtMention);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.ckEnter);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.lvUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "FreakingChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.CheckBox ckEnter;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMention;
        private System.Windows.Forms.Button btnPing;
    }
}