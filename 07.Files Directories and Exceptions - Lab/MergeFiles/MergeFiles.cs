using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MergeFiles
{
    class MergeFiles
    {
        static void Main()
        {
            string[] firstInput = File.ReadAllLines("FileOne.txt");
            string[] secondInput = File.ReadAllLines("FileTwo.txt");


            for (int i = 0; i < firstInput.Length; i++)
            {
                //variant one
                // File.AppendAllText("output.txt", firstInput[i] + Environment.NewLine + secondInput[i] + Environment.NewLine);
                
                //variant two
                File.AppendAllLines("output.txt", new string[] { firstInput[i], secondInput[i]});
            }
        }
    }
}
