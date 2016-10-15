using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");

            for (int i = 1; i < text.Length; i += 2)
            {
                File.AppendAllText("output.txt", text[i] + Environment.NewLine);
            }

            //variant two

            /*string[] text = File.ReadAllLines("input.txt");

            File.WriteAllLines("output.txt", text.Where((line, index) => index % 2 == 1));*/
        }
    }
}