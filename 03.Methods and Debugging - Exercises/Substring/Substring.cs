using System;
using System.Collections.Generic;
using System.Linq;

namespace Substring
{
    class Substring
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int endIndex = jump + 1;

                    string matchedString = "";
                    if (endIndex + i > text.Length)
                    {
                        matchedString = text.Substring(i);
                    }
                    else
                    {
                        matchedString = text.Substring(i, endIndex);
                    }

                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}