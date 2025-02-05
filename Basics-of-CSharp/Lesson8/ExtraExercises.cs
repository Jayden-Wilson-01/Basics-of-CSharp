/* Lesson 8 - ExtraExercises
 * Jayden Wilson
 * 24 Oct 2024
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson8
{
    public static class ExtraExercises
    {
        /// <summary>
        /// Get the smallest value in an array
        /// </summary>
        public static void MinArrayValue()
        {
            int[] numbers = { 44, 38, 37, 30, 26, 22, 3, 889 };

            int minValue = numbers[0]; // Set the minimum to be the first item

            // Gets current number from array but not the first as its already initialized as the minValue
            for (int i = 1; i < numbers.Length; i++)
            {
                // If current number is less than the current minimum value
                if(numbers[i] < minValue)
                {
                    // Set minimum value to be the current number
                    minValue = numbers[i];
                }
            }

            // Display minimum value
            Console.WriteLine($"Minimum Value: {minValue}");
        }
    }
}
