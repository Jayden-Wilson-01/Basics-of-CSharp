/* Lesson 4 - Extra Exercises
 * Jayden Wilson
 * 12 Oct 2024
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson4
{
    public static class ExtraExercises
    {
        /// <summary>
        /// A method to add two numbers and display result to console.
        /// </summary>
        public static void Adding()
        {
            int first = 0;
            int second = 0;

            //Asks and gets first number from user
            Console.Write("Enter first number: ");
            first = int.Parse(Console.ReadLine());

            //Asks and gets second number from user
            Console.Write("Enter second number: ");
            second = int.Parse(Console.ReadLine());

            //Outputs answer to console
            Console.WriteLine($"{first} + {second} = {first + second}");
        }

        /// <summary>
        /// A method to divide two numbers and display result without remainder to console. 
        /// </summary>
        public static void Dividing()
        {
            float first = 0;
            float second = 0;

            //Asks and gets first number from user
            Console.Write("Enter first number: ");
            first = float.Parse(Console.ReadLine());

            //Asks and gets second number from user
            Console.Write("Enter second number: ");
            second = float.Parse(Console.ReadLine());

            //Outputs answer to console with formatting
            Console.WriteLine($"{first:0.000} / {second:0.000} = {first / second:0.000}");
        }

        /// <summary>
        /// A method to divide two numbers and display result with remainder to console. 
        /// </summary>
        public static void DividingRemainder()
        {
            int first = 0;
            int second = 0;

            //Asks and gets first number from user
            Console.Write("Enter first number: ");
            first = int.Parse(Console.ReadLine());

            //Asks and gets second number from user
            Console.Write("Enter second number: ");
            second = int.Parse(Console.ReadLine());

            //Outputs answer to console
            Console.WriteLine($"{first} / {second} = {first / second} remainder {first % second}");
        }

        /// <summary>
        /// A method to display a circles circumference and area to console. 
        /// </summary>
        public static void Circle()
        {
            float diameter = 0;
            float circumference = 0;
            float area = 0;

            //Asks and gets diameter from user
            Console.Write("Enter diameter of circle (cm): ");
            diameter = float.Parse(Console.ReadLine());

            //Calculates the circumference and area
            circumference = (float)(Math.PI * diameter);
            area = (float)(Math.PI * (Math.Pow(diameter / 2, 2)));

            //Outputs answer to console
            Console.WriteLine($"Circumference of circle (cm): {circumference:0.000}");
            Console.WriteLine($"Area of circle (cm2): {area:0.000}");

        }
    }
}
