using System;
using System.Collections.Generic;


namespace Nacepin
{
    public class Nacepin
    {
        public static void Main()
        {
            decimal priceForUS = decimal.Parse(Console.ReadLine());
            decimal weightForUS = decimal.Parse(Console.ReadLine());
            decimal priceForUK = decimal.Parse(Console.ReadLine());
            decimal weightForUK = decimal.Parse(Console.ReadLine());
            decimal priceForCN = decimal.Parse(Console.ReadLine());
            decimal weightForCN = decimal.Parse(Console.ReadLine());

            decimal levaUSD = 0.58M;
            decimal levaGBP = 0.41M;
            decimal levaCNY = (1M / 0.27M);

            decimal storeUSPriceForKg = Math.Round((priceForUS / weightForUS) / levaUSD, 2);
            decimal storeUKPriceForKg = Math.Round((priceForUK / weightForUK) / levaGBP, 2);
            decimal storeCNPriceForKg = Math.Round((priceForCN / weightForCN) / levaCNY, 2);

            string store = "";
            decimal price = 0;
            decimal diff = 0;

            if (storeCNPriceForKg <= Math.Min(storeUSPriceForKg, storeUKPriceForKg))
            {
                store = "Chinese store.";
                price = storeCNPriceForKg;
                diff = Math.Max(storeUSPriceForKg, storeUKPriceForKg) - price;
            }
            else if (storeUSPriceForKg <= Math.Min(storeCNPriceForKg, storeUKPriceForKg))
            {
                store = "US store.";
                price = storeUSPriceForKg;
                diff = Math.Max(storeCNPriceForKg, storeUKPriceForKg) - price;
            }
            else
            {
                store = "UK store.";
                price = storeUKPriceForKg;
                diff = Math.Max(storeCNPriceForKg, storeUSPriceForKg) - price;
            }

            Console.WriteLine($"{store} {price:f2} lv/kg");
            Console.WriteLine($"Difference {diff:f2} lv/kg");
        }
    }
}