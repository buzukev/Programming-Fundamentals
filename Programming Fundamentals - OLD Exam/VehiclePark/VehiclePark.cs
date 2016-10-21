using System;
using System.Collections.Generic;
using System.Linq;

namespace VehiclePark
{
    public class VehiclePark
    {
        public static void Main()
        {
            List<string> vehicles = Console.ReadLine().Split(' ').ToList();

            string input = Console.ReadLine();
            int vehiclesSold = 0;

            while (!input.Equals("End of customers!"))
            {
                string[] inputData = input.Split(' ');
                string ask = inputData[0].ToLower()[0] + inputData[2];
                int wanted = -1;

                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (ask == vehicles[i])
                    {
                        wanted = i;
                        break;
                    }
                }

                if (wanted == -1)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    string vehicle = vehicles[wanted];
                    int price = vehicle[0] * int.Parse(vehicle.Substring(1, vehicle.Length - 1));
                    vehiclesSold++;
                    Console.WriteLine($"Yes, sold for {price}$");
                    vehicles.RemoveAt(wanted);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Vehicles left: {string.Join(", ", vehicles)}");
            Console.WriteLine($"Vehicles sold: {vehiclesSold}");
        }
    }
}