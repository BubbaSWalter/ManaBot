namespace ManaBot
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ChatTab = new System.Windows.Forms.TabPage();
            this.scChatting = new System.Windows.Forms.SplitContainer();
            this.scChat = new System.Windows.Forms.SplitContainer();
            this.lbViewerList = new System.Windows.Forms.ListBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.tbChatMessage = new System.Windows.Forms.TextBox();
            this.cbMessageSender = new System.Windows.Forms.ComboBox();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbCurrencyName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNormalUser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSub2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMod2 = new System.Windows.Forms.TextBox();
            this.tbCheckCommandRep = new System.Windows.Forms.RichTextBox();
            this.tbCurrencyCommand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSub1 = new System.Windows.Forms.TextBox();
            this.tbSub3 = new System.Windows.Forms.TextBox();
            this.tbModLevel1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDeepbotApi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDeepbotIp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCommandChar = new System.Windows.Forms.TextBox();
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
            this.CommandsTab = new System.Windows.Forms.TabPage();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.InteractionTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.QueueTab = new System.Windows.Forms.TabPage();
            this.MiniGameTab = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.HeistTab = new System.Windows.Forms.TabPage();
            this.CrystalBallsTab = new System.Windows.Forms.TabPage();
            this.SongRequestTab = new System.Windows.Forms.TabPage();
            this.QuotesTab = new System.Windows.Forms.TabPage();
            this.ModTab = new System.Windows.Forms.TabPage();
            this.NotifyTab = new System.Windows.Forms.TabPage();
            this.TimerViewerList = new System.Windows.Forms.Timer(this.components);
            this.PointsGeneration = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.ChatTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChatting)).BeginInit();
            this.scChatting.Panel1.SuspendLayout();
            this.scChatting.Panel2.SuspendLayout();
            this.scChatting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChat)).BeginInit();
            this.scChat.Panel2.SuspendLayout();
            this.scChat.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.InteractionTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.MiniGameTab.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ChatTab);
            this.tabControl1.Controls.Add(this.SettingsTab);
            this.tabControl1.Controls.Add(this.CommandsTab);
            this.tabControl1.Controls.Add(this.UserTab);
            this.tabControl1.Controls.Add(this.InteractionTab);
            this.tabControl1.Controls.Add(this.ModTab);
            this.tabControl1.Controls.Add(this.NotifyTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // ChatTab
            // 
            this.ChatTab.BackColor = System.Drawing.Color.LightGray;
            this.ChatTab.Controls.Add(this.scChatting);
            this.ChatTab.Location = new System.Drawing.Point(4, 22);
            this.ChatTab.Name = "ChatTab";
            this.ChatTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChatTab.Size = new System.Drawing.Size(976, 535);
            this.ChatTab.TabIndex = 0;
            this.ChatTab.Text = "Chat Window";
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
            // 
            // scChatting.Panel2
            // 
            this.scChatting.Panel2.Controls.Add(this.SendMessage);
            this.scChatting.Panel2.Controls.Add(this.tbChatMessage);
            this.scChatting.Panel2.Controls.Add(this.cbMessageSender);
            this.scChatting.Size = new System.Drawing.Size(970, 529);
            this.scChatting.SplitterDistance = 500;
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
            this.scChat.Size = new System.Drawing.Size(970, 500);
            this.scChat.SplitterDistance = 750;
            this.scChat.TabIndex = 0;
            // 
            // lbViewerList
            // 
            this.lbViewerList.BackColor = System.Drawing.Color.Black;
            this.lbViewerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbViewerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewerList.ForeColor = System.Drawing.SystemColors.Window;
            this.lbViewerList.FormattingEnabled = true;
            this.lbViewerList.ItemHeight = 20;
            this.lbViewerList.Location = new System.Drawing.Point(0, 0);
            this.lbViewerList.Name = "lbViewerList";
            this.lbViewerList.Size = new System.Drawing.Size(216, 500);
            this.lbViewerList.TabIndex = 0;
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(890, 2);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(75, 23);
            this.SendMessage.TabIndex = 2;
            this.SendMessage.Text = "Send Message";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // tbChatMessage
            // 
            this.tbChatMessage.Location = new System.Drawing.Point(132, 3);
            this.tbChatMessage.Name = "tbChatMessage";
            this.tbChatMessage.Size = new System.Drawing.Size(752, 20);
            this.tbChatMessage.TabIndex = 1;
            this.tbChatMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatMessageBox_KeyDown);
            // 
            // cbMessageSender
            // 
            this.cbMessageSender.FormattingEnabled = true;
            this.cbMessageSender.Items.AddRange(new object[] {
            "Streamer",
            "Merlin_b0t"});
            this.cbMessageSender.Location = new System.Drawing.Point(5, 3);
            this.cbMessageSender.Name = "cbMessageSender";
            this.cbMessageSender.Size = new System.Drawing.Size(121, 21);
            this.cbMessageSender.TabIndex = 0;
            this.cbMessageSender.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cbMessageSender_MouseDoubleClick);
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.DimGray;
            this.SettingsTab.Controls.Add(this.groupBox3);
            this.SettingsTab.Controls.Add(this.groupBox2);
            this.SettingsTab.Controls.Add(this.groupBox1);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(976, 535);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings Tab";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbCurrencyName);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbNormalUser);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbSub2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbMod2);
            this.groupBox3.Controls.Add(this.tbCheckCommandRep);
            this.groupBox3.Controls.Add(this.tbCurrencyCommand);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbSub1);
            this.groupBox3.Controls.Add(this.tbSub3);
            this.groupBox3.Controls.Add(this.tbModLevel1);
            this.groupBox3.Location = new System.Drawing.Point(3, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 279);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(282, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Normal User: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Sub Tier3: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(297, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Sub Tier 2: ";
            // 
            // tbCurrencyName
            // 
            this.tbCurrencyName.Location = new System.Drawing.Point(98, 18);
            this.tbCurrencyName.Name = "tbCurrencyName";
            this.tbCurrencyName.Size = new System.Drawing.Size(144, 20);
            this.tbCurrencyName.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Sub Tier1: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Mod Level 2: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Currency Name: ";
            // 
            // tbNormalUser
            // 
            this.tbNormalUser.Location = new System.Drawing.Point(365, 96);
            this.tbNormalUser.Name = "tbNormalUser";
            this.tbNormalUser.Size = new System.Drawing.Size(151, 20);
            this.tbNormalUser.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mod Level 1: ";
            // 
            // tbSub2
            // 
            this.tbSub2.Location = new System.Drawing.Point(365, 70);
            this.tbSub2.Name = "tbSub2";
            this.tbSub2.Size = new System.Drawing.Size(151, 20);
            this.tbSub2.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Currency Command: ";
            // 
            // tbMod2
            // 
            this.tbMod2.Location = new System.Drawing.Point(365, 44);
            this.tbMod2.Name = "tbMod2";
            this.tbMod2.Size = new System.Drawing.Size(151, 20);
            this.tbMod2.TabIndex = 12;
            // 
            // tbCheckCommandRep
            // 
            this.tbCheckCommandRep.Location = new System.Drawing.Point(12, 152);
            this.tbCheckCommandRep.Name = "tbCheckCommandRep";
            this.tbCheckCommandRep.Size = new System.Drawing.Size(516, 96);
            this.tbCheckCommandRep.TabIndex = 7;
            this.tbCheckCommandRep.Text = "";
            // 
            // tbCurrencyCommand
            // 
            this.tbCurrencyCommand.Location = new System.Drawing.Point(365, 18);
            this.tbCurrencyCommand.Name = "tbCurrencyCommand";
            this.tbCurrencyCommand.Size = new System.Drawing.Size(151, 20);
            this.tbCurrencyCommand.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Response to the Points Command";
            // 
            // tbSub1
            // 
            this.tbSub1.Location = new System.Drawing.Point(98, 70);
            this.tbSub1.Name = "tbSub1";
            this.tbSub1.Size = new System.Drawing.Size(144, 20);
            this.tbSub1.TabIndex = 15;
            // 
            // tbSub3
            // 
            this.tbSub3.Location = new System.Drawing.Point(98, 96);
            this.tbSub3.Name = "tbSub3";
            this.tbSub3.Size = new System.Drawing.Size(144, 20);
            this.tbSub3.TabIndex = 14;
            // 
            // tbModLevel1
            // 
            this.tbModLevel1.Location = new System.Drawing.Point(98, 44);
            this.tbModLevel1.Name = "tbModLevel1";
            this.tbModLevel1.Size = new System.Drawing.Size(144, 20);
            this.tbModLevel1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbDeepbotApi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbDeepbotIp);
            this.groupBox2.Location = new System.Drawing.Point(260, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 202);
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
            this.groupBox1.Size = new System.Drawing.Size(257, 202);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Twitch Settings";
            // 
            // tbCommandChar
            // 
            this.tbCommandChar.Location = new System.Drawing.Point(98, 152);
            this.tbCommandChar.Name = "tbCommandChar";
            this.tbCommandChar.Size = new System.Drawing.Size(144, 20);
            this.tbCommandChar.TabIndex = 8;
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
            this.tbChannel.Size = new System.Drawing.Size(144, 20);
            this.tbChannel.TabIndex = 5;
            // 
            // tbBotOauth
            // 
            this.tbBotOauth.Location = new System.Drawing.Point(98, 97);
            this.tbBotOauth.Name = "tbBotOauth";
            this.tbBotOauth.PasswordChar = '*';
            this.tbBotOauth.Size = new System.Drawing.Size(144, 20);
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
            this.tbBotName.Size = new System.Drawing.Size(144, 20);
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
            this.tbStreamOauth.Size = new System.Drawing.Size(144, 20);
            this.tbStreamOauth.TabIndex = 1;
            // 
            // tbStreamName
            // 
            this.tbStreamName.Location = new System.Drawing.Point(98, 19);
            this.tbStreamName.Name = "tbStreamName";
            this.tbStreamName.Size = new System.Drawing.Size(144, 20);
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
            // CommandsTab
            // 
            this.CommandsTab.BackColor = System.Drawing.Color.DimGray;
            this.CommandsTab.Location = new System.Drawing.Point(4, 22);
            this.CommandsTab.Name = "CommandsTab";
            this.CommandsTab.Size = new System.Drawing.Size(976, 535);
            this.CommandsTab.TabIndex = 2;
            this.CommandsTab.Text = "Commands";
            // 
            // UserTab
            // 
            this.UserTab.BackColor = System.Drawing.Color.DimGray;
            this.UserTab.Location = new System.Drawing.Point(4, 22);
            this.UserTab.Name = "UserTab";
            this.UserTab.Size = new System.Drawing.Size(976, 535);
            this.UserTab.TabIndex = 3;
            this.UserTab.Text = "User Tab";
            // 
            // InteractionTab
            // 
            this.InteractionTab.BackColor = System.Drawing.Color.DimGray;
            this.InteractionTab.Controls.Add(this.tabControl2);
            this.InteractionTab.Location = new System.Drawing.Point(4, 22);
            this.InteractionTab.Name = "InteractionTab";
            this.InteractionTab.Size = new System.Drawing.Size(976, 535);
            this.InteractionTab.TabIndex = 4;
            this.InteractionTab.Text = "Interaction";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.QueueTab);
            this.tabControl2.Controls.Add(this.MiniGameTab);
            this.tabControl2.Controls.Add(this.SongRequestTab);
            this.tabControl2.Controls.Add(this.QuotesTab);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(976, 535);
            this.tabControl2.TabIndex = 0;
            // 
            // QueueTab
            // 
            this.QueueTab.BackColor = System.Drawing.Color.DimGray;
            this.QueueTab.Location = new System.Drawing.Point(4, 22);
            this.QueueTab.Name = "QueueTab";
            this.QueueTab.Padding = new System.Windows.Forms.Padding(3);
            this.QueueTab.Size = new System.Drawing.Size(968, 509);
            this.QueueTab.TabIndex = 0;
            this.QueueTab.Text = "Queue";
            // 
            // MiniGameTab
            // 
            this.MiniGameTab.BackColor = System.Drawing.Color.DimGray;
            this.MiniGameTab.Controls.Add(this.tabControl3);
            this.MiniGameTab.Location = new System.Drawing.Point(4, 22);
            this.MiniGameTab.Name = "MiniGameTab";
            this.MiniGameTab.Padding = new System.Windows.Forms.Padding(3);
            this.MiniGameTab.Size = new System.Drawing.Size(968, 509);
            this.MiniGameTab.TabIndex = 1;
            this.MiniGameTab.Text = "MiniGames";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.HeistTab);
            this.tabControl3.Controls.Add(this.CrystalBallsTab);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(962, 503);
            this.tabControl3.TabIndex = 0;
            // 
            // HeistTab
            // 
            this.HeistTab.Location = new System.Drawing.Point(4, 22);
            this.HeistTab.Name = "HeistTab";
            this.HeistTab.Padding = new System.Windows.Forms.Padding(3);
            this.HeistTab.Size = new System.Drawing.Size(954, 477);
            this.HeistTab.TabIndex = 0;
            this.HeistTab.Text = "Heist";
            this.HeistTab.UseVisualStyleBackColor = true;
            // 
            // CrystalBallsTab
            // 
            this.CrystalBallsTab.Location = new System.Drawing.Point(4, 22);
            this.CrystalBallsTab.Name = "CrystalBallsTab";
            this.CrystalBallsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CrystalBallsTab.Size = new System.Drawing.Size(954, 477);
            this.CrystalBallsTab.TabIndex = 1;
            this.CrystalBallsTab.Text = "CrystalBallTab";
            this.CrystalBallsTab.UseVisualStyleBackColor = true;
            // 
            // SongRequestTab
            // 
            this.SongRequestTab.Location = new System.Drawing.Point(4, 22);
            this.SongRequestTab.Name = "SongRequestTab";
            this.SongRequestTab.Size = new System.Drawing.Size(968, 509);
            this.SongRequestTab.TabIndex = 2;
            this.SongRequestTab.Text = "Song Requests";
            this.SongRequestTab.UseVisualStyleBackColor = true;
            // 
            // QuotesTab
            // 
            this.QuotesTab.Location = new System.Drawing.Point(4, 22);
            this.QuotesTab.Name = "QuotesTab";
            this.QuotesTab.Size = new System.Drawing.Size(968, 509);
            this.QuotesTab.TabIndex = 3;
            this.QuotesTab.Text = "Quotes";
            this.QuotesTab.UseVisualStyleBackColor = true;
            // 
            // ModTab
            // 
            this.ModTab.BackColor = System.Drawing.Color.DimGray;
            this.ModTab.Location = new System.Drawing.Point(4, 22);
            this.ModTab.Name = "ModTab";
            this.ModTab.Size = new System.Drawing.Size(976, 535);
            this.ModTab.TabIndex = 5;
            this.ModTab.Text = "Moderation Tab";
            // 
            // NotifyTab
            // 
            this.NotifyTab.BackColor = System.Drawing.Color.DimGray;
            this.NotifyTab.Location = new System.Drawing.Point(4, 22);
            this.NotifyTab.Name = "NotifyTab";
            this.NotifyTab.Size = new System.Drawing.Size(976, 535);
            this.NotifyTab.TabIndex = 6;
            this.NotifyTab.Text = "Notifcations";
            // 
            // TimerViewerList
            // 
            this.TimerViewerList.Interval = 120000;
            this.TimerViewerList.Tick += new System.EventHandler(this.ViewerList_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Text = "ManaBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ChatTab.ResumeLayout(false);
            this.scChatting.Panel1.ResumeLayout(false);
            this.scChatting.Panel2.ResumeLayout(false);
            this.scChatting.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChatting)).EndInit();
            this.scChatting.ResumeLayout(false);
            this.scChat.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scChat)).EndInit();
            this.scChat.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.InteractionTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.MiniGameTab.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ChatTab;
        private System.Windows.Forms.SplitContainer scChat;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.SplitContainer scChatting;
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
        private System.Windows.Forms.TabPage CommandsTab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox tbCheckCommandRep;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ListBox lbViewerList;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.TabPage InteractionTab;
        private System.Windows.Forms.TabPage ModTab;
        private System.Windows.Forms.TabPage NotifyTab;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.TextBox tbChatMessage;
        private System.Windows.Forms.ComboBox cbMessageSender;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage QueueTab;
        private System.Windows.Forms.TabPage MiniGameTab;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage HeistTab;
        private System.Windows.Forms.TabPage CrystalBallsTab;
        private System.Windows.Forms.TabPage SongRequestTab;
        private System.Windows.Forms.TabPage QuotesTab;
        private System.Windows.Forms.Timer TimerViewerList;
        private System.Windows.Forms.Timer PointsGeneration;
        private System.Windows.Forms.TextBox tbModLevel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNormalUser;
        private System.Windows.Forms.TextBox tbCurrencyName;
        private System.Windows.Forms.TextBox tbSub1;
        private System.Windows.Forms.TextBox tbSub3;
        private System.Windows.Forms.TextBox tbCurrencyCommand;
        private System.Windows.Forms.TextBox tbMod2;
        private System.Windows.Forms.TextBox tbSub2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

