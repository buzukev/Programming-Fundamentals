using System;

namespace MasterNumber
{
    public class MasterNumber
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            for (long i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) % 7 == 0 && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool ContainsEvenDigit(long n)
        {
            bool contains = false;
            while (n > 0)
            {
                long lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    contains = true;
                    break;
                }
                else
                    n /= 10;
            }
            return contains;
        }
        static long SumOfDigits(long n)
        {
            long sum = 0;
            while (n > 0)
            {
                long lastDigit = n % 10;
                sum += lastDigit;
                n /= 10;
            }
            return sum;
        }
        static bool IsPalindrome(long n)
        {
            long reverse = 0;
            long num = n;
            while (n > 0)
            {
                long lastDigit = n % 10;
                reverse = reverse * 10 + lastDigit;
                n /= 10;
            }
            bool isPalindrome = false;
            if (reverse == num)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }
    }
}