/* Lesson 3 - Extra Exercises
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
    public static class ExtraExercises
    {
        /// <summary>
        /// A method to display a small story to console.
        /// </summary>
        public static void SmallStory()
        {
            //Asks and gets first name of user
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            //Uppercase first letter and makes the rest lowercase
            firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();


            //Asks and gets users favourite colour
            Console.Write("What is your favourite colour? ");
            string favouriteColour = Console.ReadLine();

            //Uppercase first letter and makes the rest lowercase
            favouriteColour = favouriteColour.Substring(0, 1).ToUpper() + favouriteColour.Substring(1).ToLower();


            //Asks and gets users favourite food
            Console.Write("What is your favourite food? ");
            string favouriteFood = Console.ReadLine();

            //Lowercase all letters
            favouriteFood = favouriteFood.ToLower();

            //Outputs small story to Console
            Console.WriteLine($"{firstName} ate a {favouriteColour} {favouriteFood}");
        }

        /// <summary>
        /// A method used to correctly format users name and displays result to console.
        /// </summary>
        public static void Casing()
        {
            //Asks and gets first name of user
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            //Uppercase the first letter and makes the rest lowercase
            firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();

            //Asks and gets name of user
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            //Uppercase first letter and makes rest lowercase
            lastName = lastName.Substring(0, 1).ToUpper() + lastName.Substring(1).ToLower();

            //Outputs full name to Console
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
