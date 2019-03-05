using System;

namespace Backend
{
    public static class Task1
    {
        /// <summary>
        /// Prints the 'Stack Overflow' string for the provided input string
        /// </summary>
        /// <param name="inputString"></param>
        public static void PrintStackOverflowString(string inputString)
        {
            Console.WriteLine(GenerateStackOverFlowString(inputString, 2, 4));
        }

        /// <summary>
        /// Method to generate 'Stack Overflow' string for the provided input string based whether its length is divisble
        /// by the provided divisors.
        /// Only divisible by first divisor returns "Stack"
        /// Only divisible by second divisor returns "Overflow"
        /// Divisible by both returns "Stack Overflow!"
        /// 
        /// NOTE: While the task specified hardcoding 2 and 4 as divisors, you'll never get a number divisable by four that isn't 
        ///       also divisable by 2. As such, in that scenario the "Overflow" option is redundant as you'll never have 
        ///       an input string that will produce that result. Therefore, I made the method more generic such that it can 
        ///       produce the "Overflow" result if appropriate divisors are provided. e.g. 2 and 3
        ///       
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="firstDevisor"></param>
        /// <param name="secondDevisor"></param>
        /// <returns>The Generated Stack Overflow sting</returns>
        public static string GenerateStackOverFlowString(string inputString, int firstDevisor, int secondDevisor)
        {
            var inputStringLength = inputString.Length;

            var divisibleByFirstDevisor = IsMultipleOf(inputStringLength, firstDevisor);
            var divisibleBySecondDevisor = IsMultipleOf(inputStringLength, secondDevisor);
            var divisibleByBoth = divisibleByFirstDevisor && divisibleBySecondDevisor;

            if (divisibleByBoth)
            {
                return "Stack Overflow!";
            }
            else if (divisibleBySecondDevisor)
            {
                return "Overflow";
            }
            else if (divisibleByFirstDevisor)
            {
                return "Stack";
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Determines whether the provided numerator is a multiple of the provided denominator
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns>Bool indicating whether provided numerator is a multiple of the provided denominator</returns>
        public static bool IsMultipleOf(int numerator, int denominator)
        {
            return (numerator % denominator) == 0;
        }
    }
}
