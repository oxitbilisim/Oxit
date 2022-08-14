//
// using Newtonsoft.Json;
//
// namespace Oxit.Core
// {
//
//     public static class Settings
//     {
//         public static bool IsDevelopment { get { return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development"; } }
//         public static string EnvName { get { return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").ToString(); } }
//         private static readonly dynamic settingsJson = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Settings." + EnvName + ".json"));
//
//         public class Database
//         {
//             public static string Type = settingsJson.Database.Type;
//             public static string ConnectionString = settingsJson.Database.ConnectionString;
//         }
//         public class Cache
//         {
//             public static bool Enable = bool.Parse(Convert.ToString(settingsJson.Cache.Enable));
//             public static string Type = settingsJson.Cache.Type;
//             public static string ConnectionString = settingsJson.Cache.ConnectionString;
//         }
//
//         public class Log
//         {
//             public static bool Enable = bool.Parse(Convert.ToString(settingsJson.Log.Enable));
//             public static string Destination = settingsJson.Log.Destination;
//             public static string Level = settingsJson.Log.Level;
//             public static string MongoDbConnectionString = settingsJson.Log.MongoDbConnectionString;
//         }
//         public class Password
//         {
//             public static string HashKey = settingsJson.Password.HashKey;
//
//         }
//         public class Mail
//         {
//             public static string Server = settingsJson.Mail.Server;
//             public static string Username = settingsJson.Mail.Username;
//             public static string Password = settingsJson.Mail.Password;
//         }
//         public class JWT
//         {
//             public static string ValidAudience = settingsJson.JWT.ValidAudience;
//             public static string ValidIssuer = settingsJson.JWT.ValidIssuer;
//             public static string Secret = settingsJson.JWT.Secret;
//         }
//
//         public static string TeknoparkConnectionstring = settingsJson.TeknoparkConnectionstring;
//     }
// }

 using Newtonsoft.Json;

 namespace Oxit.Core
 {
     
     
     public static class Settings
     {
         public static bool IsDevelopment { get { return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development"; } }
         //public static string EnvName { get { return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").ToString(); } }
         //private static readonly dynamic settingsJson = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Settings." + EnvName + ".json"));

         public class Database
         {
             public static string Type = "PostgreSql";
             public static string ConnectionString = "Host=192.168.0.98;Database=oxit;Username=postgres;Password=kmbuadam22";
             //public static string ConnectionString = "Host=185.122.203.197;Database=teknopark;Username=postgres;Password=oxit2016";
         }
         public class Cache
         {
             public static bool Enable = false;
             public static string Type = "Redis";
             public static string ConnectionString = "";
         }

         public class Log
         {
             public static bool Enable = false;
             public static string Destination = "";
             public static string Level = "";
             public static string MongoDbConnectionString = "";
         }
         public class Password
         {
             public static string HashKey = "";

         }
         public class Mail
         {
             public static string Server = "";
             public static string Username = "";
             public static string Password = "";
         }
         public class JWT
         {
             public static string ValidAudience = "http://localhost:4200";
             public static string ValidIssuer = "http://localhost:61955";
             public static string Secret = "ByYM000OLlMQG6VVVp1OH7Xzyr7gHuw1qvUC5dcGt3SNM";
         }

         public static string TeknoparkConnectionstring = "Server=WIN-HEN8F6S022B\\ZRV;Database=AANKARATEKNOPARKAŞ_2022;User Id=oxit;Password=oxit2022Ta;";
     }
}
