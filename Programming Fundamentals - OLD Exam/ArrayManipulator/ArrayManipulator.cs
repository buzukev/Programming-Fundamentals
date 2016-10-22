using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main(string[] args)
        {
            List<int> list =
                Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                string[] commandArr = command.Split();

                switch (commandArr[0])
                {
                    case "exchange":
                        list = Exchange(commandArr, list);
                        break;

                    case "max":
                        GetMaxIndex(commandArr, list);
                        break;

                    case "min":
                        GetMixIndex(commandArr, list);
                        break;

                    case "first":
                        GetFirstElements(list, commandArr);
                        break;

                    case "last":
                        GetLastElements(list, commandArr);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", list)}]");
        }

        private static void GetLastElements(List<int> list, string[] commandArr)
        {
            int count = int.Parse(commandArr[1]);
            string type = commandArr[2];

            if (count > list.Count())
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> temp = new List<int>();

            switch (type)
            {
                case "even":
                    temp = list.Where(x => x % 2 == 0).Reverse().Take(count).Reverse().ToList();
                    break;
                case "odd":
                    temp = list.Where(x => x % 2 != 0).Reverse().Take(count).Reverse().ToList();
                    break;
            }
            Console.WriteLine($"[{string.Join(", ", temp)}]");
        }

        private static void GetFirstElements(List<int> list, string[] commandArr)
        {
            int count = int.Parse(commandArr[1]);
            string type = commandArr[2];

            if (count > list.Count())
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> temp = new List<int>();

            for (int i = 0; i < list.Count(); i++)
            {
                switch (type)
                {
                    case "even":
                        if (list[i] % 2 == 0 && temp.Count() < count)
                        {
                            temp.Add(list[i]);
                        }
                        break;
                    case "odd":
                        if (list[i] % 2 != 0 && temp.Count() < count)
                        {
                            temp.Add(list[i]);
                        }
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", temp)}]");
        }

        private static void GetMixIndex(string[] commandArr, List<int> list)
        {
            string type = commandArr[1];
            int minValue = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i] <= minValue)
                {
                    if (type == "even" && list[i] % 2 == 0)
                    {
                        minValue = list[i];
                        minIndex = i;
                    }
                    else if (type == "odd" && list[i] % 2 != 0)
                    {
                        minValue = list[i];
                        minIndex = i;
                    }
                }
            }
            if (minIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }

        private static void GetMaxIndex(string[] commandArr, List<int> list)
        {
            string type = commandArr[1];

            if (type == "even")
            {
                var filtered = list.Where(x => x % 2 == 0);

                if (filtered.Count() > 0)
                {
                    int max = filtered.Max();
                    int maxIndex = list.LastIndexOf(max);
                    Console.WriteLine(maxIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }

            else
            {
                var filtered = list.Where(x => x % 2 != 0);

                if (filtered.Count() > 0)
                {
                    int max = filtered.Max();
                    int maxIndex = list.LastIndexOf(max);
                    Console.WriteLine(maxIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static List<int> Exchange(string[] commandArr, List<int> list)
        {
            int index = int.Parse(commandArr[1]);

            if (index < 0 || list.Count <= index)
            {
                Console.WriteLine("Invalid index");
                return list;
            }
            List<int> temp = list.Skip(index + 1).ToList();
            temp.AddRange(list.Take(index + 1));
            return temp;
        }
    }
}