using System;
using System.Collections.Generic;
using System.Linq;

class LegendaryFarming
{
    static void Main()
    {
        Dictionary<string, int> materials = new Dictionary<string, int>();

        materials.Add("shards", 0);
        materials.Add("fragments", 0);
        materials.Add("motes", 0);

        bool iSShadowmourne = false;
        bool iSValanyr = false;
        bool iSDragonwrath = false;

        while (!iSValanyr && !iSShadowmourne && !iSDragonwrath)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
            string material = string.Empty;
            int quantity = 0;

            for (int i = 1; i < input.Length; i += 2)
            {
                material = input[i];
                quantity = int.Parse(input[i - 1]);

                if (!materials.ContainsKey(material))
                {
                    materials.Add(material, 0);
                }

                materials[material] += quantity;

                if (material.Equals("shards") && materials[material] >= 250)
                {
                    iSShadowmourne = true;
                    materials[material] -= 250;
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                }
                else if (material.Equals("fragments") && materials[material] >= 250)
                {
                    iSValanyr = true;
                    materials[material] -= 250;
                    Console.WriteLine("Valanyr obtained!");
                    break;
                }
                else if (material.Equals("motes") && materials[material] >= 250)
                {
                    iSDragonwrath = true;
                    materials[material] -= 250;
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
                }
            }
        }
        var keyMaterials = materials.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();

        foreach (var key in keyMaterials)
        {
            Console.WriteLine($"{key.Key}: {key.Value}");
        }

        var junkMaterials = materials.Skip(3).OrderBy(x => x.Key).ToList();

        foreach (var junk in junkMaterials)
        {
            Console.WriteLine($"{junk.Key}: {junk.Value}");
        }
    }
}