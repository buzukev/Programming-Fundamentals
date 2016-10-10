using System;

namespace MathPower
{
    public class MathPower
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaseToPower(number, power);
            Console.WriteLine(result);
        }

        private static double RaseToPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}