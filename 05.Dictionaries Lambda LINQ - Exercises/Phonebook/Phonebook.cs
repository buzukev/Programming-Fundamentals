using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>(); 

            string input = Console.ReadLine();

            while (! input.Equals("END"))
            {
                string[] arr = input.Split(' ');
                string command = arr[0];

                if (command.Equals("A"))
                {
                    string contact = arr[1];
                    string phoneNumber = arr[2];
                    phonebook[contact] = phoneNumber;
                }

                else if (command.Equals("S"))
                {
                    string contact = arr[1];

                    if (phonebook.ContainsKey(contact))
                    {
                        Console.WriteLine($"{contact} -> {phonebook[contact]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {contact} does not exist.");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}