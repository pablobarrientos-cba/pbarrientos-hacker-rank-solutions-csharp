using System;
using System.Linq;

namespace ApplesAndOranges
{
    static class Solution {

        // Complete the countApplesAndOranges function below.
        static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
            Console.WriteLine(apples.Count(l => l+a >= s && l+a <= t));
            Console.WriteLine(oranges.Count(l => l+b >= s && l+b <= t));
        }

        static void Main(string[] args) {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
                ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
                ;
            CountApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}