using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string intToHexa = Convert.ToString(input, 16).ToUpper();
            string intToBinary = Convert.ToString(input, 2).ToUpper();
            Console.WriteLine(intToHexa);
            Console.WriteLine(intToBinary);
        }
    }
}