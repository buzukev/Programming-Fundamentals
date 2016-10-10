using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int elevatepersons = int.Parse(Console.ReadLine());
            int capacitypersons = int.Parse(Console.ReadLine());
            int courses = (int)(Math.Ceiling((double)elevatepersons / capacitypersons));
            Console.WriteLine(courses);
        }
    }
}