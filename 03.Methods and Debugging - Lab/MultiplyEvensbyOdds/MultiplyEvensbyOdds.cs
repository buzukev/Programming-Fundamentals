using System;

namespace MultiplyEvensbyOdds
{
    public class MultiplyEvensbyOdds
    {
        public static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvensAndOdds(n);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvensAndOdds(int n)
        {
            int SumEvens = GetSumOfEvenDigits(n);
            int SumOdds = GetSumOfOddDigits(n);
            return SumEvens * SumOdds;
        }

        private static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n>0)
            {
                int lastDigit = n % 10; 
                if (lastDigit % 2 != 0)
                {
                    sum+=lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum +=lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}