using System;

namespace FibonacciNumbers
{
    public class FibonacciNumbers
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long result = GetFibNumber(n);
            Console.WriteLine(result);
        }

        private static long GetFibNumber(long n)
        {
            long firstFib = 1;
            long secondFib = 1;
            long currentFib = 1;
            for (long i = 1; i < n; i++)
            {
                firstFib = secondFib;
                secondFib = currentFib;
                currentFib = firstFib + secondFib;
            }
            return currentFib;
        }
    }
}