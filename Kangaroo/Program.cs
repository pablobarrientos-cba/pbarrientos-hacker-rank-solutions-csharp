using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Kangaroo
{
    class Solution {

        // Complete the kangaroo function below.
        static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            return v2 >= v1 ? "No" : KangaroosMeet(x1, x2, v1, v2);
        }

        private static string KangaroosMeet(int x1, int x2, int v1, int v2)
        {
            var location1 = x1 + v1;
            var location2 = x2 + v2;

            return DoTheyMeet(location1, location2, v1, v2);
        }

        private static string DoTheyMeet(int location1, int location2, int v1, int v2)
        {
            if (location1 == location2) return "YES";
            if (location1 >= location2) return "NO";
            
            location1 += v1;
            location2 += v2;
            return DoTheyMeet(location1, location2, v1, v2);
        }

        static void Main(string[] args) {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = Kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);
        }
    }
}