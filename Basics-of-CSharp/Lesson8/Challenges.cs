/* Lesson 8 - Challenges
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
    public static class Challenges
    {
        /// <summary>
        /// A method used to compare two arrays
        /// </summary>
        public static void CompareArrays()
        {
            int[] firstArray = new int[] { 1, 5, 6, 32, 7, 3, 1, 6, 80, 255 };
            int[] secondArray = new int[] { 8, 6, 80, 6, 4, 32, 65, 7, 8, 259 };
            Compare(firstArray, secondArray);
        }

        /// <summary>
        /// A meth dto see if both arrays given are similar or different or somewhat similar
        /// </summary>
        /// <param name="firstArray">The first array to compare</param>
        /// <param name="secondArray">The second array to compare</param>
        private static void Compare(int[] firstArray, int[] secondArray)
        {
            // Sort Arrays
            Array.Sort(firstArray);
            Array.Sort(secondArray);

            // Track how many items are similar
            int similarItemsCount = 0;

            // Loop through each item
            for (int i = 0; i < firstArray.Length; i++)
            {
                int comparison = firstArray[i].CompareTo(secondArray[i]);

                //if(firstArray[i] == secondArray[i])
                //{
                //    similarItemsCount++;
                //}

                // if 0 then both are similar so add to the count
                if(comparison == 0)
                {
                    similarItemsCount++;
                }
            }

            // Determine if the arrays are different, somewhat similar, or similar
            if(similarItemsCount == 0)
            {
                Console.WriteLine("None are similar");
            }
            else if(similarItemsCount > 0 && similarItemsCount < firstArray.Length)
            {
                Console.WriteLine("Some are similar");
            }
            else if(similarItemsCount == firstArray.Length)
            {
                Console.WriteLine("All are similar");
            }
        }
    }
}
