using System;
using System.IO;
using System.Web.UI;
using System.Data.SQLite;
using System.Windows.Forms;
using CefSharp;
using System.Collections.Generic;
using CefSharp.WinForms;
using System.Net;
using TwitchCSharp;
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
using System.Linq;



namespace ManaBot
{
    public partial class MainForm : Form
    {
        #region Variables
        #region Web Browsers
        public static ChromiumWebBrowser chatBrowser;
        #endregion

        #region Twitch Settings
        public static string StreamerName = "StreamerName";
        public static string StreamerOAuth = "StreamerOauth";
        public static string BotName = "BotName";
        public static string BotOauth = "BotOauth";
        public static string Channel = "Channel";


        #endregion

        #region Database
        SQLiteConnection dbCmd;
        SQLiteConnection dbSet;
        string Commandsfile = FilesDir + "commands.sqlite";
        string Settingsfile = FilesDir + "settings.sqlite";
        #endregion

        #region Deepbot Settings
        public static string DeepbotIp = "Deepbot IP Address";
        public static string DeepbotApi = "Deepbot API KEY";
        #endregion

        #region Twitch LibSettings
        public static char CommandChar = '!';
        public static TwitchClient StreamClient;
        public static TwitchClient BotClient;
        public static List<string> Admin = new List<string>();
        public static List<string> Staff = new List<string>();
        public static List<string> GlobalMod = new List<string>();
        public static List<string> Mod = new List<string>();
        public static List<string> Viewer = new List<string>();
        #endregion
        #region Currency Settings
        public static string Mod1 = "Mod Level 1";
        public static string Mod2 = "Mod Level 2";
        public static string Sub1 = "Subscriber Level 1";
        public static string Sub2 = "Subscriber Level 2";
        public static string Sub3 = "Subscriber Level 3";
        public static string NormalViewer = "Viewer";
        public static string CurrencyName = "points";
        public static string CheckCommand = "points";
        public static string CheckCommandRep = "$user has $points mana. " +
            "They are curenntly a level $userranknum mage and the last spell they learned was $userrank. " +
            "They have been at The Apprenticeship for $hours and " +
            "they are currently a $title";
        #endregion

        #region Notify
        List<string> Host = new List<string>();
        List<string> Follow = new List<string>();
        List<string> Tier1 = new List<string>();
        List<string> Tier2 = new List<string>();
        List<string> Tier3 = new List<string>();
        #endregion

        #region Directory Settings
        public static string CurrentDir = Directory.GetCurrentDirectory();
        public static string FilesDir = CurrentDir + @"\files\";
        public static string DataDir = CurrentDir + @"\database\";
        public static string WebDir = CurrentDir + @"\web\";
        #endregion

        #region TwitchAPI
        static string TwitchClientID = TopSecret.ClientID;
        static string TwitchApiAuth = TopSecret.TwitchAuthToken;
        
        #endregion

        #endregion

        #region Forms
        public MainForm()
        {
            InitializeComponent();
            // Start the browser after initialize global component
            InitializeChat();
 
        }

        public void InitializeChat()
        {
            CefSettings settings = new CefSettings() {
                CachePath = "Cache",
            };
            // Initialize cef with the provided settings
            if (!Cef.IsInitialized)
            {
                Cef.Initialize(settings);
            }
            
            // Create a browser component
            chatBrowser = new ChromiumWebBrowser(WebDir + "chat.html");
            //chatBrowser.LoadString();
            // Add it to the form and fill it to the form window.
            //this.Controls.Add(chatBrowser);
            scChat.Panel1.Controls.Add(chatBrowser);
            chatBrowser.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //LoadXmlSettings();
            FileManagement.DataBase.UpdateSettings();
            UpdateTextBoxes();
            this.lbViewerList.VisibleChanged += new System.EventHandler(Form1_shown);
            Console.WriteLine(CheckCommandRep);
            TwitchConnect Twitcher = new TwitchConnect();
            cbMessageSender.SelectedIndex = 0;
            if(!File.Exists(DataDir + "Settings.sqlite"))
            {
                FileManagement.DataBase.CreateSettings();
            }
            
            
        }

