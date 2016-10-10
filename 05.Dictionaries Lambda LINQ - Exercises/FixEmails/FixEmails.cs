using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            /* string name = Console.ReadLine();

             Dictionary<string, string> register = new Dictionary<string, string>();

             while (!name.Equals("stop"))
             {
                 string email = Console.ReadLine();
                 string domain = email.Substring(email.Length - 2);

                 if (!domain.Equals("uk") && !domain.Equals("us"))
                 {
                     register[name] = email;
                 }

                 name = Console.ReadLine();
             }

             foreach (var num in register)
             {
                 Console.WriteLine($"{num.Key} -> {num.Value}");
             }*/


            //variant two
            string name = Console.ReadLine();

            Dictionary<string, string> register = new Dictionary<string, string>();

            while (!name.Equals("stop"))
            {
                string emails = Console.ReadLine();

                register[name] = emails;

                name = Console.ReadLine();
            }

            foreach (var user in register.Where(x => !x.Value.Contains(".us") && !x.Value.Contains(".uk")))
            {
                Console.WriteLine($"{user.Key} -> {user.Value}");
            }
        }
    }
}