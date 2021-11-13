using System.IO;
using System.Net;
using System.Xml;

namespace Oxit.Core.Utilities
{
    public class Soap
    {
        public string CreateSaopRequest(string adres, string xml) => CreateSaopRequest(adres, string.Empty, xml);
        public string CreateSaopRequest(string adres, string action, string xml)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(adres);
            request.Headers.Add($"SOAPAction:\"{action}\"");
            request.ContentType = "text/xml;charset=\"utf-8\"";
            request.Accept = "text/xml";
            request.Method = "POST";
            XmlDocument SOAPReqBody = new XmlDocument();
            SOAPReqBody.LoadXml(xml);
            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }

            using (WebResponse Serviceres = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                {
                    var ServiceResult = rd.ReadToEnd();
                    return ServiceResult;
                }
            }
        }
    }
}
