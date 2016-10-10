using System;

namespace GeometryCalculator
{
    public class GeometryCalculator
    {
        public static void Main()
        {
            string figureType = Console.ReadLine().ToLower();

            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = (side * height) / 2;
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = width * height;
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI*(Math.Pow(radius, 2));
                Console.WriteLine($"{area:f2}");
            }
        }
    }
}