using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Core
{
    public static class Helpers
    {
        public static string GetToken(this HttpContext http) =>
                http != null && http.Request != null && http.Request.Headers.Any(c => c.Key == "token") ?
                   http.Request.Headers.FirstOrDefault(c => c.Key == "token").Value :
                   string.Empty;

        public static string ToBase64(this Stream stream)
        {
            var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);
            return Convert.ToBase64String(memoryStream.ToArray());
        }

        public static string ToBase64(this byte[] stream)
        {
 
            return Convert.ToBase64String(stream);
        }
        public static byte[] ToByteArray(this Stream stream)
        {
            var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);
            return memoryStream.ToArray();
        }
    }
}
