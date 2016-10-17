using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimesInGivenRange
{
    public class PrimesInGivenRange
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> numbers = IsPrime(startNum, endNum);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);
                if (i == numbers.Count - 1)
                {
                    Console.WriteLine();
                    break;
                }
                Console.Write(", ");
            }

        }

        public static List<int> IsPrime(int startNum, int endNum)
        {
            List<int> primesNum = new List<int>();

            if (startNum <2)
            {
                startNum = 2;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primesNum.Add(i);
                }
            }
            return primesNum;
        }
    }
}