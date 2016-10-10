using System;
using System.Collections.Generic;
using System.Linq;

namespace DistanceBetweenPoints
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Point ReadPoint()
        {
            var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var point = new Point() { X = coords[0], Y = coords[1] };
            return point;
        }
        public static double CalculateDistance(Point point1, Point point2)
        {
            var a = point1.X - point2.X;
            var b = point1.Y - point2.Y;
            var c = a * a + b * b;
            var distance = Math.Sqrt(c);
            return distance;
        }
    }

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var point1 = Point.ReadPoint();
            var point2 = Point.ReadPoint();
            Console.WriteLine("{0:f3}", Point.CalculateDistance(point1, point2));
        }
    }
}