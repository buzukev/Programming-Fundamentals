using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string result = new string(input.Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}