using System;

namespace MaxMethod
{
    public class MaxMethod
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int firstMax = GetMax(a, b);
            int result = GetMax(firstMax, c);
            Console.WriteLine(result);
        }
        private static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;
        }
    }
}