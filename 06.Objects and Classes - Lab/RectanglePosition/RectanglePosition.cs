using System;
using System.Linq;

public class RectanglePosition
{
    public static void Main()
    {
        var r1 = Rectangle.ReadRectangle();
        var r2 = Rectangle.ReadRectangle();
        Console.WriteLine(Rectangle.IsFirstRectIsInsideSecondRect(r1, r2)
            ? "Inside" : "Not inside");
    }
}

public class Rectangle
{
    public int Left { get; set; }
    public int Top { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public static Rectangle ReadRectangle()
    {
        var coords = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var rectangle = new Rectangle() { Left = coords[0], Top = coords[1], Width = coords[2], Height = coords[3] };
        return rectangle;
    }

    public int Bottom
    {
        get
        {
            return this.Top + this.Height;
        }

    }

    public int Right
    {
        get
        {
            return this.Left + this.Width;
        }

    }

    public static bool IsFirstRectIsInsideSecondRect(Rectangle r1, Rectangle r2)
    {
        var inside = r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Top >= r2.Top && r2.Bottom <= r2.Bottom;
        return inside;
    }
}