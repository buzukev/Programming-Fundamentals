using System;

namespace LongerLine
{
    public class LongerLine
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLine = GetLineLenght(x1, y1, x2, y2);
            double secondLine = GetLineLenght(x3, y3, x4, y4);

            if (firstLine >= secondLine && IsCloserPointToZero(x1, y1, x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else if (firstLine >= secondLine && IsCloserPointToZero(x1, y1, x2, y2) == false)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else if (firstLine < secondLine && IsCloserPointToZero(x3, y3, x4, y4))
            {
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
            else if (firstLine < secondLine && IsCloserPointToZero(x3, y3, x4, y4) == false)
            {
                Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
        }
        private static double GetLineLenght(double x1, double y1, double x2, double y2)
        {
            double lineleght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lineleght;
        }
        private static bool IsCloserPointToZero(double x1, double y1, double x2, double y2)
        {
            bool isCloserPointToZero = false;
            double distance1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double distance2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (distance1 <= distance2)
            {
                isCloserPointToZero = true;
            }
            return isCloserPointToZero;
        }
    }
}