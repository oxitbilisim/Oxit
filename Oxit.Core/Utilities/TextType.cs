using System.Text.RegularExpressions;

namespace Oxit.Core.Utilities
{
    public class TextType
    {
        public static string GetPascalCase(string text)
        {
            var r = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z]) |
                                (?<=[^A-Z])(?=[A-Z]) |
                                (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);
            text = r.Replace(text, "_");
            return text;
        }
    }
}
