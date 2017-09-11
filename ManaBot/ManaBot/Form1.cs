using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

//CefSharp Includes includes
using CefSharp;
using CefSharp.WinForms;

//Twitch Includes
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;



namespace ManaBot
{
    public partial class Form1 : Form
    {
        #region Variables
        #region Web Browsers
        public ChromiumWebBrowser chatBrowser;
        #endregion

        #region Twitch Settings
        static string StreamerName = null;
        static string StreamerOAuth = null;
        static string BotName = null;
        static string BotOauth = null;
        static string Channel = null;
        TwitchClient StreamClient;
        TwitchClient BotClient;
        #endregion

        #region Deepbot Settings
        public static string DeepbotIp = null;
        public static string DeepbotApi = null;
        #endregion

        #region Twitch API RESTRICTED
        static string TwitchClientID = null;
        static string TwitchToken = null;
        #endregion

        #region currency check
        public static string Mod1 = null;
        public static string Mod2 = null;
        public static string Sub1 = null;
        public static string Sub2 = null;
        public static string Sub3 = null;
        public static string Currency = "points";
        #endregion

        #endregion
        public Form1()
        {
            InitializeComponent();
            // Start the browser after initialize global component
            InitializeChat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        public void InitializeChat()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chatBrowser = new ChromiumWebBrowser("http://ourcodeworld.com");
            // Add it to the form and fill it to the form window.
            //this.Controls.Add(chatBrowser);
            scChat.Panel1.Controls.Add(chatBrowser);
            chatBrowser.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }


    }
}
