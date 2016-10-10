using System;

namespace GreaterofTwoValues
{
    public class GreaterofTwoValues
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char first = Console.ReadLine()[0];
                char second = Console.ReadLine()[0];
                char max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }

        private static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            return second;
        }
        private static char GetMax(char first, char second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            return second;
        }
        private static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            return second;
        }
    }
}