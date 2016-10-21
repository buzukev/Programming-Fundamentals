using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballLeague
{
    public class FootballLeague
    {
        public static void Main()
        {
            Dictionary<string, int> standings = new Dictionary<string, int>();
            Dictionary<string, int> goals = new Dictionary<string, int>();

            string key = Console.ReadLine();
            string input = Console.ReadLine();

            while (!input.Equals("final"))
            {
                string[] inputArr = input.Split(' ');

                string teamA = GetTeamName(inputArr[0], key);
                string teamB = GetTeamName(inputArr[1], key);

                string[] score = inputArr[2].Split(':');

                int teamAScore = int.Parse(score[0]);
                int teamBScore = int.Parse(score[1]);

                if (teamAScore > teamBScore)
                {
                    AddScoreToTeam(standings, teamA, 3);
                    AddScoreToTeam(standings, teamB, 0);
                }

                else if (teamAScore < teamBScore)
                {
                    AddScoreToTeam(standings, teamA, 0);
                    AddScoreToTeam(standings, teamB, 3);
                }
                else
                {
                    AddScoreToTeam(standings, teamA, 1);
                    AddScoreToTeam(standings, teamB, 1);
                }

                AddScoreToTeam(goals, teamA, teamAScore);
                AddScoreToTeam(goals, teamB, teamBScore);

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            var sorted = standings.OrderByDescending(t => t.Value).ThenBy(t => t.Key);
            int count = 1;

            foreach (var standing in sorted)
            {
                Console.WriteLine($"{count}. {standing.Key} {standing.Value}");
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");

            var sortedGoals = goals.OrderByDescending(t => t.Value).ThenBy(t => t.Key).Take(3);

            foreach (var goal in sortedGoals)
            {
                Console.WriteLine($"- {goal.Key} -> {goal.Value}");
            }
        }

        private static void AddScoreToTeam(Dictionary<string, int> standings, string teamA, int points)
        {
            if (!standings.ContainsKey(teamA))
            {
                standings.Add(teamA, 0);
            }
            standings[teamA] += points;
        }

        private static string GetTeamName(string teamName, string key)
        {
            int firstIndex = teamName.IndexOf(key) + key.Length;
            int secondIndex = teamName.LastIndexOf(key);
            string name = teamName.Substring(firstIndex, secondIndex - firstIndex);
            return string.Join("", name.ToUpper().Reverse());
        }
    }
}