        private void Form1_shown(object sender, EventArgs e)
        {
            TwitchConnection();
        }

        #endregion

        private void UpdateTextBoxes()
        {
            //Twitch Settings
            tbStreamName.Text = StreamerName;
            tbStreamOauth.Text = StreamerOAuth;
            tbBotName.Text = BotName;
            tbBotOauth.Text = BotOauth;
            tbChannel.Text = Channel;

            //Deepbot Settings
            tbDeepbotApi.Text = DeepbotApi;
            tbDeepbotIp.Text = DeepbotIp;
            //Comannds Settings
            tbCommandChar.Text = Convert.ToString(CommandChar);

            //Points Settings
            tbModLevel1.Text = Mod1;
            tbMod2.Text = Mod2;
            tbSub1.Text = Sub1;
            tbSub2.Text = Sub2;
            tbSub3.Text = Sub3;
            tbCurrencyName.Text = CurrencyName;
            tbNormalUser.Text = NormalViewer;
            tbCurrencyCommand.Text = CheckCommand;
            tbCheckCommandRep.Text = CheckCommandRep;

            
        }

        public static void TwitchConnection()
        {
            ConnectionCredentials StreamCreds = new ConnectionCredentials(MainForm.StreamerName, MainForm.StreamerOAuth);
            ConnectionCredentials BotCreds = new ConnectionCredentials(MainForm.BotName, MainForm.BotOauth);
            StreamClient = new TwitchClient(StreamCreds, MainForm.Channel);
            BotClient = new TwitchClient(BotCreds, MainForm.Channel);
            BotClient.OnJoinedChannel += BotJoinedChannel;
            BotClient.OnMessageReceived += BotReciviedMessage;
            BotClient.OnChatCommandReceived += BotCommandRecivied;
            BotClient.AddChatCommandIdentifier(MainForm.CommandChar);
            BotClient.AddWhisperCommandIdentifier(MainForm.CommandChar);
            BotClient.OnUserJoined += UserJoined;
            StreamClient.OnBeingHosted += HostAlert;
            StreamClient.OnNewSubscriber += NewSub;
            BotClient.OnExistingUsersDetected += CurrentUsers;
            StreamClient.OnJoinedChannel += StreamerJoinedChannel;
            StreamClient.OnMessageReceived += StreamReciviedMessage;
            StreamClient.Connect();
            BotClient.Connect();
        }

        #region Twitch Connection FUNctions
        private static void BotJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            //BotClient.SendMessage("/me Merlin_Bot is here");

        }

        private static void UserJoined(object sender, OnUserJoinedArgs e)
        {
            Viewer.Add(e.Username);
            Viewer.Sort();
            foreach(string item in Viewer)
            {
                MainForm frm1 = new MainForm();
                if (frm1.InvokeRequired) frm1.Invoke((Action)(() => frm1.lbViewerList.Items.Clear()));
                if (frm1.InvokeRequired) frm1.Invoke((Action)(() => frm1.lbViewerList.Items.Add(item)));
            }
        }

        private static void CurrentUsers(object sender, OnExistingUsersDetectedArgs e)
        {
            foreach(string user in e.Users)
            {
                Viewer.Add(user);
                Viewer.Sort();
                foreach (string item in Viewer)
                {
                    MainForm frm1 = new MainForm();
                    if(frm1.InvokeRequired) frm1.Invoke((Action)(() => frm1.lbViewerList.Items.Clear()));

                    if (frm1.InvokeRequired) frm1.Invoke((Action)(() => frm1.lbViewerList.Items.Add(item)));
                }
            }
        }

