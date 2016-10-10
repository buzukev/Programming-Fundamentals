using System;
using System.Linq;

namespace SumArrays
{
    public class SumArrays
    {
        public static void Main()
        {
            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = Math.Max(arr1.Length, arr2.Length);
            var sumArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                sumArr[i] = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);
            }
            Console.WriteLine(string.Join(" ", sumArr));

            //variant two
            /*var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = Math.Max(arr1.Length, arr2.Length);
            var sumArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                var p1 = i;
                while (p1 >= arr1.Length)
                    p1 = p1 - arr1.Length;
                var p2 = i;
                while (p2 >= arr2.Length)
                    p2 = p2 - arr2.Length;

                sumArr[i] = (arr1[p1] + arr2[p2]);
            }
            Console.WriteLine(string.Join(" ", sumArr));*/
        }
    }
}