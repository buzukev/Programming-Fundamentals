using System;
using System.Collections.Generic;
using System.Linq;

namespace Files
{
    public class Files
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, long>> inputData = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> fileData = new Dictionary<string, long>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split('\\');

                string root = input[0];
                string fileAndSize = input[input.Length - 1];
                string[] fileInfo = fileAndSize.Split(';');
                string fileName = fileInfo[0];
                long fileSize = long.Parse(fileInfo[1]);

                if (inputData.ContainsKey(root))
                {
                    inputData[root][fileName] = fileSize;
                }

                else
                {
                    fileData = new Dictionary<string, long>();
                    fileData[fileName] = fileSize;
                    inputData[root] = fileData;
                }
            }

            string[] command = Console.ReadLine().Split();
            string fileCommand = command[0];
            string rootCommand = command[2];

            bool isTrue = false;

            if (inputData.ContainsKey(rootCommand))
            {
                fileData = inputData[rootCommand]
                            .OrderByDescending(id => id.Value)
                            .ThenBy(id => id.Key)
                            .ToDictionary(id => id.Key, id => id.Value);
            }

            foreach (KeyValuePair<string, long> filePair in fileData)
            {
                string[] fileNameAndExtension = filePair.Key.Split('.');

                if (fileNameAndExtension[fileNameAndExtension.Length - 1].Equals(fileCommand))
                {
                    isTrue = true;
                    Console.WriteLine($"{filePair.Key} - {filePair.Value} KB");
                }
            }
            if (!isTrue)
            {
                Console.WriteLine("No");
            }
        }
    }
}