/* Lesson 8 - Exercises
 * Jayden Wilson
 * 24 Oct 2024
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson8
{
    public static class Exercises
    {
        /// <summary>
        /// Method to add a string to existing array
        /// </summary>
        public static void AddArray()
        {
            string[] array = { "Jayden", "Alex", "Sarah" };
            string stringToAdd = "Taylor"; 

            // Gets length of current array
            int originalArrayLength = array.Length;

            // Adds 1 more space to array
            Array.Resize(ref array, originalArrayLength + 1);

            // Fill new space with string value
            array[originalArrayLength] = stringToAdd;
        }

        /// <summary>
        /// Method to remove a value from existing array
        /// </summary>
        public static void RemoveArray()
        {
            string[] oldArray = { "Jayden", "Alex", "Sarah" };
            int indexToRemove = 3;

            // Get length of old array
            int oldArrayLength = oldArray.Length;

            //make new array 1 value smaller than old array
            string[] newArray = new string[oldArrayLength - 1];

            //Copy old array to new array
            Array.Copy(oldArray, 0, newArray, 0, indexToRemove);

            //Check if index is less than max index in array
            if (indexToRemove < (oldArrayLength - 1))
            {
                //Copy old array to new array and remove specific value using index
                Array.Copy(oldArray, indexToRemove + 1, newArray, indexToRemove, oldArrayLength - indexToRemove - 1);
            }

            //Displays all values in the array using foreach loop
            foreach (string value in newArray)
            {
                Console.WriteLine(value);
            }
        }

        /// <summary>
        /// A method to calculate average for number sin an array
        /// </summary>
        public static void ArrayAverage()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sum = 0;
            double average = 0;

            // Loop through each item and add it to sum
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            // Calculate average of the numbers in the array
            average = sum / numbers.Length;

            // Display average
            Console.WriteLine($"Average: {average}");
        }
    }
}
