using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            for (long i = 1; i <= n; i++)
                if (IsPalindrome(i) && SumOfDigits(i) % 7 == 0 && ContainsEvenDigit(i))
                    Console.WriteLine(i);
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
            bool palindrome = false;
            if (reverse == num)
                palindrome = true;
            return palindrome;
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
        static bool ContainsEvenDigit(long n)
        {
            bool contains = false;
            while (n > 0)
            {
                long lastDigit = n % 10;
                if (lastDigit % 2 == 0 && lastDigit != 0)
                {
                    contains = true;
                    break;
                }
                else
                    n /= 10;
            }
            return contains;
        }
    }
}