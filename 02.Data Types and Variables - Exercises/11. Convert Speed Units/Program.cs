using System;

namespace _11.Convert_Speed_Units
{
    public class Program
    {
        public static void Main()
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float timeSeconds = 60.0f * (hours * 60.0f) + minutes * 60.0f + seconds;
            float timeHours = hours + minutes / 60.0f + (seconds / 60.0f) / 60.0f;
            float metersPerSecond = distanceInMeters / timeSeconds;
            float kilometersPerHours = (distanceInMeters / 1000.0f) / (timeHours);
            float milePerHours = (distanceInMeters / 1609.0f) / (timeHours);
            Console.WriteLine($"{metersPerSecond}\n{kilometersPerHours}\n{milePerHours}");
        }
    }
}