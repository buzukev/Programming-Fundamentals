using System;

namespace PrimeChecker
{
    public class PrimeChecker
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(n);
            Console.WriteLine(isPrime);
        }
        static bool IsPrime(long n)
        {
            if (n == 1 || n == 0)
            {
                return false;
            }
            for (long i = 2; i <=Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}