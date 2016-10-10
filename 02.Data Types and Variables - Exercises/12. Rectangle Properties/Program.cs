using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = (width + height) * 2;
            double diagonal = Math.Sqrt((width * width) + (height * height));
            Console.WriteLine($"{perimeter}\n{area}\n{diagonal}");
        }
    }
}