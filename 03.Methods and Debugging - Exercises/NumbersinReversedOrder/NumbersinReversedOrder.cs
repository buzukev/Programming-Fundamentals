using System;

namespace NumbersinReversedOrder
{
    public class NumbersinReversedOrder
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string result = ReversedNumber(input);
            Console.WriteLine(result);
        }

        private static string ReversedNumber(string input)
        {
            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += (input[i]);
            }
            return reversed;
        }
    }
}