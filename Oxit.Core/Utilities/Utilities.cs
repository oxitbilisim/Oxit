//using ExcelDataReader;
using System.ComponentModel.DataAnnotations;

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
        //public static List<T> ExcelToObject<T>(this Stream stream)
        //{
        //    using (var reader = ExcelReaderFactory.CreateReader(stream))
        //    {
        //        do
        //        {
        //            while (reader.Read())
        //            {

        //            }
        //        } while (reader.NextResult());
        //        var result = reader.AsDataSet();
        //        var table = result.Tables[0]
        //            .AsEnumerable()
        //            .ToList();

        //        List<T> templist = new List<T>();
        //        var props = typeof(T).GetProperties();

        //        for (int i = 1; i < table.Count; i++)
        //        {
        //            var ins = Activator.CreateInstance(typeof(T));
        //            for (int j = 0; j < props.Count(); j++)
        //            {
        //                props[j].SetValue(ins, table[i].ItemArray[j].ToString());
        //            }
        //            templist.Add((T)ins);
        //        }
        //        return templist;
        //    }
        //}
    }
}
