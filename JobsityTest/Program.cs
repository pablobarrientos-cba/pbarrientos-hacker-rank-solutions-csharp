﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace JobsityTest
{
    public static class Result
    {
        /*
     * Complete the 'calculatePostfix' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY expressions as parameter.
     */
        private static readonly Dictionary<string, Func<decimal, decimal, decimal>> Evaluations =
            new Dictionary<string, Func<decimal, decimal, decimal>>()
            {
                ["+"] = (arg1, arg2) => arg1 + arg2,
                ["-"] = (arg1, arg2) => arg1 - arg2,
                ["*"] = (arg1, arg2) => arg1 * arg2,
                ["/"] = (arg1, arg2) => arg1 / arg2
            };

        public static IEnumerable<string> CalculatePostfix(IEnumerable<string> expressions)
        {
            return expressions.Select(Calculate).ToList();
        }

        private static string Calculate(string expression)
        {
            var aux = expression.Split(' ');
            var nums = new Queue<int>();
            var operands = new Queue<string>();

            // extract two arrays: one for numbers, one for operands
            foreach (var item in aux)
            {
                if (item.Equals("-") ||
                    item.Equals("+") ||
                    item.Equals("*") ||
                    item.Equals("/"))
                {
                    operands.Enqueue(item);
                }
                else
                {
                    nums.Enqueue(int.Parse(item));
                }
            }

            var individualResult = EvalExpression(0, nums, operands);

            return individualResult.ToString(CultureInfo.InvariantCulture);
        }

        private static decimal EvalExpression(decimal number, Queue<int> numStack, Queue<string> operationStack)
        {
            var result = number;

            if (numStack.Count == 0 && operationStack.Count == 0) return result;

            if (number == 0)
            {
                var a = Convert.ToDecimal(numStack.Dequeue());
                var b = Convert.ToDecimal(numStack.Dequeue());

                var operand = operationStack.Dequeue();

                result = Evaluations[operand](a, b);
            }
            else
            {
                result = number;
                var b = Convert.ToDecimal(numStack.Dequeue());
                var operand = operationStack.Dequeue();

                result = Evaluations[operand](result, b);
            }

            return EvalExpression(result, numStack, operationStack);
        }
    }

    internal static class Solution
    {
        public static void Main(string[] args)
        {
            var expressions = new List<string>();
            bool stopReading;
            do
            {
                var expressionsItem = Console.ReadLine();
                stopReading = (expressionsItem == "q");
                if (!stopReading)
                {
                    expressions.Add(expressionsItem);
                }
            } while (!stopReading);

            var result = Result.CalculatePostfix(expressions);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}