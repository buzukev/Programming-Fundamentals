using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    class LogsAggregator
    {
        static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, int>> userLogs = new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entry = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string ip = entry[0];
                string userName = entry[1];
                int duration = int.Parse(entry[2]);

                InsertUserName(userLogs, userName);
                InsertIpAndDuration(userLogs, userName, ip, duration);
            }

            foreach (var userEntry in userLogs)
            {
                string userName = userEntry.Key;
                int totalDuration = userEntry.Value.Values.Sum();
                List<string> userIp = userEntry.Value.Keys.ToList();

                Console.WriteLine($"{userName}: {totalDuration} [{string.Join(", ", userIp)}]");
            }
        }

        private static void InsertIpAndDuration(SortedDictionary<string, SortedDictionary<string, int>> userLogs, string userName, string ip, int duration)
        {
            if (!userLogs[userName].ContainsKey(ip))
            {
                userLogs[userName].Add(ip, 0);
            }

            userLogs[userName][ip] += duration;
        }

        private static void InsertUserName(SortedDictionary<string, SortedDictionary<string, int>> userLogs, string userName)
        {
            if (!userLogs.ContainsKey(userName))
            {
                userLogs.Add(userName, new SortedDictionary<string, int>());
            }
        }
    }
}
