﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace ManaBot.Twitch
{
    class TwitchCommands
    {
        public static void PrebuiltCommands(string Command, string ChatMessage,
            string Username, string DisplayName,
            string UserType)
        {
            
            Command = Command.ToLower();
            //Console.WriteLine(Command + " " +ManaBot.CheckCommand);
            //Console.WriteLine("Command Prams: " + Command + " " + ChatMessage + " " + DisplayName + " " + Username + " " + UserType);
            if (Command.ToLower() == "test")
            {
                TwitchConnect.BotClient.SendMessage("This is a test of the command system. " +
                    "If this was an actual command you would see an actual response Kappa");
            }
            else if (Command == ManaBot.CheckCommand.ToLower())
            {
                //Console.WriteLine("Check Command Hype");
                var ws = new WebSocket("ws://" + ManaBot.DeepbotIp + ":3337");

                ws.OnOpen += (ss, ee) =>
                {
                    ws.Send("api|register|" + ManaBot.DeepbotApi);
                    ws.Send("api|get_user|" + Username);
                };

                ws.OnMessage += (ss, ee) =>
                {
                    string Response = Convert.ToString(ee.Data);
                    if(Response.Contains("get_user"))
                    {
                        //Console.WriteLine(Response);
                        string uname = "";
                        string points = "";
                        string hours = "";
                        string vip = "";
                        string mod = "";

                        /*{"function":"get_user","param":"wizardsrwe","msg":{"user":"wizardsrwe","points":91122.699999998818,
                         * "watch_time":50848.0,"vip":3,"mod":5,"join_date":"2016-12-23T15:23:30.6459005",
                         * "last_seen":"2017-09-16T18:59:11.2865199Z","vip_expiry":"2017-09-30T20:19:51"}}
                         */
                        uname = Response.Split(new[] { "\"", "\"" }, StringSplitOptions.None)[7];
                        points = Response.Split(new[] { ":", "," }, StringSplitOptions.None)[8];
                        hours = Response.Split(new[] { ":", "," }, StringSplitOptions.None)[10];
                        vip = Response.Split(new[] { ":", "," }, StringSplitOptions.None)[12];
                        mod = Response.Split(new[] { ":", "," }, StringSplitOptions.None)[14];


                        double pts = Math.Floor(Convert.ToDouble(points));
                        points = pts.ToString("N0");
                        double hrs = Convert.ToDouble(hours)/60;
                        hours = hrs.ToString("N1");
                        hrs = Math.Floor(hrs);
                        //Console.WriteLine("UserName: " + uname);
                        //Console.WriteLine("Points: " + points);
                        //Console.WriteLine("Hours: " + hours);
                        //Console.WriteLine("vip: " + vip);
                        //Console.WriteLine("mod: " + mod); //mod 0 = viewer, mod1 = Nomral, Mod2 = editor, mod3 = ??, mod 4 = Deepbot , mod 5 Streamer

                        string placeholder = ManaBot.CheckCommandRep;
                        string title = "" ;

                        switch(vip)
                        {
                            case "1":
                                title = ManaBot.Sub1 + " and ";
                                break;
                            case "2":
                                title = ManaBot.Sub2 + " and ";
                                break;
                            case "3":
                                title = ManaBot.Sub3 + " and ";
                                break;

                        }

                        switch (mod)
                        {
                            case "1":
                                title += ManaBot.Mod1;
                                break;
                            case "2":
                                title += ManaBot.Mod2;
                                break;
                            case "3":
                                title += ManaBot.Mod2;
                                break;
                            case "4":
                                title += ManaBot.Mod2;
                                break;
                            case "5":
                                title += ManaBot.Mod2;
                                break;
                            default:
                                title = ManaBot.NormalViewer;
                                break;


                        }

                        string rankname = "" ;
                        string ranknum = "" ;
                        string rankhours = "" ;

                        var ranks = File.ReadAllLines(ManaBot.FilesDir + "spelllist.csv");
                        int maxrank = ranks.Count();
                        bool exitcheck = false;
                        int count = 0;
                        ranknum = ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[0];
                        rankname = ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[1];
                        rankhours = ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[2];
                        while (exitcheck == false)
                        {
                            if(hrs > Convert.ToDouble(ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[2]))
                            {
                                ranknum = ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[0];
                                rankname = ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[1];
                                rankhours = ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[2];
                                
                            }
                            else
                            {
                                exitcheck = true;
                            }
                            count += 1;
                            if (count == maxrank ) exitcheck = true;
                            //Console.WriteLine("Rank Number: " + ranknum + " Rank Name: " + rankname + " Rank Hours: " + rankhours +
                            //    " count: " + count + " max Count: " + maxrank + "exitcheck: " + exitcheck);
                        }


                        


                        placeholder = placeholder.Replace("$user", uname);
                        placeholder = placeholder.Replace("$points", points);
                        placeholder = placeholder.Replace("$hours", hours);
                        placeholder = placeholder.Replace("$title", title);
                        placeholder = placeholder.Replace("$ranktitle", rankname);
                        placeholder = placeholder.Replace("$ranknum", ranknum);
                        placeholder = placeholder.Replace("$title", title);
                        TwitchConnect.BotClient.SendMessage(placeholder);

                    }

                };




                ws.Connect();
            }
                    

                
        }
    }
}
