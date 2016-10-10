using System;

namespace CubeProperties
{
    public class CubeProperties
    {
        public static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
            double volume = cubeSide * (cubeSide * cubeSide);
            double area = (6 * Math.Pow(cubeSide, 2));
            if (parameter == "face")
            {
                Console.WriteLine($"{faceDiagonal:f2}");
            }
            else if (parameter == "space")
            {
                Console.WriteLine($"{spaceDiagonal:f2}");
            }
            else if (parameter == "volume")
            {
                Console.WriteLine($"{volume:f2}");
            }
            else if (parameter == "area")
            {
                Console.WriteLine($"{area:f2}");
            }
        }
    }
}