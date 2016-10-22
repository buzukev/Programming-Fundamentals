using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationAggregation
{
    public class PopulationAggregation
    {
        public static void Main()
        {
            SortedDictionary<string, int> cityByCountry = new SortedDictionary<string, int>();
            Dictionary<string, long> populationByCity = new Dictionary<string, long>();

            string input = Console.ReadLine();

            while (!input.Equals("stop"))
            {
                string[] info = input.Split('\\');
                string city = string.Empty;
                string coutry = string.Empty;
                long population = long.Parse(info[2]);

                for (int i = 0; i < info.Length-1; i++)
                {
                    info[i] = string.Join("", info[i].Split(
                new[] { '@', '#', '$', '&', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' },
                    StringSplitOptions.RemoveEmptyEntries));
                }

                if (info[0].StartsWith(info[0].ToLower()))
                {
                    city = info[0];
                    coutry = info[1];
                }
                else
                {
                    coutry = info[0];
                    city = info[1];
                }

                if (!cityByCountry.ContainsKey(coutry))
                {
                    cityByCountry.Add(coutry, 0);
                }
                cityByCountry[coutry]++;

                if (!populationByCity.ContainsKey(city))
                {
                    populationByCity.Add(city, 0);
                }
                populationByCity[city] = population;

                input = Console.ReadLine();
            }

            foreach (var country in cityByCountry)
            {
                Console.WriteLine($"{country.Key} -> {country.Value}");
            }

            foreach (var population in populationByCity.OrderByDescending(p => p.Value).Take(3))
            {
                Console.WriteLine($"{population.Key} -> {population.Value}");
            }
        }
    }
}