        private static void HostAlert(object sender, OnBeingHostedArgs e)
        {
            string Host = e.Channel;
            int Viewer = e.Viewers;
        }

        private static void NewSub(object sender, OnNewSubscriberArgs e )
        {
            string Useranme = e.Subscriber.DisplayName;
            string Tier = e.Subscriber.SubscriptionPlan.ToString();
            string Months = e.Subscriber.Months.ToString();
            string mess = e.Subscriber.ResubMessage;
        }

        private static void StreamerJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            //StreamClient.SendMessage("/me WizardsRWe is here");

        }

        private static void BotReciviedMessage(object sender, OnMessageReceivedArgs e)
        {
            
            if (e.ChatMessage.Username.ToLower() == MainForm.StreamerName.ToLower())
            {
                string uname = e.ChatMessage.DisplayName;
                string utype = Convert.ToString(e.ChatMessage.UserType).ToLower();
                bool Subscriber = e.ChatMessage.IsSubscriber;
                bool Broadcaster = false;
                if (e.ChatMessage.Username == MainForm.StreamerName)
                {
                    Broadcaster = true;
                }
                bool Turbo = e.ChatMessage.IsTurbo;
                string ChatMessage = e.ChatMessage.Message;
                foreach (var emote in e.ChatMessage.EmoteSet.Emotes)
                {
                    var name = emote.Name;
                    var start = emote.StartIndex;
                    var url = emote.ImageUrl;
                    ChatMessage = ChatMessage.Replace(name, " " + "<img  class=\"tag\" src=\"" + url + "\" + ></img>" + " ");
                }
                using (WebClient Client = new WebClient())
                {
                    string globalbttv = Client.DownloadString("https://api.betterttv.net/2/emotes");
                    globalbttv = globalbttv.Replace(" ", "");
                    string channelbttv = Client.DownloadString("https://api.betterttv.net/2/channels/wizardsrwe");

                    string channelemotelist = channelbttv.Split(new string[] { "\"emotes\":[", "]}" }, StringSplitOptions.None)[1];
                    string Globalemotelist = globalbttv.Split(new string[] { "\"emotes\":[", "" }, StringSplitOptions.None)[1];
                    foreach (string item in channelemotelist.Split(new string[] { "{", "}" }, StringSplitOptions.None))
                    {
                        if (item != "," && item != " " && item != "")
                        {

                            string id = item.Split(new string[] { "\"", "\"" }, StringSplitOptions.None)[3];
                            string name = item.Split(new string[] { "\"", "\"" }, StringSplitOptions.None)[11];
                            string url = "cdn.betterttv.net/emote/" + id + "/1x";
                            //Console.WriteLine("Name: " + name);
                            ChatMessage = ChatMessage.Replace(name, " " + "<img  class=\"tag\" src=\"https://" + url + "\"></img>" + " ");

                        }
                    }
                    foreach (string item in Globalemotelist.Split(new string[] { "{", "}" }, StringSplitOptions.None))
                    {

                        if (item != "," && item != " " && item != "" && item != "]" && !item.Contains("channels") && !item.Contains("imageType"))
                        {
                            string id = item.Split(new string[] { "\"", "\"" }, StringSplitOptions.None)[3];
                            string name = item.Split(new string[] { "\"", "\"" }, StringSplitOptions.None)[7];
                            string url = "cdn.betterttv.net/emote/" + id + "/1x";
                            //Console.WriteLine("Name: " + name + " id: " + id);
                            ChatMessage = ChatMessage.Replace(name, " " + "<img  class=\"tag\" src=\"https://" + url + "\"></img>" + " ");
                        }
                    }
                }
                WebChat(uname, utype, Subscriber, Broadcaster, ChatMessage);
            }
        }

        private static void StreamerSentMessage(object sender, OnMessageSentArgs e)
        {

        }

        private static void StreamReciviedMessage(object sender, OnMessageReceivedArgs e)
        {

            if (e.ChatMessage.Username.ToLower() == MainForm.StreamerName.ToLower())
            {
                return;
            }
            string uname = e.ChatMessage.DisplayName;
            string utype = Convert.ToString(e.ChatMessage.UserType).ToLower();
            bool Subscriber = e.ChatMessage.IsSubscriber;
            bool Broadcaster = false;
            if (e.ChatMessage.Username == MainForm.StreamerName)
            {
                Broadcaster = true;
            }
            bool Turbo = e.ChatMessage.IsTurbo;
            string ChatMessage = e.ChatMessage.Message;
            foreach (var emote in e.ChatMessage.EmoteSet.Emotes)
            {
                var name = emote.Name;
                var start = emote.StartIndex;
                var url = emote.ImageUrl;
                ChatMessage = ChatMessage.Replace(name, " " + "<img  class=\"tag\" src=\"" + url + "\" + ></img>" + " ");
            }
            using (WebClient Client = new WebClient())
            {
                string globalbttv = Client.DownloadString("https://api.betterttv.net/2/emotes");
                globalbttv = globalbttv.Replace(" ", "");
                string channelbttv = Client.DownloadString("https://api.betterttv.net/2/channels/wizardsrwe");

                string channelemotelist = channelbttv.Split(new string[] { "\"emotes\":[", "]}" }, StringSplitOptions.None)[1];
                string Globalemotelist = globalbttv.Split(new string[] { "\"emotes\":[", "" }, StringSplitOptions.None)[1];
                foreach (string item in channelemotelist.Split(new string[] { "{", "}" }, StringSplitOptions.None))
                {
                    if (item != "," && item != " " && item != "")
                    {

                        string id = item.Split(new string[] { "\"", "\"" }, StringSplitOptions.None)[3];
                        string name = item.Split(new string[] { "\"", "\"" }, StringSplitOptions.None)[11];
                        string url = "cdn.betterttv.net/emote/" + id + "/1x";
                        //Console.WriteLine("Name: " + name);
                        ChatMessage = ChatMessage.Replace(name, " " + "<img  class=\"tag\" src=\"https://" + url + "\"></img>" + " ");

                    }
                }
                foreach (string item in Globalemotelist.Split(new string[] { "{", "}" }, StringSplitOptions.None))
                {

                    if (item != "," && item != " " && item != "" && item != "]" && !item.Contains("channels") && !item.Contains("imageType"))
                    {
                        string id = item.Split(new string[] { "\"", "\"" }, StringSplitOptions.None)[3];
                        string name = item.Split(new string[] { "\"", "\"" }, StringSplitOptions.None)[7];
                        string url = "cdn.betterttv.net/emote/" + id + "/1x";
                        //Console.WriteLine("Name: " + name + " id: " + id);
                        ChatMessage = ChatMessage.Replace(name, " " + "<img  class=\"tag\" src=\"https://" + url + "\"></img>" + " ");
                    }
                }
            }
            WebChat(uname, utype, Subscriber, Broadcaster, ChatMessage);
        }

        private static void BotCommandRecivied(object sender, OnChatCommandReceivedArgs e)
        {
            var ChatMessage = e.Command.ChatMessage;
            
            string Command = e.Command.Command;
            List<string> args = e.Command.ArgumentsAsList;
            string Display = ChatMessage.DisplayName;
            string Uname = ChatMessage.Username;
            bool IsArgs = false;
            if (args.Count > 0) IsArgs = true;
            Console.WriteLine(IsArgs.ToString());
            string Utype = Convert.ToString(ChatMessage.UserType).ToLower();
            Console.WriteLine("Command Prams: " + Command + " " +  args + " " + Display + " " + Uname + " " + Utype);
            Twitch.TwitchCommands.PrebuiltCommands(Command, IsArgs , args, Uname, Display, Utype);
            Console.WriteLine(e.Command.ChatMessage.Message);
        }

        public static void WebChat(string UserName, string UserType, bool SubStatus, bool Broadcaster, string ChatMessage)
        {
            string tagcast = "tag ";
            string tagtype = "tag ";
            string tagsub = "tag ";
            string placeholder;
            //User types moderator, global mod, admin, or staff
            switch (UserType.ToLower())
            {
                case "broadcaster":
                    tagtype += "moderator";
                    break;
                case "moderator":
                    tagtype += "moderator";
                    break;
                case "global mod":
                    tagtype += "global mod";
                    break;
                case "staff":
                    tagtype += "staff";
                    break;
                case "admin":
                    tagtype += "admin";
                    break;
                default:
                    tagtype = "";
                    break;

            }
            StringWriter textwriter = new StringWriter();
            using (HtmlTextWriter writer = new HtmlTextWriter(textwriter))
            {
                #region ChatLine
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "chatline");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
                #region Badges
                //Broadcaster
                if (Broadcaster == true)
                {
                    tagcast += "caster";
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, tagcast);
                    writer.RenderBeginTag(HtmlTextWriterTag.Span);
                    writer.Write("&nbsp;");
                    writer.RenderEndTag();
                }
                //UserType
                if (tagtype != "")
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, tagtype);
                    writer.RenderBeginTag(HtmlTextWriterTag.Span);
                    writer.Write("&nbsp;");
                    writer.RenderEndTag();
                }
                //Subscriber
                if (SubStatus == true)
                {
                    tagsub += "subscriber";
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, tagsub);
                    writer.RenderBeginTag(HtmlTextWriterTag.Span);
                    writer.Write("&nbsp;");
                    writer.RenderEndTag();
                }
                #endregion

                #region Username
                /* Difference between Username & DisplayName
                 * username = bubbaswalter
                 * DisplayName = BubbaSWalter
                 */

                writer.AddAttribute(HtmlTextWriterAttribute.Class, "username");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
                writer.Write(UserName + ": ");
                writer.RenderEndTag();
                #endregion

                #region ChatMessage
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "message");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
                writer.Write(ChatMessage);
                writer.RenderEndTag();
                #endregion
                writer.RenderEndTag();
                #endregion
            }

            placeholder = textwriter.ToString();
            List<string> lines = File.ReadAllLines(MainForm.WebDir + "chat.html").ToList();
            int Totalline = lines.Count();
            lines.Insert(Totalline - 3, placeholder + Environment.NewLine);
            File.WriteAllLines(MainForm.WebDir + "chat.html", lines);
            MainForm frm1 = new MainForm();
            Console.WriteLine("MEsage Processed");
            
            if (chatBrowser.IsBrowserInitialized)
            {
                if (frm1.InvokeRequired)
                {
                    frm1.Invoke((Action)(() => chatBrowser.Reload(true)));
                    frm1.Invoke((Action)(() => chatBrowser.Refresh()));
                }
                else
                {
                    chatBrowser.Reload();
                }
            }
        }

        #endregion

        private void ChatMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessageFun();
            }
        }

        private void SendMessageFun()
        {
            string message = tbChatMessage.Text;
            if(cbMessageSender.SelectedIndex == 0)
            {
                StreamClient.SendMessage(message);

                //TwitchConnect.WebChat(TwitchConnect.StreamClient.TwitchUsername, "broadcaster", true, true, message);
            }
            else
            {
                BotClient.SendMessage(message);
            }


            tbChatMessage.Text = "";
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            SendMessageFun();
        }

        private void cbMessageSender_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cbMessageSender.SelectedIndex == 0) cbMessageSender.SelectedIndex = 1;
            if (cbMessageSender.SelectedIndex == 1) cbMessageSender.SelectedIndex = 2;
        }

        private void ViewerList_Tick(object sender, EventArgs e)
        {
            ViewerListUpdate();
        }

        private void ViewerListUpdate()
        {

        }
    }

    
}
