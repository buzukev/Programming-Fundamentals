using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol;
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());

            for (int i = start; i <= finish && i <= 255; i++)
            {
                symbol = (char)i;
                Console.Write($"{symbol} ");
            }
            Console.WriteLine();
        }
    }
}