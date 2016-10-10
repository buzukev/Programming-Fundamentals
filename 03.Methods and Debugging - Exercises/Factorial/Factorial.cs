using System;
using System.Numerics;

namespace Factorial
{
    public class Factorial
    {
        public static void Main()
        {
            BigInteger numberFactorial = BigInteger.Parse(Console.ReadLine());
            BigInteger result = numberFactorial;
            for (BigInteger i = 1; i < numberFactorial; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}