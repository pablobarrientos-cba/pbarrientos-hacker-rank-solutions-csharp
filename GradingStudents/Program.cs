using System;
using System.Collections.Generic;

namespace GradingStudents
{
    internal static class Result
    {

        /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

        public static IEnumerable<int> GradingStudents(IEnumerable<int> grades)
        {
            var result = new List<int>();
            
            foreach (var grade in grades)
            {
                var finalGrade = grade;
                if (grade >= 38 && grade % 5 >= 3)
                {
                    finalGrade = grade + 5 - grade % 5;
                }
                result.Add(finalGrade);
            }

            return result;
        }
    }

    public static class Solution
    {
        public static void Main(string[] args)
        {
            var gradesCount = Convert.ToInt32(Console.ReadLine());

            var grades = new List<int>();

            for (var i = 0; i < gradesCount; i++)
            {
                var gradesItem = Convert.ToInt32(Console.ReadLine());
                grades.Add(gradesItem);
            }

            var result = Result.GradingStudents(grades);
            foreach (var grade in result)
            {
                Console.WriteLine(grade);
            }
        }
    }
}