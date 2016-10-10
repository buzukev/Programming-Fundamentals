using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> result = new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] inputString = input.Split(' ');
                string ip = inputString[0].Substring(3);
                string name = inputString[2].Substring(5);

                if (!result.ContainsKey(name))
                {
                    result[name] = new Dictionary<string, int>();
                    result[name].Add(ip, 1);
                }

                else
                {
                    if (result[name].ContainsKey(ip))
                    {
                        result[name][ip]++;
                    }
                    else
                    {
                        result[name].Add(ip, 1);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var user in result.Keys)
            {
                Console.WriteLine($"{user}: ");

                string ipString = "";

                foreach (var ip in result[user].OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value).Keys)
                {
                    ipString += $"{ip} => {result[user][ip]}, ";
                }
                ipString = ipString.Substring(0, ipString.Length - 2);
                ipString += ".";
                Console.WriteLine(ipString);
            }
        }
    }
}