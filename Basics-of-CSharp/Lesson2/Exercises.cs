/* Lesson 2 - Exercises
 * Jayden Wilson
 * 12 Oct 2024
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson2
{
    public static class Exercises
    {
        /// <summary>
        /// A method to display short poem to console.
        /// </summary>
        public static void ShortPoem()
        {
            //Writes lines of text to console
            Console.Write("There once was a princess named Jinx \nwho was asked what she thought of the Sphinx\n");
            Console.Write("She replied with a smile,\n\"That old fraud by the Nile? \nI personally think that she stinks!\" ");
        }

        /// <summary>
        /// A method to display long poem to console.
        /// </summary>
        public static void LongPoem()
        {
            //Writes lines of text to console
            Console.Write("I’m a little teapot, \nshort and stout.\nHere is my handle.\n");
            Console.Write("Here is my spout.\n");
            Console.Write("When I get all steamed up, \nhear me shout\n\"Tip me over and pour me out!\"");
        }
    }
}
