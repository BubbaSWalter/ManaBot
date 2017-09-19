using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Windows.Forms;
using System.Web.UI;
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
//CefSharp Includes includes
using CefSharp;

namespace ManaBot
{
    class TwitchConnect
    {
        public static TwitchClient StreamClient;
        public static TwitchClient BotClient;
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
            StreamClient.OnJoinedChannel += StreamerJoinedChannel;
            StreamClient.Connect();
            BotClient.Connect();
        }
        
        private static void BotJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            //BotClient.SendMessage("/me Merlin_Bot is here");
           
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
                            Console.WriteLine("Name: " + name);
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
                            Console.WriteLine("Name: " + name + " id: " + id);
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

        private static void StreamerReciviedMessage(object sender, OnMessageReceivedArgs e)
        {

            if (e.ChatMessage.Username.ToLower() == StreamClient.TwitchUsername)
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
                        Console.WriteLine("Name: " + name);
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
                        Console.WriteLine("Name: " + name + " id: " + id);
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
            string CMess = ChatMessage.Message;
            if("!" + Command != CMess)
            {
                try
                {
                    CMess = ChatMessage.Message.Split(new[] { " ", " " }, StringSplitOptions.None)[1];
                }
                catch
                {

                }
            }



            string Display = ChatMessage.DisplayName;
            string Uname = ChatMessage.Username;
            string Utype = Convert.ToString(ChatMessage.UserType).ToLower();
            //Console.WriteLine("Command Prams: " + Command + " " +  CMess + " " + Display + " " + Uname + " " + Utype);
            Twitch.TwitchCommands.PrebuiltCommands(Command, CMess, Uname, Display, Utype);
            //Console.WriteLine(e.Command.ChatMessage.Message);
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

            var lines = File.ReadAllLines(MainForm.WebDir + "chat.html").ToList();
            int Totalline = lines.Count();
            lines.Insert(Totalline - 3, placeholder + Environment.NewLine);
            File.WriteAllLines(MainForm.WebDir + "chat.html", lines);
            if (MainForm.chatBrowser.IsBrowserInitialized)
            {
                MainForm.chatBrowser.Reload();
            }
        }
    }
}
