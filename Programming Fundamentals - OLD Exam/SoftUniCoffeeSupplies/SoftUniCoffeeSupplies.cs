using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoffeeSupplies
{
    public class SoftUniCoffeeSupplies
    {
        public static void Main()
        {
            string[] delimiters = Console.ReadLine().Split(' ');
            string firstDelimiter = delimiters[0];
            string secondDelimiter = delimiters[1];

            Dictionary<string, string> coffeTypeByPersons = new Dictionary<string, string>();
            Dictionary<string, int> coffeTypeByQuantity = new Dictionary<string, int>();

            ReadInformations(firstDelimiter, secondDelimiter, coffeTypeByPersons, coffeTypeByQuantity);
            CheckHowMuchCoffeHave(coffeTypeByPersons, coffeTypeByQuantity);
            PrintingReports(coffeTypeByPersons, coffeTypeByQuantity);
        }

        private static void PrintingReports(Dictionary<string, string> coffeTypeByPersons, Dictionary<string, int> coffeTypeByQuantity)
        {
            Console.WriteLine("Coffee Left:");

            var filteredCoffeTypes =
                coffeTypeByQuantity.Where(coffeType => coffeType.Value > 0)
                    .ToDictionary(coffeType => coffeType.Key, coffeType => coffeType.Value);

            foreach (var filteredCoffeType in filteredCoffeTypes.OrderByDescending(coffeType => coffeType.Value))
            {
                Console.WriteLine($"{filteredCoffeType.Key} {filteredCoffeType.Value}");
            }

            Console.WriteLine("For:");

            var coffeLeftForPerson = coffeTypeByPersons.Where(person => filteredCoffeTypes.ContainsKey(person.Value));

            foreach (var coffeType in coffeLeftForPerson.OrderBy(person => person.Value).ThenByDescending(person => person.Key))
            {
                Console.WriteLine($"{coffeType.Key} {coffeType.Value}");
            }
        }

        private static void CheckHowMuchCoffeHave(Dictionary<string, string> coffeTypeByPersons, Dictionary<string, int> coffeTypeByQuantity)
        {
            foreach (var coffeType in coffeTypeByQuantity)
            {
                if (coffeType.Value <= 0)
                {
                    Console.WriteLine($"Out of {coffeType.Key}");
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("end of week"))
                {
                    break;
                }

                string[] commandArr = command.Split(' ');
                string personName = commandArr[0];
                int quantity = int.Parse(commandArr[1]);

                string coffeType = coffeTypeByPersons[personName];
                coffeTypeByQuantity[coffeType] -= quantity;

                if (coffeTypeByQuantity[coffeType] <= 0)
                {
                    Console.WriteLine($"Out of {coffeType}");
                }
            }
        }

        private static void ReadInformations(string firstDelimiter, string secondDelimiter, Dictionary<string, string> coffeTypeByPersons, Dictionary<string, int> coffeTypeByQuantity)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("end of info"))
                {
                    break;
                }

                if (command.Contains(firstDelimiter))
                {
                    int indexOfDelimeter = command.IndexOf(firstDelimiter);
                    string personName = command.Substring(0, indexOfDelimeter);
                    string coffeType = command.Substring(indexOfDelimeter + firstDelimiter.Length);

                    if (coffeTypeByPersons.ContainsKey(personName))
                    {
                        coffeTypeByPersons[personName] = coffeType;
                    }
                    else
                    {
                        coffeTypeByPersons.Add(personName, coffeType);
                    }

                    if (!coffeTypeByQuantity.ContainsKey(coffeType))
                    {
                        coffeTypeByQuantity.Add(coffeType, 0);
                    }
                }
                else
                {
                    int indexOfDelimeter = command.IndexOf(secondDelimiter);
                    string coffeName = command.Substring(0, indexOfDelimeter);
                    int quantity = int.Parse(command.Substring(indexOfDelimeter + secondDelimiter.Length));

                    if (coffeTypeByQuantity.ContainsKey(coffeName))
                    {
                        coffeTypeByQuantity[coffeName] += quantity;
                    }
                    else
                    {
                        coffeTypeByQuantity.Add(coffeName, quantity);
                    }
                }
            }
        }
    }
}