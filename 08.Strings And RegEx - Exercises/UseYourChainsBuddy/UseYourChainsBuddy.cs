using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            string pattern = @"(<p>(.*?)<\/p>)";

            Regex regexp = new Regex(pattern);
            MatchCollection matches = regexp.Matches(text);

            string extract = string.Empty;

            foreach (Match match in matches)
            {
                extract += match.Groups[2].ToString();
            }

            string replPattern = @"([^a-z0-9])";

            Regex regex = new Regex(replPattern);
            extract = Regex.Replace(extract, replPattern, " ");
            extract = Regex.Replace(extract, @"\s+|\n+", " ");

            StringBuilder sb = new StringBuilder(extract.Length);

            foreach (char ch in extract)
            {
                if (ch >= 'a' && ch <= 'm')
                {
                    sb.Append((char)(ch + 13));
                }
                else if (ch >= 'n' && ch <= 'z')
                {
                    sb.Append((char)(ch - 13));
                }
                else
                {
                    sb.Append(ch);
                }
            }
            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}