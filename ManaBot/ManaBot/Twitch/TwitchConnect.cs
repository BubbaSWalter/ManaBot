using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Web.UI;
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
//CefSharp Includes includes
using CefSharp;
using CefSharp.WinForms;

namespace ManaBot
{
    class TwitchConnect
    {
        public static TwitchClient StreamClient;
        public static TwitchClient BotClient;
        public static void TwitchConnection()
        {
            ConnectionCredentials StreamCreds = new ConnectionCredentials(ManaBot.StreamerName, ManaBot.StreamerOAuth);
            ConnectionCredentials BotCreds = new ConnectionCredentials(ManaBot.BotName, ManaBot.BotOauth);
            StreamClient = new TwitchClient(StreamCreds, ManaBot.Channel);
            BotClient = new TwitchClient(BotCreds, ManaBot.Channel);
            BotClient.OnJoinedChannel += BotJoinedChannel;
            BotClient.OnMessageReceived += BotReciviedMessage;
            BotClient.OnChatCommandReceived += BotCommandRecivied;
            BotClient.AddChatCommandIdentifier(ManaBot.CommandChar);
            BotClient.AddWhisperCommandIdentifier(ManaBot.CommandChar);
            StreamClient.OnMessageReceived += StreamerReciviedMessage;
            StreamClient.Connect();
            BotClient.Connect();
        }

        private static void BotJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            BotClient.SendMessage("/me Merlin_Bot is here");
        }

        private static void BotReciviedMessage(object sender, OnMessageReceivedArgs e)
        {

        }
        private static void StreamerReciviedMessage(object sender, OnMessageReceivedArgs e)
        {
            string uname = e.ChatMessage.DisplayName;
            string utype = Convert.ToString(e.ChatMessage.UserType).ToLower();
            bool Subscriber = e.ChatMessage.IsSubscriber;
            bool Broadcaster = false;
            if (e.ChatMessage.Username == ManaBot.StreamerName)
            {
                Broadcaster = true;
            }
            bool Turbo = e.ChatMessage.IsTurbo;
            string ChatMessage = e.ChatMessage.Message;
            //Console.WriteLine("usertype: " + utype );
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


        private static void WebChat(string UserName, string UserType, bool SubStatus, bool Broadcaster, string ChatMessage)
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

            var lines = File.ReadAllLines(ManaBot.WebDir + "chat.html").ToList();
            int Totalline = lines.Count();
            lines.Insert(Totalline - 3, placeholder + Environment.NewLine);
            File.WriteAllLines(ManaBot.WebDir + "chat.html", lines);
            if (ManaBot.chatBrowser.IsBrowserInitialized)
            {
                ManaBot.chatBrowser.Reload();
            }



        }


    }
}
