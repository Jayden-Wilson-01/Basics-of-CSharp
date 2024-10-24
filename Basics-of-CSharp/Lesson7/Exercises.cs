/* Lesson 7 - Exercises
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
    public static class Exercises
    {
        /// <summary>
        /// Make a message by combining greeting, first and last name
        /// </summary>
        /// <param name="greeting"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public static void Greeting(string greeting, string firstName, string lastName)
        {
            Console.WriteLine($"{greeting}, {firstName} {lastName}");
        }
    }
}
