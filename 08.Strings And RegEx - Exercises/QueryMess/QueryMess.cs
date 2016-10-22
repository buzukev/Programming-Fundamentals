using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace QueryMess
{
    public class QueryMess
    {
        public static void Main()
        {

            string text = Console.ReadLine();

            string pattern = @"([^&=?]*)=\s*([^&=]*)";

            while (!text.Equals("END"))
            {
                string replace = @"(%20|\+)+";

                text = Regex.Replace(text, replace, " ");

                Regex regex = new Regex(pattern);

                MatchCollection matches = regex.Matches(text);

                Dictionary<string, List<string>> values = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {
                    string valuesKey = match.Groups[1].ToString().Trim();
                    string valuesValue = match.Groups[2].ToString().Trim();

                    if (!values.ContainsKey(valuesKey))
                    {
                        values.Add(valuesKey, new List<string>());
                    }
                    values[valuesKey].Add(valuesValue);
                }

                foreach (var val in values)
                {
                    Console.Write("{0}=[{1}]", val.Key, string.Join(", ", val.Value));
                }

                Console.WriteLine();
                text = Console.ReadLine();
            }
        }
    }
}