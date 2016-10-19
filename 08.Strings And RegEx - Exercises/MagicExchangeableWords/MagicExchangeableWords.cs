using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicExchangeableWords
{
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string str1 = input[0];
            string str2 = input[1];
            string result = "true";

            string maxStr = "";
            string minStr = "";

            if (str1.Length >= str2.Length)
            {
                maxStr = str1;
                minStr = str2;
            }
            else
            {
                maxStr = str2;
                minStr = str1;
            }

            Dictionary<char, char> dictionary = new Dictionary<char, char>();

            for (int i = 0; i < maxStr.Length; i++)
            {
                if (i < minStr.Length)
                {
                    if (!dictionary.ContainsKey(maxStr[i]))
                    {
                        dictionary.Add(maxStr[i], minStr[i]);
                    }
                    else if (dictionary[maxStr[i]] != minStr[i])
                    {
                        result = "false";
                        break;
                    }
                }
                else if (!dictionary.ContainsKey(maxStr[i]))
                {
                    result = "false";
                }
            }
            Console.WriteLine(result);
        }
    }
}