/* Lesson 5 - Exercises
 * Jayden Wilson
 * 23 Oct 2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson5
{
    public static class Exercises
    {
        /// <summary>
        /// A method used to add two numbers
        /// </summary>
        public static void Sum()
        {
            Console.Write("What is 3 + 4? ");
            int answer = int.Parse(Console.ReadLine());

            // Check if inputted answer is correct
            if(answer == 7)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine("Test complete");
        }

        /// <summary>
        /// A method to see what prize a user wins with their deposit
        /// </summary>
        public static void Deposit()
        {
            Console.Write("How much would you like to deposit? ");
            int deposit = int.Parse(Console.ReadLine());

            // Check if deposit is over 100
            if(deposit > 100)
            {
                Console.WriteLine("You get a free toaster!");
            }
            else
            {
                Console.WriteLine("Enjoy your mug?");
            }
        }

        /// <summary>
        /// A method used to see if a user can retire after winning the lottery
        /// </summary>
        public static void Lottery()
        {
            double bigWin = 1000000;

            Console.Write("Did you win the lottery? (true|false) ");
            bool wonLottery = bool.Parse(Console.ReadLine());

            //Checks to see if you did win the lottery
            if (wonLottery == true)
            {
                Console.Write($"Did you win big. over {bigWin:C2}. (true|false) ");
                bool wonBigWin = bool.Parse(Console.ReadLine());

                //Checks if you won the lottery and it was a big win
                if (wonLottery == true && wonBigWin == true)
                {
                    Console.WriteLine("You can retire.");
                }
                else
                {
                    Console.WriteLine("You cannot retire.");
                }
            }
            else
            {
                Console.WriteLine("You cannot retire.");
            }
        }

        /// <summary>
        /// A method to see if you live in Canada and what pet you have
        /// </summary>
        public static void Animals()
        {
            Console.Write("Country: ");
            string country = Console.ReadLine();

            Console.Write("Pet: ");
            string pet = Console.ReadLine();

            //Checks if country is Canada and if moose or beaver is the pet 
            if (country == "CANADA" && (pet == "MOOSE" || pet == "BEAVER")) //Treats it as separate statements
            {
                Console.WriteLine("Do you play hocky too?");
            }
        }
    }
}
