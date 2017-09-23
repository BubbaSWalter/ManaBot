using System;
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
        public static void PrebuiltCommands(string Command, bool args, List<string> Arguments,
            string Username, string DisplayName,
            string UserType)
        {
            
            Command = Command.ToLower();
            //Console.WriteLine(Command + " " +ManaBot.CheckCommand);
            //Console.WriteLine("Command Prams: " + Command + " " + ChatMessage + " " + DisplayName + " " + Username + " " + UserType);
            if (Command.ToLower() == "test")
            {
                MainForm.BotClient.SendMessage("This is a test of the command system. " +
                    "If this was an actual command you would see an actual response Kappa");
            }
            else if (Command == MainForm.CheckCommand.ToLower())
            {
                if(Arguments.Count == 3)
                {
                    // !mana add Username AMT
                    int AMT = 0;
                    bool isNumber = int.TryParse(Arguments[2], out AMT);
                    if (isNumber == false)
                    {
                        Console.WriteLine("Paramter 3 Not a Number");
                        return;
                    }

                    Console.WriteLine("PAramter 1 =" + Arguments[0]);
                    Console.WriteLine("PAramter 2 =" + Arguments[1]);
                    Console.WriteLine("PAramter 3 =" + AMT);
                }
                else if (Arguments.Count == 1)
                {
                    //Console.WriteLine("Check Command Hype");
                    var ws = new WebSocket("ws://" + MainForm.DeepbotIp + ":3337");

                    ws.OnOpen += (ss, ee) =>
                    {
                        ws.Send("api|register|" + MainForm.DeepbotApi);
                        ws.Send("api|get_user|" + Arguments[0].ToLower());
                    };

                    ws.OnMessage += (ss, ee) =>
                    {
                        string Response = Convert.ToString(ee.Data);
                        if (Response.Contains("get_user"))
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
                            double hrs = Convert.ToDouble(hours) / 60;
                            hours = hrs.ToString("N1");
                            hrs = Math.Floor(hrs);
                            //Console.WriteLine("UserName: " + uname);
                            //Console.WriteLine("Points: " + points);
                            //Console.WriteLine("Hours: " + hours);
                            //Console.WriteLine("vip: " + vip);
                            //Console.WriteLine("mod: " + mod); //mod 0 = viewer, mod1 = Nomral, Mod2 = editor, mod3 = ??, mod 4 = Deepbot , mod 5 Streamer

                            string placeholder = MainForm.CheckCommandRep;
                            string title = "";

                            switch (vip)
                            {
                                case "1":
                                    title = MainForm.Sub1 + " and ";
                                    break;
                                case "2":
                                    title = MainForm.Sub2 + " and ";
                                    break;
                                case "3":
                                    title = MainForm.Sub3 + " and ";
                                    break;

                            }

                            switch (mod)
                            {
                                case "1":
                                    title += MainForm.Mod1;
                                    break;
                                case "2":
                                    title += MainForm.Mod2;
                                    break;
                                case "3":
                                    title += MainForm.Mod2;
                                    break;
                                case "4":
                                    title += MainForm.Mod2;
                                    break;
                                case "5":
                                    title += MainForm.Mod2;
                                    break;
                                default:
                                    title = MainForm.NormalViewer;
                                    break;


                            }

                            string rankname = "";
                            string ranknum = "";
                            string rankhours = "";

                            var ranks = File.ReadAllLines(MainForm.FilesDir + "spelllist.csv");
                            int maxrank = ranks.Count();
                            bool exitcheck = false;
                            int count = 0;
                            ranknum = ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[0];
                            rankname = ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[1];
                            rankhours = ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[2];
                            while (exitcheck == false)
                            {
                                if (hrs > Convert.ToDouble(ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[2]))
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
                                if (count == maxrank) exitcheck = true;
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
                            MainForm.BotClient.SendMessage(placeholder);

                        }

                    };
                    ws.Connect();
                }
                else
                {
                    //Console.WriteLine("Check Command Hype");
                    var ws = new WebSocket("ws://" + MainForm.DeepbotIp + ":3337");

                    ws.OnOpen += (ss, ee) =>
                    {
                        ws.Send("api|register|" + MainForm.DeepbotApi);
                        ws.Send("api|get_user|" + Username);
                    };

                    ws.OnMessage += (ss, ee) =>
                    {
                        string Response = Convert.ToString(ee.Data);
                        if (Response.Contains("get_user"))
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
                            double hrs = Convert.ToDouble(hours) / 60;
                            hours = hrs.ToString("N1");
                            hrs = Math.Floor(hrs);
                            //Console.WriteLine("UserName: " + uname);
                            //Console.WriteLine("Points: " + points);
                            //Console.WriteLine("Hours: " + hours);
                            //Console.WriteLine("vip: " + vip);
                            //Console.WriteLine("mod: " + mod); //mod 0 = viewer, mod1 = Nomral, Mod2 = editor, mod3 = ??, mod 4 = Deepbot , mod 5 Streamer

                            string placeholder = MainForm.CheckCommandRep;
                            string title = "";

                            switch (vip)
                            {
                                case "1":
                                    title = MainForm.Sub1 + " and ";
                                    break;
                                case "2":
                                    title = MainForm.Sub2 + " and ";
                                    break;
                                case "3":
                                    title = MainForm.Sub3 + " and ";
                                    break;

                            }

                            switch (mod)
                            {
                                case "1":
                                    title += MainForm.Mod1;
                                    break;
                                case "2":
                                    title += MainForm.Mod2;
                                    break;
                                case "3":
                                    title += MainForm.Mod2;
                                    break;
                                case "4":
                                    title += MainForm.Mod2;
                                    break;
                                case "5":
                                    title += MainForm.Mod2;
                                    break;
                                default:
                                    title = MainForm.NormalViewer;
                                    break;


                            }

                            string rankname = "";
                            string ranknum = "";
                            string rankhours = "";

                            var ranks = File.ReadAllLines(MainForm.FilesDir + "spelllist.csv");
                            int maxrank = ranks.Count();
                            bool exitcheck = false;
                            int count = 0;
                            ranknum = ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[0];
                            rankname = ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[1];
                            rankhours = ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[2];
                            while (exitcheck == false)
                            {
                                if (hrs > Convert.ToDouble(ranks[count].Split(new[] { ",", "," }, StringSplitOptions.None)[2]))
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
                                if (count == maxrank) exitcheck = true;
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
                            MainForm.BotClient.SendMessage(placeholder);

                        }

                    };
                    ws.Connect();
                }

            }
                    

                
        }
    }
}
