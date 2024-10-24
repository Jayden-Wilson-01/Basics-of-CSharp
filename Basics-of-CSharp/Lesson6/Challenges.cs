/* Lesson 6 - Challenges
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
    public static class Challenges
    {
        /// <summary>
        /// A method used to countdown from 10 to 0
        /// </summary>
        public static void Countdown()
        {
            //Loop that prints a countdown from 10 to 0 
            for (int number = 10; number > 0; number--)
            {
                Console.Beep(); //Makes a beep sound
                Console.WriteLine(number);

                //1 Second Delay
                Thread.Sleep(1000);
            }

            Console.WriteLine("Blast Off!!!!");
        }

        // <summary>
        /// A method used to show times table but loops until user enters 99 to exit
        /// </summary>
        public static void TimesTableExtended()
        {
            do
            {
                // Ask user for base number 
                Console.Write("Enter base number or enter 99 to exit: ");
                int baseNumber = int.Parse(Console.ReadLine());
                

                // Check if number 99 was entered
                if(baseNumber == 99)
                {
                    Console.WriteLine("Stopped Application");
                    break;
                }

                // Loop that multiplies each number from 1 to 12 by the base number
                for(int i = 0; baseNumber <= 12; i++)
                {
                    int result = i * baseNumber;
                    Console.WriteLine($"{i} x {baseNumber} = {result}");
                }
            }
            while(true);
        }
    }
}
