using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
{
    public class ArrayModifier
    {
        public static void Main()
        {
            List<long> list =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToList();

            string command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                string[] commandArgs = command.Split();

                switch (commandArgs[0])
                {
                    case "swap":
                        list = GetSwap(list, commandArgs);
                        break;

                    case "multiply":
                        list = GetMultiply(list, commandArgs);
                        break;

                    case "decrease":
                        list = GetDecrease(list, commandArgs);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", list));
        }

        private static List<long> GetDecrease(List<long> list, string[] commandArgs)
        {
            List<long> temp = new List<long>();

            for (int i = 0; i < list.Count; i++)
            {
                temp.Add(list[i] - 1);
            }
            return temp;
        }

        private static List<long> GetMultiply(List<long> list, string[] commandArgs)
        {
            int firstIndex = int.Parse(commandArgs[1]);
            int secondIndex = int.Parse(commandArgs[2]);

            list[firstIndex] *= list[secondIndex];
            return list;
        }

        private static List<long> GetSwap(List<long> list, string[] commandArgs)
        {
            int firstIndex = int.Parse(commandArgs[1]);
            int secondIndex = int.Parse(commandArgs[2]);
            long temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
            return list;
        }
    }
}