/* Lesson 7 - Challenges
 * Jayden Wilson
 * 24 Oct 2024
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Basics_of_CSharp.Lesson7
{
    public static class Challenges
    {
        /// <summary>
        /// A method to get an decimal value from user
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private static double GetValue(string message)
        {
            Console.Write($"Please enter {message}: ");
            return int.Parse(Console.ReadLine());   
        }

        /// <summary>
        /// A method to calculate the total pay for a user
        /// </summary>
        /// <returns>The total pay of an employee</returns>
        private static double CalculatePay()
        {
            // Get hours worked
            double hoursWorked = GetValue("hours worked");

            // Get rate of pay
            double rateOfPay = GetValue("rate of Pay");

            double totalPay = 0;
            double baseHours = 40;

            // Anything over the base hours is overtime
            double hoursOvertime = hoursWorked - baseHours;
            
            // If the hours worked is over the base (so there is overtime) 
            if(hoursWorked > baseHours)
            {
                // Calculate the total pay and then add overtime pay
                return totalPay = (baseHours * rateOfPay) + (hoursOvertime * (rateOfPay * 1.5));
            }
            else
            {
                // Calculate total pay if there is no overtime to add
                return hoursWorked * rateOfPay; 
            }
        }

        /// <summary>
        /// A method to display the pay of a user
        /// </summary>
        public static void DisplayPay()
        {
            double totalPay = CalculatePay();
            Console.WriteLine($"Total pay is {totalPay:C2}");
        }
    }
}
