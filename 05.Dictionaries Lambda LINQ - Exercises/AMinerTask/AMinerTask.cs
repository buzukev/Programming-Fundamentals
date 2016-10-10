using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    public class AMinerTask
    {
        public static void Main()
        {
            string resourceType = Console.ReadLine();

            Dictionary<string, long> resources = new Dictionary<string, long>();

            while (!resourceType.Equals("stop"))
            {
                long resourceQuantity = long.Parse(Console.ReadLine());

                if (! resources.ContainsKey(resourceType))
                {
                    resources.Add(resourceType, 0);
                }

                resources[resourceType] += resourceQuantity;

                resourceType = Console.ReadLine(); 
            }
            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}