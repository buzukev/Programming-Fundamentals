using System;
using System.Linq;

namespace ReverseanArrayofStrings
{
    public class ReverseanArrayofStrings
    {
        private static int j;

        public static void Main()
        {
            string[] items = Console.ReadLine().Split(' ').ToArray();
            string[] reversedItems = items.Reverse().ToArray();
            Console.WriteLine(String.Join(" ", reversedItems));

            // variant two
            /* string[] items = Console.ReadLine().Split(' ').ToArray();
             var result = new string[items.Length];
             for (int i = 0; j = items.Length - 1; i < items.Length; i++; j--)
             {
                 result[j] = items[i];
             }
             Console.WriteLine(String.Join(" ", result));*/

            //variant three
            /*string[] items = Console.ReadLine().Split(' ').ToArray();
           
            for (int i = 0; i < items.Length / 2; i++)
            {
                var old = items[i];
                items[i] = items[items.Length - 1 - i];
                items[items.Length - 1 - i] = old;
            }
            Console.WriteLine(String.Join(" ", items));*/

            //funcional variant
            //Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Reverse()));

            //funcional variant with integer
            //Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Select(int.Parse).Reverse()));
        }
    }
}