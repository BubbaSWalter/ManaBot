using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ManaBot
{
    public class XmlSetting
    {
        private void UpdateXmlSettings()
        {
            //Create a new Config
            XmlConfig XmlConfigUpdate = new XmlConfig();
            //Twitch Settings
            XmlConfigUpdate.StreamerName = MainForm.StreamerName;
            XmlConfigUpdate.StreamerOauth = MainForm.StreamerOAuth;
            XmlConfigUpdate.BotName = MainForm.BotName;
            XmlConfigUpdate.BotOauth = MainForm.BotOauth;
            XmlConfigUpdate.Channel = MainForm.Channel;
            XmlConfigUpdate.CommandChar = MainForm.CommandChar;
            //Deepbot Settings
            XmlConfigUpdate.DeepBotIp = MainForm.DeepbotIp;
            XmlConfigUpdate.DeepBotAPI = MainForm.DeepbotApi;
            //Currency Settings
            XmlConfigUpdate.Mod1 = MainForm.Mod1;
            XmlConfigUpdate.Mod2 = MainForm.Mod2;
            XmlConfigUpdate.Vip1 = MainForm.Sub1;
            XmlConfigUpdate.Vip2 = MainForm.Sub2;
            XmlConfigUpdate.Vip3 = MainForm.Sub3;
            XmlConfigUpdate.NormalViewer = MainForm.NormalViewer;
            XmlConfigUpdate.CheckCommand = MainForm.CheckCommand;

            XmlConfig.Serialize(MainForm.FilesDir + "config.xml", XmlConfigUpdate);
        }

        private void LoadXmlSettings()
        {
            XmlConfig XMLConfigLoad = XmlConfig.DeSerialize(MainForm.FilesDir + "config.xml");
            MainForm.StreamerName = XMLConfigLoad.StreamerName;
            MainForm.StreamerOAuth = XMLConfigLoad.StreamerOauth;
            MainForm.BotName = XMLConfigLoad.BotName;
            MainForm.BotOauth = XMLConfigLoad.BotOauth;
            MainForm.Channel = XMLConfigLoad.Channel;
            MainForm.CommandChar = XMLConfigLoad.CommandChar;
            Console.WriteLine(XMLConfigLoad.CommandChar);
        }
    }

    public class XmlConfigTransfer
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
        #endregion

    }


}
