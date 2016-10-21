using System;
using System.Collections.Generic;
using System.Linq;

namespace SweetDessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            double cash = double.Parse(Console.ReadLine());
            long guests = long.Parse(Console.ReadLine());
            double priceBananas = double.Parse(Console.ReadLine());
            double priceEggs = double.Parse(Console.ReadLine());
            double priceBerries = double.Parse(Console.ReadLine());

            int portions = 6;

            long sets = (long)Math.Ceiling((guests * 1.0) / (portions * 1.0));

            double oneSetBananas = 2.0;
            double oneSetEggs = 4.0;
            double oneSetBerries = 0.2;

            double needProducts = sets * ((oneSetBananas * priceBananas) + (oneSetEggs * priceEggs) + (oneSetBerries * priceBerries));

            if (needProducts <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {needProducts:f2}lv.");
            }
            else
            {
                double needMoney = needProducts - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {needMoney:f2}lv more.");
            }
        }
    }
}