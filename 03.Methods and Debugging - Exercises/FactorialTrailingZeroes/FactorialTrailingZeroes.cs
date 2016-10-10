using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            int numberFactorial = int.Parse(Console.ReadLine());
            BigInteger factorial = numberFactorial;

            for (int i = 1; i < numberFactorial; i++)
            {
                factorial = factorial * i;
            }
            BigInteger resultPrint = GetTrailingZero(factorial);
            Console.WriteLine(resultPrint);
        }
        static BigInteger GetTrailingZero(BigInteger num)
        {
            BigInteger zeros = 0;
            while (num % 10 == 0)
            {
                num /= 10;
                zeros++;
            }
            return zeros;
        }
    }
}