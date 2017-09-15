using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;

namespace ManaBot
{
    class TwitchConnect
    {
        TwitchClient StreamClient;
        TwitchClient BotClient;
        public TwitchConnect()
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
            StreamClient.Connect();
            BotClient.Connect();
        }

        private void BotJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            BotClient.SendMessage("/me Merlin_Bot is here");
        }

        private void BotReciviedMessage(object sender, OnMessageReceivedArgs e)
        {

        }
        private void BotCommandRecivied(object sender, OnChatCommandReceivedArgs e)
        {
            if (e.Command.Command.ToLower().Contains("test"))
            {
                BotClient.SendMessage("This is a test of the command system. " +
                    "If this was an actual command you would see an actual response Kappa");
            }
        }



    }
}
