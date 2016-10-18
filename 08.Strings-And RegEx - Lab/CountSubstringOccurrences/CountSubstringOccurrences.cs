using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string inputText = Console.ReadLine().ToLower();
            string substring = Console.ReadLine().ToLower();
            int counter = 0;
            int index = inputText.IndexOf(substring);
            while (index != -1)
            {
                counter++;
                index = inputText.IndexOf(substring, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}