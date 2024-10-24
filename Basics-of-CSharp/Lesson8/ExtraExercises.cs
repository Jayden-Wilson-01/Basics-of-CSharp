/* Lesson 8 - ExtraExercises
 * Jayden Wilson
 * 24 Oct 2024
 */


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson8
{
    public static class ExtraExercises
    {
        public static void MinArrayValue()
        {
            int[] numbers = { 44, 38, 37, 30, 26, 22, 3, 889 };

            int minValue = int.MaxValue; // Set the minimum to be the max

            // Gets current number from array
            for (int i = 0; i < numbers.Length; i++)
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
