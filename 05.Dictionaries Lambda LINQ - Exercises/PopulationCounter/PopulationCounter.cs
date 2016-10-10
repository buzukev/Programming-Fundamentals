using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> populations = new Dictionary<string, Dictionary<string, long>>();

            string city = "";
            string country = "";
            long population = 0;

            List<string> input = Console.ReadLine().Split('|').ToList();

            while (!input.Equals("report"))
            {
                city = input[0];
                if (city == "report")
                {
                    break;
                }
                country = input[1];
                population = long.Parse(input[2]);
                Dictionary<string, long> cityPopulation = new Dictionary<string, long>();

                if (!populations.ContainsKey(country))
                {
                    cityPopulation[city] = population;
                    populations[country] = cityPopulation;
                }

                else
                {
                    cityPopulation = populations[country];

                    if (cityPopulation.ContainsKey(city))
                    {
                        cityPopulation[city] += population;
                    }
                    else
                    {
                        cityPopulation.Add(city, population);
                    }
                }

                input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var town in populations.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumOfTowns = town.Value.Select(x => x.Value).ToList();

                Console.WriteLine($"{town.Key} (total population: {sumOfTowns.Sum()})");
                Console.Write($"=>{string.Join("=>", town.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class Population_Counter
//{
//    static void Main()
//    {
//        Dictionary<string, Dictionary<string, long>> populations = new Dictionary<string, Dictionary<string, long>>();

//        string city = "";
//        string country = "";
//        long population = 0;
//        while (true)
//        {
//            List<string> data = Console.ReadLine().Split('|').ToList();
//            city = data[0];
//            if (city == "report") break;
//            country = data[1];
//            population = long.Parse(data[2]);
//            Dictionary<string, long> cityPopulation = new Dictionary<string, long>();
//            cityPopulation[city] = population;
//            if (!populations.ContainsKey(country))
//            {
//                populations[country] = cityPopulation;
//            }
//            else
//            {
//                populations[country].Add(city, population);
//            }
//        }

//        foreach (var state in populations.OrderByDescending(x => x.Key))
//        {
//            List<long> sumOfTowns = state.Value.Select(x => x.Value).ToList();
//            Console.WriteLine($"{state.Key} (total population: {sumOfTowns.Sum()})");
//            Console.Write($"=>{string.Join("=>", state.Value.Select(x => $"{x.Key}: {x.Value}\r\n").OrderByDescending(x => x))}");
//        }
//    }
//}