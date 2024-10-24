/* Lesson 6 - Exercises
 * Jayden Wilson
 * 24 Oct 2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson6
{
    public static class Exercises
    {
        /// <summary>
        /// A method to show different values after using 
        /// different types of shortcut operations
        /// </summary>
        public static void ShortcutOperations()
        {
            int x = 12;
            int y = 4;
            int z;

            z = x; //Value of z is 12
            Console.WriteLine(z);

            x = z + 4; //Value of x is 16
            Console.WriteLine(x);

            x++; //Adds 1 to x (16 + 1 = 17)
            Console.WriteLine(x);

            y += 2; //Adds 2 to the current value of y (4 + 2 = 6)
            Console.WriteLine(y);

            x -= 3; //Subtracts 3 to the current value of x (17 - 3 = 14)
            Console.WriteLine(x);

            y--; //Subtracts 1 from y (6 - 1 = 5)
            Console.WriteLine(y);

            y = y * 2 + 3; //Multiplies y by 2 then adds 3 ( 5 x 2 = 10 --> 10 + 3 = 13) 
            Console.WriteLine(y);

            z = ++y; //Adds 1 to y and stores it in z. Must add ++ before y as y is not being used.
            Console.WriteLine(z);
        }

        /// <summary>
        /// A method used to print numbers 5 to 15
        /// </summary>
        public static void SimpleLoop()
        {
            //Loop that prints 5 to 15 - Inclusive
            for (int number = 5; number <= 15; number++)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// A method used to show times table
        /// </summary>
        public static void TimesTable()
        {
            Console.Write("What do you want the base number to be? ");

            // Ask user for a base number
            int baseNumber = int.Parse(Console.ReadLine());

            // Loop to multiply base number with 1 - 12
            for (int number = 1; number <= 12; number++)
            {
                int result = number * baseNumber; ;
                Console.WriteLine($"{number} x {baseNumber} = {result}");
            }
        }

        /// <summary>
        /// Display the even numbers from 0 to 24
        /// </summary>
        public static void EvenNumber()
        {
            int loopEnd = 24;
            int loopCount = 0;

            // Loop until the current loop count is 24
            while(loopCount < loopEnd)
            {
                // If current number divided by 2 has no remainder then its even
                if(loopCount % 2 == 0)
                {
                    Console.WriteLine(loopCount);
                }

                // Add 1 to loop count 
                loopCount++;
            }
        }
    }
}
