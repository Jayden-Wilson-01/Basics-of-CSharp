/* Lesson 6 - Extra Exercises
 * Jayden Wilson
 * 24 Oct 2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson6
{
    public static class ExtraExercises
    {
        /// <summary>
        /// Display the odd numbers from 0 to 24
        /// </summary>
        public static void OddNumber()
        {
            int loopEnd = 24;
            int loopCount = 0;

            // Loop until the current loop count is 24
            while (loopCount <= loopEnd)
            {
                // If current number divided by 2 does have a remainder then its odd
                if (loopCount % 2 != 0)
                {
                    Console.WriteLine(loopCount);
                }

                // Add 1 to loop count 
                loopCount++;
            }
        }

        /// <summary>
        /// Display the even numbers from 24 to 0 
        /// </summary>
        public static void EvenNumberReversed()
        {
            int loopEnd = 0;
            int loopCount = 24;

            // Loop until the current loop count is 24
            while (loopCount >= loopEnd)
            {
                // If current number divided by 2 does have a remainder then its even
                if (loopCount % 2 == 0)
                {
                    Console.WriteLine(loopCount);
                }

                // Take away 1 to loop count 
                loopCount--;
            }
        }

        /// <summary>
        /// Find the total amount of a specific letter in a string on text
        /// </summary>
        public static void Letters()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            int totalCharactersFound = 0;

            int textLength = text.Length; // Gets total length of text

            for(int i = 0; i < textLength; i++)
            {
                // Gets current character from text 
                char currentCharacter = text[i];

                // If the current character is 'a' then add 1 to total characters found
                if(currentCharacter ==  'a')
                {
                    totalCharactersFound++;
                }
            }
        }

        /// <summary>
        /// Check if entered number is even or odd
        /// </summary>
        public static void OddEvenNumber()
        {
            do
            {
                // Get number from user
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                // If number has no remainder when divided by two ist even otherwise its odd
                if(number %  2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("odd");
                }
            }
            while (true);

        }

        /// <summary>
        /// Ask user to guess a random number and display the corresponding 
        /// message depending if the guess is too high, too low or correct
        /// </summary>
        public static void GuessNumber()
        {
            int number = new Random().Next(1, 100); // Generates a random number from 1 to 100

            do
            {
                // Get guess from user
                Console.Write("Enter your guess: ");
                int guess = int.Parse(Console.ReadLine());

                // Display the correct message depending if the guess is too high, too low or correct 
                if (guess > number)
                {
                    Console.WriteLine($"{guess} is too high");
                }
                else if (guess < number)
                {
                    Console.WriteLine($"{guess} is too low");
                }
                else if (guess == number)
                {
                    Console.WriteLine($"Well done {guess} is correct");
                    break;
                }
            }
            while(true);
        }
    }
}
