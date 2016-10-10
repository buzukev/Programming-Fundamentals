﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int num = i;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine("{0} -> {1}", i, isSpecial);
            }
        }
    }
}