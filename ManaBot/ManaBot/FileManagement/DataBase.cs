using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace ManaBot.FileManagement
{
    class DataBase
    {
        public static SQLiteConnection dbSet;
        public static SQLiteConnection dbCom;
        private static List<string> sql = new List<string>();
        public static void CreateSettings()
        {
            
            //Create the Database File
            SQLiteConnection.CreateFile(MainForm.DataDir + "Settings.sqlite");

            
            //Connect to Database
            dbSet = new SQLiteConnection("Data Source=" + MainForm.DataDir + "Settings.sqlite;Version=3;");
            dbSet.Open();

            //Create the Table
            //Twitch Settings
            sql.Add("CREATE TABLE IF NOT EXISTS `TwitchConnection` ('KeyName'	varchar(20), 'KeyValue'	varchar(20))");
            sql.Add("INSERT INTO `TwitchConnection` (KeyName,KeyValue) VALUES ('StreamName','StreamerName')");
            sql.Add("INSERT INTO `TwitchConnection` (KeyName,KeyValue) VALUES ('StreamOauth','StreamerName')");
            sql.Add("INSERT INTO `TwitchConnection` (KeyName,KeyValue) VALUES ('Channel','Channel') ");
            sql.Add("INSERT INTO `TwitchConnection` (KeyName,KeyValue) VALUES ('BotName','BotName') ");
            sql.Add("INSERT INTO `TwitchConnection` (KeyName,KeyValue) VALUES ('BotOauth','BotOauth') ");
            //Twitch API
            sql.Add("CREATE TABLE IF NOT EXISTS `TwitchAPI` (KeyName	varchar(20), KeyValue	varchar(20))");
            sql.Add("INSERT INTO `TwitchAPI` (KeyName,KeyValue) VALUES ('ClientID','')");
            sql.Add("INSERT INTO `TwitchAPI` (KeyName,KeyValue) VALUES ('TwitchApiAuthKey','')");
            //Misc Settings
            sql.Add("CREATE TABLE IF NOT EXISTS `MiscSettings` (KeyName	varchar(20), KeyValue	varchar(20))");
            sql.Add("INSERT INTO `MiscSettings` (KeyName,KEyValue) VALUES ('CommandChar','!')");
            //Gamble Settings
            sql.Add("CREATE TABLE IF NOT EXISTS `GambleSettings` (KeyName	varchar(20), KeyValue	varchar(20))");
            //DeepbotAPI
            sql.Add("CREATE TABLE IF NOT EXISTS `DeepbotSettings` (KeyName	varchar(20), KeyValue	varchar(20))");
            sql.Add("INSERT INTO `DeepbotSettings` (KeyName,KeyValue) VALUES ('DeepBotApiKey','')");
            sql.Add("INSERT INTO `DeepbotSettings` (KeyName,KeyValue) VALUES ('DeepBotApiIp','')");
            //CurrencySettings
            sql.Add("CREATE TABLE IF NOT EXISTS `CurrencyCheck` (KeyName	varchar(20), KeyValue	varchar(50))");
            sql.Add("INSERT INTO `CurrencyCheck` (KeyName,KeyValue) VALUES ('Mod1','')");
            sql.Add("INSERT INTO `CurrencyCheck` (KeyName,KeyValue) VALUES ('Mod2','')");
            sql.Add("INSERT INTO `CurrencyCheck` (KeyName,KeyValue) VALUES ('Sub2','')");
            sql.Add("INSERT INTO `CurrencyCheck` (KeyName,KeyValue) VALUES ('Sub3','')");
            sql.Add("INSERT INTO `CurrencyCheck` (KeyName,KeyValue) VALUES ('NormalViewer','')");
            sql.Add("INSERT INTO `CurrencyCheck` (KeyName,KeyValue) VALUES ('CurrecyCheckCmd','mana')");
            sql.Add("INSERT INTO `CurrencyCheck` (KeyName,KeyValue) VALUES ('CurrencyRespone','')");
            sql.Add("INSERT INTO `CurrencyCheck` (KeyName,KeyValue) VALUES ('CurrencyName','mana')");
            foreach (string querycode in sql)
            {
                SQLiteCommand Command = new SQLiteCommand(querycode, dbSet);
                Command.ExecuteNonQuery();
            }
            dbSet.Close();


        }

        public static void DbOpenSet()
        {
            dbSet = new SQLiteConnection("Data Source=" + MainForm.DataDir + "Settings.sqlite;Version=3;");
            if(dbSet.State != ConnectionState.Open)
            {
                try
                {
                    dbSet.Close();
                }
                catch { }
                dbSet.Open();

            }

        }

        public static void DbCloseSet()
        {
            dbSet = new SQLiteConnection("Data Source=" + MainForm.DataDir + "Settings.sqlite;Version=3;");
            if (dbSet.State != ConnectionState.Closed) 
            {
                dbSet.Close();
            }

        }

        public static void UpdateSettings()
        {
            UpdateConnection();
            UpdateCurrencyCommandSettings();
            UpdateDeepbot();
        }
        private static void UpdateConnection()
        {
            DbOpenSet();
            string sql = "";
            SQLiteCommand Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            string response = "";
            //Set StreamerName
            sql = "select KeyValue from `TwitchConnection` where `KeyName` = 'StreamName'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.StreamerName = response;

            //Set StreamerOauth
            sql = "select KeyValue from `TwitchConnection` where `KeyName` = 'StreamOauth'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.StreamerOAuth = response;

            //Set the ChannelName
            sql = "select KeyValue from `TwitchConnection` where `KeyName` = 'Channel'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.Channel = response;

            //Set the Botname
            sql = "select KeyValue from `TwitchConnection` where `KeyName` = 'BotName'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.BotName = response;

            //Set the Botname
            sql = "select KeyValue from `TwitchConnection` where `KeyName` = 'BotOauth'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.BotOauth = response;
            DbCloseSet();
        }

        private static void UpdateCurrencyCommandSettings()
        {
            DbOpenSet();
            string sql = "";
            SQLiteCommand Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            string response = "";
            //Set Mod1
            sql = "select KeyValue from `CurrencyCheck` where `KeyName` = 'Mod1'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.Mod1 = response;

            //Set Mod2
            sql = "select KeyValue from `CurrencyCheck` where `KeyName` = 'Mod2'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.Mod2 = response;

            //Set Sub1
            sql = "select KeyValue from `CurrencyCheck` where `KeyName` = 'Sub1'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.Sub1 = response;

            //Set Sub2
            sql = "select KeyValue from `CurrencyCheck` where `KeyName` = 'Sub2'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.Sub2 = response;

            //Set Sub3
            sql = "select KeyValue from `CurrencyCheck` where `KeyName` = 'Mod1'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.Mod1 = response;

            //Set NormalViewer
            sql = "select KeyValue from `CurrencyCheck` where `KeyName` = 'NormalViewer'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.NormalViewer = response;

            //Set CurrencyCheck
            sql = "select KeyValue from `CurrencyCheck` where `KeyName` = 'CurrecyCheckCmd'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.CheckCommand = response;

            //Set CurrencyRespone
            sql = "select KeyValue from `CurrencyCheck` where `KeyName` = 'CurrencyRespone'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.CheckCommandRep = response;

            //Set CurrencyName
            sql = "select KeyValue from `CurrencyCheck` where `KeyName` = 'CurrencyName'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.CurrencyName = response;
            DbCloseSet();




        }

        private static void UpdateDeepbot()
        {
            DbOpenSet();
            string sql = "";
            SQLiteCommand Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            string response = "";
            //Set Mod1
            sql = "select KeyValue from `DeepbotSettings` where `KeyName` = 'DeepBotApiKey'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.DeepbotApi = response;

            //Set Mod2
            sql = "select KeyValue from `DeepbotSettings` where `KeyName` = 'DeepBotApiIp'";
            Command = new SQLiteCommand(sql, FileManagement.DataBase.dbSet);
            response = Command.ExecuteScalar().ToString();
            MainForm.DeepbotIp = response;
        }
    }
}
