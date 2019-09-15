using System;
using System.IO;
using System.Linq;

namespace BirthdayCakeCandles
{
    internal static class Program
    {
        // Complete the birthdayCakeCandles function below.
        private static int BirthdayCakeCandles(long[] ar)
        {
            var max = ar.Max();
            return ar.Count(x => x == max);
        }

        private static void Main(string[] args) {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            Convert.ToInt64(Console.ReadLine());

            var ar = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt64);
            long result = BirthdayCakeCandles(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}