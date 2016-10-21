using System;
using System.Collections.Generic;
using System.Linq;

namespace TrophonTheGrumpyCat
{
    public class TrophonTheGrumpyCat
    {
        public static void Main()
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            int startPosition = int.Parse(Console.ReadLine());

            List<long> leftSide = numbers.Take(startPosition).ToList();
            List<long> rightSide = numbers.Skip(startPosition + 1).ToList();

            string typeOfItems = Console.ReadLine();

            if (typeOfItems.Equals("cheap"))
            {
                leftSide = leftSide.Where(x => x < numbers[startPosition]).ToList();
                rightSide = rightSide.Where(x => x < numbers[startPosition]).ToList();
            }
            else
            {
                leftSide = leftSide.Where(x => x >= numbers[startPosition]).ToList();
                rightSide = rightSide.Where(x => x >= numbers[startPosition]).ToList();
            }

            string priceRating = Console.ReadLine();

            if (priceRating.Equals("positive"))
            {
                leftSide = leftSide.Where(x => x > 0).ToList();
                rightSide = rightSide.Where(x => x > 0).ToList();
            }
            else if (priceRating.Equals("negative"))
            {
                leftSide = leftSide.Where(x => x < 0).ToList();
                rightSide = rightSide.Where(x => x < 0).ToList();
            }

            long leftSumDamage = leftSide.Sum();
            long rightSumDamage = rightSide.Sum();

            if (leftSumDamage >= rightSumDamage)
            {
                Console.WriteLine($"Left - {leftSumDamage}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSumDamage}");
            }
        }
    }
}