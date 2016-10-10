using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsofCards
{
    public class HandsofCards
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> playersCards = new Dictionary<string, List<string>>();

            while (!input.Equals("JOKER"))
            {
                string[] arr = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                string playersName = arr[0];
                string[] cards = arr[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                if (!playersCards.ContainsKey(playersName))
                {
                    playersCards.Add(playersName, new List<string>());
                }

                playersCards[playersName].AddRange(cards);

                input = Console.ReadLine();
            }
            PrintPlayersScores(playersCards);
        }

        private static void PrintPlayersScores(Dictionary<string, List<string>> playersCards)
        {
            foreach (var playersEntry in playersCards)
            {
                string playerName = playersEntry.Key;
                List<string> cards = playersEntry.Value.Distinct().ToList();
                int score = 0;
                foreach (var card in cards)
                {
                    string rank = card.Substring(0, card.Length - 1);
                    string suite = card.Substring(card.Length - 1);
                    int rankPower = GetRank(rank);
                    int suitePower = GetSuite(suite);

                    score += rankPower * suitePower;
                }
                Console.WriteLine($"{playerName}: {score}");
            }
        }

        private static int GetRank(string rank)
        {
            switch (rank)
            {
                case "2": return 2;
                case "3": return 3;
                case "4": return 4;
                case "5": return 5;
                case "6": return 6;
                case "7": return 7;
                case "8": return 8;
                case "9": return 9;
                case "10": return 10;
                case "J": return 11;
                case "Q": return 12;
                case "K": return 13;
                case "A": return 14;
                default: return 1;
            }
        }

        private static int GetSuite(string suite)
        {
            switch (suite)
            {
                case "S": return 4;
                case "H": return 3;
                case "D": return 2;
                case "C": return 1;
                default: return 1;
            }
        }
    }
}