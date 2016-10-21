using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfNames
{
    public class GameOfNames
    {
        public static void Main()
        {
            int numOfPlayers = int.Parse(Console.ReadLine());

            long maxPoints = long.MinValue;
            string winner = string.Empty;

            for (int i = 0; i < numOfPlayers; i++)
            {
                string name = Console.ReadLine();
                int initialPoints = int.Parse(Console.ReadLine());
                long totalPoints = initialPoints;
                char[] nameArr = name.ToCharArray();

                for (int j = 0; j < nameArr.Length; j++)
                {
                    if ((long)nameArr[j] % 2 == 0)
                    {
                        totalPoints += (long)nameArr[j];
                    }
                    else
                    {
                        totalPoints -= (long)nameArr[j];
                    }
                }

                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    winner = name;
                }
                Console.WriteLine($"The winner is {name} - {maxPoints} points");

            }
            Console.WriteLine($"The winner is {winner} - {maxPoints} points");
        }
    }
}