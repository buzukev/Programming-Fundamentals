using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class FixEmails
{
    static void Main()
    {
        string[] input = File.ReadAllLines("input.txt");

        Dictionary<string, string> registerEmails = new Dictionary<string, string>();

        int i = 0;

        while (!input[i].Equals("stop"))
        {
            string emails = input[i + 1];
            registerEmails[input[i]] = emails;
            input = File.ReadAllLines("input.txt");
            i+=2;
        }

        foreach (var email in registerEmails.Where(x => !x.Value.Contains(".us") && !x.Value.Contains(".uk")))
        {
            File.AppendAllText("output.txt", string.Format($"{email.Key} -> {email.Value}" + Environment.NewLine));
        }
    }
}