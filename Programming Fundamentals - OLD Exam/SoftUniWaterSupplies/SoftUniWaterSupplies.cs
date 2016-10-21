using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniWaterSupplies
{
    public class SoftUniWaterSupplies
    {
        public static void Main()
        {
            long availableWater = long.Parse(Console.ReadLine());
            List<decimal> bottles = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            long bottleCapacity = long.Parse(Console.ReadLine());

            decimal waterInBottles = bottles.Sum();
            decimal neededWater = bottleCapacity * bottles.Count - waterInBottles;

            decimal fillBottle = 0M;
            List<long> index = new List<long>();
            decimal initial = availableWater;
            long counter = 0;

            if (availableWater % 2 != 0)
            {
                for (int i = bottles.Count - 1; i >= 0; i--)
                {
                    FillBottles(bottles, bottleCapacity, ref fillBottle, index, ref initial, ref counter, i);
                }

                PrintResults(availableWater, bottles, neededWater, index, counter);
            }

            else if (availableWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Count; i++)
                {
                    FillBottles(bottles, bottleCapacity, ref fillBottle, index, ref initial, ref counter, i);
                }

                PrintResults(availableWater, bottles, neededWater, index, counter);
            }
        }
        private static void PrintResults(long availableWater, List<decimal> bottles, decimal neededWater, List<long> index, long counter)
        {
            if (neededWater <= availableWater)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {availableWater - neededWater}l.");
            }
            else
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {bottles.Count - counter}");
                Console.WriteLine($"With indexes: {string.Join(", ", index)}");
                Console.WriteLine($"We need {neededWater - availableWater} more liters!");
            }
        }
        private static void FillBottles(List<decimal> bottles, long bottleCapacity, ref decimal fillBottle, List<long> index, ref decimal initial, ref long counter, int i)
        {
            if (bottleCapacity > bottles[i])
            {
                fillBottle += bottleCapacity - bottles[i];


                if (initial < bottleCapacity - bottles[i])
                {
                    index.Add(i);
                }
                else
                {
                    initial -= (bottleCapacity - bottles[i]);
                    counter++;
                }
            }
        }
    }
}