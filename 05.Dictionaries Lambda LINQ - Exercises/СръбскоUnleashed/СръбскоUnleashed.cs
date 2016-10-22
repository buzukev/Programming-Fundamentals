using System;
using System.Collections.Generic;
using System.Linq;

class СръбскоUnleashed
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> concerts = new Dictionary<string, Dictionary<string, int>>();

        string input = Console.ReadLine();

        while (!input.Equals("End"))
        {
            string[] info = input.Split('@').ToArray();
            string singer = info[0];
            string[] tourCity = info[1].Split(' ');

            string city = string.Empty;
            int ticketPrice = 0;
            int soldTickets = 0;

            if (singer[singer.Length - 1] == ' ' && tourCity.Length >= 3
                          && int.TryParse(tourCity[tourCity.Length - 1], out soldTickets)
                          && int.TryParse(tourCity[tourCity.Length - 2], out ticketPrice))
            {
                soldTickets = int.Parse(tourCity[tourCity.Length - 1]);
                ticketPrice = int.Parse(tourCity[tourCity.Length - 2]);

                for (int i = 0; i < tourCity.Length - 2; i++)
                {
                    city += tourCity[i] + " ";
                }
            }
            else
            {
                input = Console.ReadLine();
                continue;
            }

            if (!concerts.ContainsKey(city))
            {
                concerts.Add(city, new Dictionary<string, int>());
            }

            if (!concerts[city].ContainsKey(singer))
            {
                concerts[city].Add(singer, 0);
            }

            concerts[city][singer] += ticketPrice * soldTickets;

            input = Console.ReadLine();
        }

        foreach (var concert in concerts)
        {
            Console.Write($"{concert.Key}\r\n");
            Console.Write($"#  {string.Join("#  ", concert.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}-> {x.Value}\r\n"))}");
        }
    }
}