using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestTwoPoints(points);

            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }
        public static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }
        public static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        static void PrintDistance(Point[] points)
        {
            double distance = CalculateDistance(points[0], points[1]);
            Console.WriteLine("{0:f3}", distance);
        }
        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalculateDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }
            return closestTwoPoints;
        }
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

        }
        public static double CalculateDistance(Point point1, Point point2)
        {
            var a = point1.X - point2.X;
            var b = point1.Y - point2.Y;
            var c = a * a + b * b;
            var distance = Math.Sqrt(c);
            return distance;
        }
        public static Point ReadPoint()
        {
            var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var point = new Point() { X = coords[0], Y = coords[1] };
            return point;
        }
    }
}