using System;

namespace LastKNumbersSumsSequence
{
    public class LastKNumbersSumsSequence
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            var arr = new long[n];
            arr[0] = 1;
            for (long i = 1; i < n; i++)
            {
                arr[i] = SumNums(arr, i - k, i - 1);
            }
            Console.WriteLine("Sequence:");
            Console.WriteLine(String.Join(" ", arr));
        }
        private static long SumNums(long[] arr, long startIndex, long endIndex)
        {
            long sum = 0;
            for (long i = startIndex; i <= endIndex; i++)
            {
                if (i >=0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}