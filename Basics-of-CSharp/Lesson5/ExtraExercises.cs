using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson5
{
    public static class ExtraExercises
    {
        /// <summary>
        /// A method to determine if you are still at school 
        /// or retired determined by your age
        /// </summary>
        public static void Age()
        {
            Console.Write("What is your age. ");
            int age = int.Parse(Console.ReadLine());

            //Checks if age is less than 16
            if (age < 16)
            {
                Console.WriteLine("You are still at school");
            }

            //Checks if age is more than 66
            else if (age > 66)
            {
                Console.WriteLine("You are retired, lucky you!");
            }
        }

        /// <summary>
        /// A method to see if a number is positive or negative
        /// </summary>
        public static void PositiveNegative()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            //Checks if number is less than 0
            if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number");
            }

            //Checks if number is more than 0
            else if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number");
            }
        }

        /// <summary>
        /// A method to display highest number from array
        /// </summary>
        public static void HighestValue()
        {
            int highestNumber = 0;
            int[] numbers = new int[] {3,6,3,8,77,1,2,22,5,6,22,88,33,88,45}; //Array that stores 3 numbers

            // Loop 3 times
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > highestNumber)
                {
                    highestNumber = numbers[i];
                }
            }

            Console.WriteLine($"Highest number is {highestNumber}");
        }
    }
}
