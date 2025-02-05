/* Lesson 8 - Revision
 * Jayden-James Wilson
 * 29/01/2025
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson8
{
    public static class Revision
    {
        public static void MainLesson8()
        {
            string[] names = { };
           
            //Ad name to array
            names = ReadNames();

            Console.WriteLine("Entered Names: ");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int index = IndexOf(names, "fred");
            Console.WriteLine($"Index of \"fred\": {index}");
        }

        /// <summary>
        /// Method to print first and last names from an array
        /// </summary>
        private static void Exercise1()
        {
            //Array
            string[] names = { "Daniel", "Sean", "Brad", "Stuart", "Angus" };

            //Results
            Console.WriteLine(names[0]);
            Console.WriteLine(names[names.Length - 1]);
        }

        /// <summary>
        /// Method to print all from an array
        /// </summary>
        private static void Exercise2()
        {
            //Array
            string[] names = { "Daniel", "Sean", "Brad", "Stuart", "Angus" };

            //For loop
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine();

            //Foreach loop
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Method to add values to array and print them
        /// </summary>
        private static void Exercise3()
        {
            int[] numbers = new int[10];

            //For loop to add numbers to array
            for(int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = index;
            }

            Console.WriteLine("Foreach Loop:");
            //Foreach loop to display numbers in array
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }

        /// <summary>
        /// Method to add values to array and print them
        /// </summary>
        private static string[] ReadNames()
        {
            string[] array = { };

            do
            {
                Console.Write("Enter a name (DONE to stop): ");
                string name = Console.ReadLine();

                if (name != "DONE")
                {
                    array = AddToStringArray(array, name);
                }
                else
                {
                    break;
                }
            }
            while (true);

            return array;
        }

        private static string[] AddToStringArray(string[] theArray, string newString) 
        { 
            int origLength = theArray.Length; 
            Array.Resize(ref theArray, origLength + 1); 
            theArray[origLength] = newString; return theArray; 
        }

        static int IndexOf(string[] array, string toFind)
        {
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == toFind)
                {
                    return index;
                }
                else
                {
                    return -1;
                }
            }

            return -1;
        }
    }
}
