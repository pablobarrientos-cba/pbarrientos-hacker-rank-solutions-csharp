using System;
using System.IO;

namespace TimeConversion
{
    internal static class Program
    {
        /*
        * Complete the timeConversion function below.
        */
        private static string TimeConversion(string str)
        {
            /*
             * Write your code here.
             */
            var hours   = int.Parse(str.Substring(0,2));
            var minutes = int.Parse(str.Substring(3,2));
            var seconds = int.Parse(str.Substring(6,2));
            
            if (str.Substring(8, 2).ToLower().Equals("pm") && hours != 12) {
                hours += 12;
            } else if (str.Substring(8, 2).ToLower().Equals("am") && hours == 12) {
                hours = 0;
            }

            
            return $"{hours:00}:{minutes:00}:{seconds:00}";
        }

        private static void Main()
        {
            Console.WriteLine(TimeConversion(Console.ReadLine()));
        }
    }
}