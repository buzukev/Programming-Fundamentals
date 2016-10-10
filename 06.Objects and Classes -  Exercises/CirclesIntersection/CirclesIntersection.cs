using System;
using System.Collections.Generic;
using System.Linq;


public class CirclesIntersection
{
    public static void Main()
    {
        var c1 = CirclePoint.ReadPoint();
        var c2 = CirclePoint.ReadPoint();

        var distanceBetweenCenter = CirclePoint.DistanceBetweenCircle(c1, c2);
        var distanceBetweenRadius = CirclePoint.RadiusSum(c1, c2);


        if (distanceBetweenCenter <= distanceBetweenRadius)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}

public class CirclePoint
{
    public double Center { get; set; }
    public double Radius { get; set; }
    public double X { get; set; }
    public double Y { get; set; }

    public static CirclePoint ReadPoint()
    {
        var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var point = new CirclePoint() { X = coords[0], Y = coords[1], Radius = coords[2] };
        return point;
    }

    public static double DistanceBetweenCircle(CirclePoint point1, CirclePoint point2)
    {
        var a = point1.X - point2.X;
        var b = point1.Y - point2.Y;
        var distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        return distance;
    }

    public static double RadiusSum(CirclePoint r1, CirclePoint r2)
    {
        var dist = r1.Radius + r2.Radius;
        return dist;
    }
}