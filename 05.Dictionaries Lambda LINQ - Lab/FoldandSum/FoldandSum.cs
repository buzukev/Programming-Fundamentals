using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldandSum
{
    public class FoldandSum
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] firstRowLeft = arr.Take(k).Reverse().ToArray();
            int[] firstRowRight = arr.Reverse().Take(k).ToArray();
            int[] firstRow = firstRowLeft.Concat(firstRowRight).ToArray();
            int[] secondRow = arr.Skip(k).Take(2*k).ToArray();
            var sumArr = firstRow.Select((x, index) => x + secondRow[index]);
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}