using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogwartsSorting
{
    public class HogwartsSorting
    {
        public static void Main(string[] args)
        {
            int numberOfNewCommers = int.Parse(Console.ReadLine());

            int gryffindor = 0;
            int slytherin = 0;
            int ravenclaw = 0;
            int hufflepuff = 0;

            for (int i = 0; i < numberOfNewCommers; i++)
            {
                string[] names = Console.ReadLine().Split(' ');
                string firstName = names[0];
                string lastName = names[1];
                int sum = 0;

                for (int j = 0; j < firstName.Length; j++)
                {
                    sum += firstName[j];
                }

                for (int j = 0; j < lastName.Length; j++)
                {
                    sum += lastName[j];
                }

                string facultyNumber = string.Format($"{sum}{firstName[0]}{lastName[0]}");

                int reminder = sum % 4;

                switch (reminder)
                {
                    case 0:
                        gryffindor++;
                        Console.WriteLine($"Gryffindor {facultyNumber}");
                        break;

                    case 1:
                        slytherin++;
                        Console.WriteLine($"Slytherin {facultyNumber}");
                        break;

                    case 2:
                        ravenclaw++;
                        Console.WriteLine($"Ravenclaw {facultyNumber}");
                        break;

                    case 3:
                        hufflepuff++;
                        Console.WriteLine($"Hufflepuff {facultyNumber}");
                        break;
                }
            }
            Console.WriteLine($"\r\nGryffindor: {gryffindor}" +
                                   $"\r\nSlytherin: {slytherin}" +
                                   $"\r\nRavenclaw: {ravenclaw}" +
                                   $"\r\nHufflepuff: {hufflepuff}");
        }
    }
}