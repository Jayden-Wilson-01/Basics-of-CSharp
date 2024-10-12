/* Lesson 3 - Exercises
 * Jayden Wilson
 * 12 Oct 2024
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson3
{
    public static class Exercises
    {
        /// <summary>
        /// A method that displays users first and last name to console.
        /// </summary>
        public static void DisplayName()
        {
            //Asks and gets first name from user
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            //Asks and gets last name from user
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            //Outputs users full name to Console
            Console.WriteLine($"{firstName} {lastName}");
        }

        /// <summary>
        /// A method that shows text formatting for text to console.
        /// </summary>
        public static void TextFormatting()
        {
            string message = "Hello World!";

            //Checks to see if the word "World" exists in the message
            Console.WriteLine(message.Contains("World"));

            //Gets first index of 'o'
            Console.WriteLine(message.IndexOf('o'));

            //Outputs the length of the message
            Console.WriteLine(message.Length);

            //Replaces the word "Hello" with "Hi"
            Console.WriteLine(message.Replace("Hello", "Hi"));
        }
    }
}
