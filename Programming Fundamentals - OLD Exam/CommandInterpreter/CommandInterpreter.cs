using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandInterpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] command = Console.ReadLine().Split();

            List<string> list = new List<string>();

            int start = 0;
            int count = 0;

            while (!command[0].Equals("end"))
            {
                switch (command[0])
                {
                    case "reverse":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);

                        if (start < 0 || start >= input.Count || (start + count) > input.Count || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        list = input.Skip(start).Take(count).Reverse().ToList();
                        input.RemoveRange(start, count);
                        input.InsertRange(start, list);

                        break;

                    case "sort":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);

                        if (start < 0 || start >= input.Count || (start + count) > input.Count || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        list = input.Skip(start).Take(count).OrderBy(s => s).ToList();
                        input.RemoveRange(start, count);
                        input.InsertRange(start, list);

                        break;

                    case "rollLeft":
                        count = int.Parse(command[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < (count % input.Count); i++)
                        {
                            string element = input[0];
                            input.RemoveAt(0);
                            input.Add(element);
                        }

                        break;

                    case "rollRight":
                        count = int.Parse(command[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < (count % input.Count); i++)
                        {
                            string element = input[input.Count - 1];
                            input.RemoveAt(input.Count - 1);
                            input.Insert(0, element);
                        }

                        break;

                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}