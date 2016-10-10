using System;
using System.Collections.Generic;
using System.Linq;

namespace SieveofEratosthenes
{
    public class SieveofEratosthenes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] prime = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                prime[i] = true;
            }
            for (int j = 2; j <= n; j++)
            {
                if (!prime[j])
                {
                    continue;
                }
                Console.Write($"{j} ");
                for (int k = j + j; k <= n; k += j)
                {
                    prime[k] = false;
                }
            }
            Console.WriteLine();
        }
    }
}
