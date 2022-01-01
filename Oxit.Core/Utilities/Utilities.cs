//using ExcelDataReader;
using ExcelDataReader;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text.RegularExpressions;

namespace Oxit.Core.Utilities
{
    public static class Utilities
    {
        public static string GetInner(this Exception exception)
        {
            if (exception == null)
                return "";
            if (exception.InnerException != null)
                return GetInner(exception.InnerException);
            else
                return exception.Message;
        }
        public static string GetInnerCode(this Exception exception)
        {
            if (exception == null)
                return "";
            if (exception.InnerException != null)
                return GetInner(exception.InnerException);
            else
                return exception.Message;
        }
        public static bool IsBetween(this DateTime date, DateTime start, DateTime end) => date >= start && date <= end;
        public static string[] StrinSeperator(this string str, char ch)

         => str.Split(ch);
        public static string FirstLetterUpper(this string txt) => !string.IsNullOrEmpty(txt) ? txt.ToUpper().First() + txt.Substring(1).ToLower() : string.Empty;
        public static string StringListToString(this IEnumerable<string> collection)
        {
            string res = string.Empty;
            foreach (var item in collection)
            {
                res += $"{item},";
            }
            return res.Substring(0, res.Length - 1);
        }
        public static string GetEnumDisplayName(this Enum enumType)
        {
            return enumType.GetType().GetMember(enumType.ToString())
                           .First()
                           .GetCustomAttribute<DisplayAttribute>()
                           .Name;
        }
        public static string GetPascalCase(string text)
        {
            var r = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z]) |
                                (?<=[^A-Z])(?=[A-Z]) |
                                (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);
            text = r.Replace(text, "_");
            return text;
        }
        public static List<T> ExcelToObject<T>(this Stream stream)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                do
                {
                    while (reader.Read())
                    {

                    }
                } while (reader.NextResult());
                var result = reader.AsDataSet();
                var table = result.Tables[0]
                    .AsEnumerable()
                    .ToList();

                List<T> templist = new List<T>();
                var props = typeof(T).GetProperties();

                for (int i = 1; i < table.Count; i++)
                {
                    var ins = Activator.CreateInstance(typeof(T));
                    for (int j = 0; j < props.Count(); j++)
                    {
                        var itemType = typeof(T).GetProperties()[j].PropertyType;
                        Type? propertyType = null;
                        propertyType = Nullable.GetUnderlyingType(itemType) != null ? Nullable.GetUnderlyingType(itemType) : itemType;
                        var parseMethod = propertyType.GetMethod("Parse", new[] { typeof(string) });
                        object? propertyValuse = null;
                        propertyValuse = parseMethod != null ?
                            propertyValuse = parseMethod.Invoke(propertyType, new[] { table[i].ItemArray[j].ToString() }) :
                            table[i].ItemArray[j].ToString();
                        props[j].SetValue(ins, propertyValuse);
                    }
                    templist.Add((T)ins);
                }
                return templist;
            }
        }
    }
}
