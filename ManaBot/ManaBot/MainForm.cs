﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using CefSharp;
using CefSharp.WinForms;
using System.Net;



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
        public static char CommandChar = '!';

        #endregion

        #region Database
        SQLiteConnection dbCmd;
        string Commandsfile = FilesDir + "commands.sqlite";
        #endregion

        #region Deepbot Settings
        public static string DeepbotIp = "Deepbot IP Address";
        public static string DeepbotApi = "Deepbot API KEY";
        #endregion


        #region Currency Settings
        public static string Mod1 = "Mod Level 1";
        public static string Mod2 = "Mod Level 2";
        public static string Sub1 = "Subscriber Level 1";
        public static string Sub2 = "Subscriber Level 2";
        public static string Sub3 = "Subscriber Level 3";
        public static string NormalViewer = "Viewer";
        public static string Currency = "points";
        public static string CheckCommand = "points";
        public static string CheckCommandRep = "$user has $points mana. " +
            "They are curenntly a level $userranknum mage and the last spell they learned was $userrank. " +
            "They have been at The Apprenticeship for $hours and " +
            "they are currently a $title";
        #endregion

        #region Directory Settings;
        public static string CurrentDir = Directory.GetCurrentDirectory();
        public static string FilesDir = CurrentDir + @"\files\";
        public static string WebDir = CurrentDir + @"\web\";
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
            CefSettings settings = new CefSettings();
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
            if (!File.Exists(FilesDir + "config.xml"))
            {
                UpdateXmlSettings();
            }
            if(!File.Exists(FilesDir + "commands.sqlite"))
            {
                /* Permission Levels
                 * 1 = Viewer
                 * 2 = Subscriber
                 * 3 = Moderator
                 * 4 = Editor
                 * 5 = Streamer
                 */
                SQLiteConnection.CreateFile(FilesDir + "commands.sqlite");
                dbCmd = new SQLiteConnection("Data Source="  + FilesDir  + "commands.sqlite;Version=3;");
                dbCmd.Open();
                string sql = "CREATE TABLE `commandlist` (" +
	                            "`Commands`	TEXT, "+
	                            "`PermLevel`	INTEGER," +
	                            "`Message`	TEXT, " + 
	                            "PRIMARY KEY(`Commands`)"+
                            ")";
                SQLiteCommand dbc = new SQLiteCommand(sql, dbCmd);
                dbc.ExecuteNonQuery();
                dbCmd.Close();



            }
            LoadXmlSettings();
            UpdateTextBoxes();
            TwitchConnect.TwitchConnection();
            Console.WriteLine(CheckCommandRep);
            TwitchConnect Twitcher = new TwitchConnect();
            cbMessageSender.SelectedIndex = 0;
            jsontest();
        }
        
        private void jsontest()
        {
            using (WebClient Edword = new WebClient())
            {
                string globalnttv = Edword.DownloadString("https://api.betterttv.net/2/emotes");
                string channelbttv= Edword.DownloadString("https://api.betterttv.net/2/channels/wizardsrwe");
                string urls = "";
                //MessageBox.Show(channelbttv);
                string channelemotelist = channelbttv.Split(new string[] { "\"emotes\":[", "]}" }, StringSplitOptions.None)[1];
                //MessageBox.Show(channelemotelist);
                foreach (string item in channelemotelist.Split(new string[] { "{" , "}" }, StringSplitOptions.None))
                {
                    //"id":"58a7fb0a06e70d0465b2a9ee","channel":"wizardsrwe","code":"wizard4MAGIC","imageType":"png"
                    if(item != "," && item != " " && item != "")
                    {
                        
                        string id = item.Split(new string[] { "\"", "\"" }, StringSplitOptions.None)[3];
                        string code = item.Split(new string[] { "\"", "\"" }, StringSplitOptions.None)[11];
                        urls += "cdn.betterttv.net/emote/" + id + "/2x" + Environment.NewLine;
                        
                    }
                    //MessageBox.Show(urls);
                    
                }
                File.AppendAllText(FilesDir + "json.text", urls + Environment.NewLine);
            }
        }

        #endregion

        #region Xml Settings
        private void UpdateXmlSettings()
        {
            //Create a new Config
            XmlConfig XmlConfigUpdate = new XmlConfig();
            //Twitch Settings
            XmlConfigUpdate.StreamerName = StreamerName;
            XmlConfigUpdate.StreamerOauth = StreamerOAuth;
            XmlConfigUpdate.BotName = BotName;
            XmlConfigUpdate.BotOauth = BotOauth;
            XmlConfigUpdate.Channel = Channel;
            XmlConfigUpdate.CommandChar = CommandChar;
            //Deepbot Settings
            XmlConfigUpdate.DeepBotIp = DeepbotIp;
            XmlConfigUpdate.DeepBotAPI = DeepbotApi;
            //Currency Settings
            XmlConfigUpdate.Mod1 = Mod1;
            XmlConfigUpdate.Mod2 = Mod2;
            XmlConfigUpdate.Vip1 = Sub1;
            XmlConfigUpdate.Vip2 = Sub2;
            XmlConfigUpdate.Vip3 = Sub3;
            XmlConfigUpdate.NormalViewer = NormalViewer;
            XmlConfigUpdate.CheckCommand = CheckCommand;
            XmlConfigUpdate.CheckCommandRep = CheckCommandRep;

            XmlConfig.Serialize(FilesDir + "config.xml", XmlConfigUpdate);
        }

        private void LoadXmlSettings()
        {
            XmlConfig XMLConfigLoad = XmlConfig.DeSerialize(FilesDir + "config.xml");
            StreamerName = XMLConfigLoad.StreamerName;
            StreamerOAuth = XMLConfigLoad.StreamerOauth;
            BotName = XMLConfigLoad.BotName;
            BotOauth = XMLConfigLoad.BotOauth;
            Channel = XMLConfigLoad.Channel;
            CommandChar = XMLConfigLoad.CommandChar;
            CheckCommand = XMLConfigLoad.CheckCommand;
            CheckCommandRep = XMLConfigLoad.CheckCommandRep;
            Mod1 = XMLConfigLoad.Mod1;
            Mod2 = XMLConfigLoad.Mod2;
            Sub1 = XMLConfigLoad.Vip1;
            Sub2 = XMLConfigLoad.Vip2;
            Sub3 = XMLConfigLoad.Vip3;
            NormalViewer = XMLConfigLoad.NormalViewer;
            DeepbotApi = XMLConfigLoad.DeepBotAPI;
            DeepbotIp = XMLConfigLoad.DeepBotIp;
            

        }

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
            tbCheckCommandRep.Text = CheckCommandRep;
            
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
                TwitchConnect.StreamClient.SendMessage(message);

                //TwitchConnect.WebChat(TwitchConnect.StreamClient.TwitchUsername, "broadcaster", true, true, message);
            }
            else
            {
                TwitchConnect.BotClient.SendMessage(message);
            }


            tbChatMessage.Text = "";
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            SendMessageFun();
        }
    }


    public class XmlConfig
    {
        #region Twitch Vars
        string _Streamername;
        string _StreamerOauth;
        string _BotName;
        string _BotOauth;
        string _Channel;
        char _CommandChar;
        #endregion

        #region Currency Vars
        string _Mod1;
        string _Mod2;
        string _Vip1;
        string _Vip2;
        string _Vip3;
        string _NormalViewer;
        string _CurrencyName;
        string _CheckCommand;
        string _CheckCommandRep;
        #endregion

        #region Deepbot Vars
        string _DeepBotAPI;
        string _DeepBotIp;
        #endregion

        #region Read & Write
        public static void Serialize(string file, XmlConfig c)
        {
            System.Xml.Serialization.XmlSerializer xs =
                new XmlSerializer(c.GetType());
            StreamWriter write = File.CreateText(file);
            xs.Serialize(write, c);
            write.Flush();
            write.Close();
        }

        public static XmlConfig DeSerialize(string file)
        {
            System.Xml.Serialization.XmlSerializer xs =
                new XmlSerializer(typeof(XmlConfig));
            StreamReader read = File.OpenText(file);
            XmlConfig c = (XmlConfig)xs.Deserialize(read);
            read.Close();
            return c;
        }
        #endregion

        #region Twitch Settings
        public string StreamerName
        {
            get { return _Streamername; }
            set { _Streamername = value; }
        }

        public string StreamerOauth
        {
            get { return _StreamerOauth; }
            set { _StreamerOauth = value; }
        }

        public string BotName
        {
            get { return _BotName; }
            set { _BotName = value; }
        }

        public string BotOauth
        {
            get { return _BotOauth; }
            set { _BotOauth = value; }
        }

        public string Channel
        {
            get { return _Channel; }
            set { _Channel = value; }
        }
        public char CommandChar
        {
            get { return _CommandChar; }
            set { _CommandChar = value; }
        }
        #endregion

        #region DeepBot Settings
        public string DeepBotAPI
        {
            get { return _DeepBotAPI; }
            set { _DeepBotAPI = value; }
        }
        public string DeepBotIp
        {
            get { return _DeepBotIp; }
            set { _DeepBotIp = value; }
        }
        #endregion

        #region Rank Settings
        public string Mod1
        {
            get { return _Mod1; }
            set { _Mod1 = value; }
        }
        public string Mod2
        {
            get { return _Mod2; }
            set { _Mod2 = value; }
        }
        public string Vip1
        {
            get { return _Vip1; }
            set { _Vip1 = value; }
        }
        public string Vip2
        {
            get { return _Vip2; }
            set { _Vip2 = value; }
        }
        public string Vip3
        {
            get { return _Vip3; }
            set { _Vip3 = value; }
        }
        public string NormalViewer
        {
            get { return _NormalViewer; }
            set { _NormalViewer = value; }
        }
        public string CurrencyName
        {
            get { return _CurrencyName; }
            set { _CurrencyName = value; }
        }
        public string CheckCommand
        {
            get { return _CheckCommand; }
            set { _CheckCommand = value; }
        }
        public string CheckCommandRep
        {
            get { return _CheckCommandRep; }
            set { _CheckCommandRep = value; }
        }
        #endregion

    }
}
