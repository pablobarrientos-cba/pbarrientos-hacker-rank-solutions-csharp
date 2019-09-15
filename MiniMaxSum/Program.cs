using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniMaxSum
{
    internal static class Solution
    {

        // Complete the miniMaxSum function below.
        private static void MiniMaxSum(IEnumerable<long> arr)
        {
            long sum = 0;
            var auxMin = long.MaxValue;
            var auxMax = long.MinValue;

            foreach (var item in arr)
            {
                sum += item;
                auxMin = Math.Min(auxMin, item);
                auxMax = Math.Max(auxMax, item);
            }

            Console.WriteLine($"{sum - auxMax} {sum - auxMin}");
        }

        private static void Main(string[] args)
        {
            // we need to cast to Int64 to avoid overflow
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt64);

            //One liner solution using LINQ capabilities
            Console.WriteLine($"{arr.Sum() - arr.Max()} {arr.Sum() - arr.Min()}");
            
            //Completing the method as depicted on HackerRank exercise
            MiniMaxSum(arr);
         }
    }
}