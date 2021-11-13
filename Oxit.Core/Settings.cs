using Oxit.Core.Utilities;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace Oxit.Core
{

    public static class Settings
    {
        public static bool IsDevelopment { get { return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development"; } }
        private static readonly dynamic settingsJson = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Settings" + (IsDevelopment ? ".Development" : "") + ".json"));

        public class Database
        {
            public static string Type = settingsJson.Database.Type;
            public static string ConnectionString = settingsJson.Database.ConnectionString;
        }
        public class Cache
        {
            public static bool Enable = bool.Parse(Convert.ToString(settingsJson.Cache.Enable));
            public static string Type = settingsJson.Cache.Type;

        }
        public class Redis
        {
            public static bool Enable = bool.Parse(Convert.ToString(settingsJson.Redis.Enable));
            public static string Host = settingsJson.Redis.Host;
            public static string Port = settingsJson.Redis.Port;
        }

        public class Log
        {
            public static bool Enable = bool.Parse(Convert.ToString(settingsJson.Log.Enable));
            public static string Destination = settingsJson.Log.Destination;
            public static string MongoDbConnectionString = settingsJson.Log.MongoDbConnectionString;
        }
        public class Password
        {
            public static string HashKey = settingsJson.Password.HashKey;

        }
        public class Mail
        {
            public static string Server = settingsJson.Mail.Server;
            public static string Username = settingsJson.Mail.Username;
            public static string Password = settingsJson.Mail.Password;


        }
    }
}
