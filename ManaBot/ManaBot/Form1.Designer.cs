namespace ManaBot
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.scChatting = new System.Windows.Forms.SplitContainer();
            this.scChat = new System.Windows.Forms.SplitContainer();
            this.lbViewerList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDeepbotApi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDeepbotIp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbChannel = new System.Windows.Forms.TextBox();
            this.tbBotOauth = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBotName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStreamOauth = new System.Windows.Forms.MaskedTextBox();
            this.tbStreamName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tbCommandChar = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChatting)).BeginInit();
            this.scChatting.Panel1.SuspendLayout();
            this.scChatting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChat)).BeginInit();
            this.scChat.Panel2.SuspendLayout();
            this.scChat.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.scChatting);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chat Window";
            // 
            // scChatting
            // 
            this.scChatting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scChatting.Location = new System.Drawing.Point(3, 3);
            this.scChatting.Name = "scChatting";
            this.scChatting.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scChatting.Panel1
            // 
            this.scChatting.Panel1.Controls.Add(this.scChat);
            this.scChatting.Size = new System.Drawing.Size(970, 529);
            this.scChatting.SplitterDistance = 485;
            this.scChatting.TabIndex = 1;
            // 
            // scChat
            // 
            this.scChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scChat.Location = new System.Drawing.Point(0, 0);
            this.scChat.Name = "scChat";
            // 
            // scChat.Panel2
            // 
            this.scChat.Panel2.Controls.Add(this.lbViewerList);
            this.scChat.Size = new System.Drawing.Size(970, 485);
            this.scChat.SplitterDistance = 750;
            this.scChat.TabIndex = 0;
            // 
            // lbViewerList
            // 
            this.lbViewerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbViewerList.FormattingEnabled = true;
            this.lbViewerList.Location = new System.Drawing.Point(0, 0);
            this.lbViewerList.Name = "lbViewerList";
            this.lbViewerList.Size = new System.Drawing.Size(216, 485);
            this.lbViewerList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbDeepbotApi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbDeepbotIp);
            this.groupBox2.Location = new System.Drawing.Point(219, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 157);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deepbot Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DeepBot Ip Address: ";
            // 
            // tbDeepbotApi
            // 
            this.tbDeepbotApi.Location = new System.Drawing.Point(120, 19);
            this.tbDeepbotApi.Name = "tbDeepbotApi";
            this.tbDeepbotApi.Size = new System.Drawing.Size(151, 20);
            this.tbDeepbotApi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "DeepbotAPIKey: ";
            // 
            // tbDeepbotIp
            // 
            this.tbDeepbotIp.Location = new System.Drawing.Point(120, 46);
            this.tbDeepbotIp.Name = "tbDeepbotIp";
            this.tbDeepbotIp.Size = new System.Drawing.Size(151, 20);
            this.tbDeepbotIp.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCommandChar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbChannel);
            this.groupBox1.Controls.Add(this.tbBotOauth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbBotName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbStreamOauth);
            this.groupBox1.Controls.Add(this.tbStreamName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 202);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Twitch Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Command Prefix: ";
            // 
            // tbChannel
            // 
            this.tbChannel.Location = new System.Drawing.Point(98, 123);
            this.tbChannel.Name = "tbChannel";
            this.tbChannel.Size = new System.Drawing.Size(100, 20);
            this.tbChannel.TabIndex = 5;
            // 
            // tbBotOauth
            // 
            this.tbBotOauth.Location = new System.Drawing.Point(98, 97);
            this.tbBotOauth.Name = "tbBotOauth";
            this.tbBotOauth.PasswordChar = '*';
            this.tbBotOauth.Size = new System.Drawing.Size(100, 20);
            this.tbBotOauth.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Channel: ";
            // 
            // tbBotName
            // 
            this.tbBotName.Location = new System.Drawing.Point(98, 71);
            this.tbBotName.Name = "tbBotName";
            this.tbBotName.Size = new System.Drawing.Size(100, 20);
            this.tbBotName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bot Oauth; ";
            // 
            // tbStreamOauth
            // 
            this.tbStreamOauth.Location = new System.Drawing.Point(98, 45);
            this.tbStreamOauth.Name = "tbStreamOauth";
            this.tbStreamOauth.PasswordChar = '*';
            this.tbStreamOauth.Size = new System.Drawing.Size(100, 20);
            this.tbStreamOauth.TabIndex = 1;
            // 
            // tbStreamName
            // 
            this.tbStreamName.Location = new System.Drawing.Point(98, 19);
            this.tbStreamName.Name = "tbStreamName";
            this.tbStreamName.Size = new System.Drawing.Size(100, 20);
            this.tbStreamName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bot name:  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Streamer Name: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 48);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "StreamerOauth: ";
            // 
            // tbCommandChar
            // 
            this.tbCommandChar.Location = new System.Drawing.Point(98, 152);
            this.tbCommandChar.Name = "tbCommandChar";
            this.tbCommandChar.Size = new System.Drawing.Size(100, 20);
            this.tbCommandChar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.scChatting.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scChatting)).EndInit();
            this.scChatting.ResumeLayout(false);
            this.scChat.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scChat)).EndInit();
            this.scChat.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer scChat;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer scChatting;
        private System.Windows.Forms.ListBox lbViewerList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbChannel;
        private System.Windows.Forms.MaskedTextBox tbBotOauth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBotName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbStreamOauth;
        private System.Windows.Forms.TextBox tbStreamName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDeepbotApi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDeepbotIp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCommandChar;
    }
}

