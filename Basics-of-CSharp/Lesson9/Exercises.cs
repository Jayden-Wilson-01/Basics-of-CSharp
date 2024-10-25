/* Lesson 9 - Exercises
 * Jayden Wilson
 * 25 Oct 2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson9
{
    public static class Exercises
    {
        /// <summary>
        /// A method to get numbers
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private static int GetNumber(string message)
        {
            do
            {
                try
                {
                    Console.WriteLine(message);
                    int number = int.Parse(Console.ReadLine());
                    return number;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while(true);
        }

        /// <summary>
        /// A method to add two numbers with error handling
        /// </summary>
        public static void Calculator()
        {
            int number1 = GetNumber("Enter first number: ");
            int number2 = GetNumber("Enter second number: ");

            try
            {
                // Add numbers
                int result = number1 + number2;
                Console.WriteLine($"{number1} + {number2} = {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
