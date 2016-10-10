using System;
using System.Collections.Generic;
using System.Linq;

namespace PhonebookUpgrade
{
    public class PhonebookUpgrade
    {
        public static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (!input.Equals("END"))
            {
                string[] arr = input.Split(' ');
                string command = arr[0];

                if (command.Equals("A"))
                {
                    AddNewEntry(phonebook, arr);
                }

                else if (command.Equals("S"))
                {
                    PrintEntry(phonebook, arr);
                }
                else if (command.Equals("ListAll"))
                {
                    PrintAllEntry(phonebook);
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintAllEntry(Dictionary<string, string> phonebook)
        {
            var orderedPhonebook = phonebook.OrderBy(x => x.Key);

            foreach (var entry in orderedPhonebook)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }

        private static void AddNewEntry(Dictionary<string, string> phonebook, string[] arr)
        {
            string contact = arr[1];
            string phoneNumber = arr[2];
            phonebook[contact] = phoneNumber;
        }

        private static void PrintEntry(Dictionary<string, string> phonebook, string[] arr)
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
    }
}