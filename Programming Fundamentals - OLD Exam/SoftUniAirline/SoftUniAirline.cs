using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniAirline
{
    public class SoftUniAirline
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            decimal overallProfit = 0;
            decimal averageProfit = 0;

            for (int i = 0; i < n; i++)
            {
                int adultPassengersCount = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                int youthPassengersCount = int.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                decimal income = (adultPassengersCount * adultTicketPrice) + (youthPassengersCount * youthTicketPrice);
                decimal expenses = (flightDuration * fuelConsumptionPerHour * fuelPricePerHour);

                decimal profit = income - expenses;

                if (income >= expenses)
                {
                    Console.WriteLine($"You are ahead with {profit:f3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:f3}$.");
                }

                overallProfit += profit;
                averageProfit += profit / n;
            }
            Console.WriteLine($"Overall profit -> {overallProfit:f3}$.\r\nAverage profit -> {averageProfit:f3}$.");
        }
    }
}