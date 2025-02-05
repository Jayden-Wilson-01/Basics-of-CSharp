/* Lesson 7 - ExtraExercises
 * Jayden Wilson
 * 24 Oct 2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson7
{
    public static class ExtraExercises
    {
        #region Sum
        /// <summary>
        /// A method to get an int value from user
        /// </summary>
        /// <param name="message">The prompt for the user</param>
        /// <returns>The int value inputted by user</returns>
        private static int GetValue(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Method to add two values and display result
        /// </summary>
        public static void Sum()
        {
            //Write message and return number
            int number1 = GetValue("Enter first number: ");
            int number2 = GetValue("Enter second number: ");

            //Add numbers
            int sum = number1 + number2;

            //Display result
            Console.WriteLine($"{number1} + {number2} = {sum}");
        }
        #endregion

        #region Circle

        /// <summary>
        /// method to Calculate Circumference 
        /// </summary>
        /// <param name="radius">The radius of the circle</param>
        /// <returns>The circumference of a circle</returns>
        private static double CalcCircumference(double radius)
        {
            //Return the circumference of circle using radius
            double circumference = (2 * Math.PI * radius);
            return circumference;
        }

        /// <summary>
        /// method to Calculate Area 
        /// </summary>
        /// <param name="radius">The radius of the circle</param>
        /// <returns>The area of a circle</returns>
        private static double CalcArea(double radius)
        {
            //Return the area of circle using radius
            double area = (Math.PI * Math.Pow(radius, 2));
            return area;
        }

        /// <summary>
        /// A method to display a circles circumference and area
        /// </summary>
        public static void Circle()
        {
            //Ask user for radius
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());

            //Return values for circumference and area of circle
            double circumference = CalcCircumference(radius);
            double area = CalcArea(radius);

            //Display result
            Console.WriteLine($"Circumference = {circumference:F2}");
            Console.WriteLine($"Area = {area:F2}");
        }
        #endregion

        #region Prime Numbers - Not sure how it works
        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="max">The max number to check</param>
        /// <returns>True if the number is prime or false if it is not prime</returns>
        private static bool IsPrime(int max)
        {
            if (max == 1)
            {
                return false;
            }

            // Check if 'max' (current number) is prime by testing if there is no remainder
            // with every number from 2 to current number if not then number is not a prime number
            for (int i = 2; i < max; i++)
            {
                if (max % i == 0)
                {
                    return false; // Not Prime
                }
            }
            return true;
        }

        /// <summary>
        /// Check if each number from 1 to 100 is a prime number
        /// </summary>
        public static void Prime()
        {
            for (int i = 1; i < 100; i++)
            {
                if (IsPrime(i) == true)
                {
                    Console.Write($"{i}, ");
                }
            }
        }
        #endregion
    }
}
