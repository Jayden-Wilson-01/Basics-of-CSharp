/* Lesson 10 - Exercises
 * Jayden Wilson
 * 25 Oct 2024
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson10
{
    public static class Exercises
    {
        /// <summary>
        /// A method to write times table to a text file 
        /// </summary>
        public static void Write()
        {
            try
            {
                // Create a new text file called Timestable
                using(StreamWriter sw = new StreamWriter("Timestable.txt"))
                {
                    // Write the 5 times table from 1 to 12 to text file
                    for (int number = 0; number < 12; number++)
                    {
                        int result = number * 5;
                        sw.Write(result);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// A method to read times table to console
        /// </summary>
        public static void Read()
        {
            try
            {
                // Open the text file called Timestable
                using (StreamReader sr = new StreamReader("Timestable.txt"))
                {
                    do
                    {
                        // Read current line from text file
                        string line = sr.ReadLine();

                        // If line is not empty then write it to console
                        if (line != null)
                        {
                            Console.WriteLine(line);
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (true);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
