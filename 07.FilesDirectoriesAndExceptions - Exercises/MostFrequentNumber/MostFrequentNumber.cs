using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            string[] intputFromFile = File.ReadAllText("input.txt").Split(' ').ToArray();

            int counter = 0;
            int number = 0;

            for (int i = 0; i < intputFromFile.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < intputFromFile.Length; j++)
                {
                    if (intputFromFile[i] == intputFromFile[j])
                    {
                        count++;

                        if (count > counter)
                        {
                            counter = count;
                            number = int.Parse(intputFromFile[i]);
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            File.AppendAllText("output.txt", string.Join("", number));
        }
    }
}