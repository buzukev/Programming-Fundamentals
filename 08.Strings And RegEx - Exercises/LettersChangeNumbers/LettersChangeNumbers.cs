using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LettersChangeNumbers
{
    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var input = Regex.Split(Console.ReadLine(), @"\s+").ToList();

            double sum = 0.0;

            input.ForEach(line =>
            {
                if (line != "")
                {
                    char left = line[0];
                    char right = line[line.Length - 1];
                    double num = double.Parse(Regex.Match(line, @"(\d+)").Groups[1].ToString());

                    if (left >= 'a' && left <= 'z')
                    {
                        num = num * (left + 1 - 'a');
                    }
                    else
                    {
                        num = num / (left + 1 - 'A');
                    }

                    if (right >= 'a' && right <= 'z')
                    {
                        num = num + (right + 1 - 'a');
                    }
                    else
                    {
                        num = num - (right + 1 - 'A');
                    }
                    sum += num;
                }
            });
            Console.WriteLine($"{sum:f2}");
        }
    }
}