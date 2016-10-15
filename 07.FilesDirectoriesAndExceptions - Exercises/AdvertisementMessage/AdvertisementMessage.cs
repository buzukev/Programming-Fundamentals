using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class AdvertisementMessage
{
    static void Main(string[] args)
    {
        string[] phrases = File.ReadAllLines("Message/Phrases.txt");
        string[] events = File.ReadAllLines("Message/Events.txt");
        string[] authors = File.ReadAllLines("Message/Authors.txt");
        string[] cities = File.ReadAllLines("Message/Cities.txt");

        int n = int.Parse(File.ReadAllText("input.txt"));

        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            string randomPhrase = phrases[random.Next(phrases.Length)];
            string randomEvent = events[random.Next(events.Length)];
            string randomAutor = authors[random.Next(authors.Length)];
            string randomCity = cities[random.Next(cities.Length)];

            File.AppendAllText("output.txt", string.Format(
                $"{randomPhrase} {randomEvent} {randomAutor} - {randomCity}" + Environment.NewLine));
        }
    }
}