using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SoftuniCoffeeOrders
{
    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCaps = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsCount = long.Parse(Console.ReadLine());

                decimal orderPrice = (DateTime.DaysInMonth(date.Year, date.Month)) * (capsCount * pricePerCaps);

                sum += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}