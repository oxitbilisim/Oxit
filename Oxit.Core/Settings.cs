using Newtonsoft.Json;

namespace Oxit.Core
{

    public static class Settings
    {
        public static bool IsDevelopment { get { return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development"; } }
        public static string EnvName { get { return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").ToString(); } }
        private static readonly dynamic settingsJson = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Settings." + EnvName + ".json"));

        public class Database
        {
            public static string Type = settingsJson.Database.Type;
            public static string ConnectionString = settingsJson.Database.ConnectionString;
        }
        public class Cache
        {
            public static bool Enable = bool.Parse(Convert.ToString(settingsJson.Cache.Enable));
            public static string Type = settingsJson.Cache.Type;
            public static string ConnectionString = settingsJson.Cache.ConnectionString;
        }

        public class Log
        {
            public static bool Enable = bool.Parse(Convert.ToString(settingsJson.Log.Enable));
            public static string Destination = settingsJson.Log.Destination;
            public static string Level = settingsJson.Log.Level;
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
        public class JWT
        {
            public static string ValidAudience = settingsJson.JWT.ValidAudience;
            public static string ValidIssuer = settingsJson.JWT.ValidIssuer;
            public static string Secret = settingsJson.JWT.Secret;
        }

        public static string TeknoparkConnectionstring = settingsJson.TeknoparkConnectionstring;
    }
}
