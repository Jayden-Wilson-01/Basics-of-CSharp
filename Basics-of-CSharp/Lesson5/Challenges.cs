/* Lesson 5 - Challenges
 * Jayden Wilson
 * 23 Oct 2024
 */

using System;
using System.Runtime.CompilerServices;

namespace Basics_of_CSharp.Lesson5
{
    public static class Challenges
    {
        /// <summary>
        /// A method used to display total cost of shopping and shipping
        /// </summary>
        public static void Shipping()
        {
            // Variables
            double total = 0;
            double shoppingTotal = 0;
            double normalShippingCost = 10;
            double expressShippingCost = 15;
            bool expressShipping = true;

            // Get shopping cost from user
            Console.Write("Enter shopping total: ");
            shoppingTotal = int.Parse(Console.ReadLine());

            // Ask if user wants express shipping
            Console.Write("Do you want express shipping? (true|false)");
            expressShipping = bool.Parse(Console.ReadLine());

            // If no express shipping is equal to true
            if (expressShipping == false)
            {
                // If shopping is more than £50 its free if any less they need to pay the normal shipping cost
                if(shoppingTotal > 50)
                {
                    total = shoppingTotal;
                    Console.WriteLine("You qualify for free delivery");
                }
                else
                {
                    // Total cost including normal shipping
                    total = shoppingTotal + normalShippingCost;
                    Console.WriteLine($"You need to pay {normalShippingCost} as your shopping is less than £50");
                }
            }
            else
            {
                // Total cost including express shipping
                total = shoppingTotal + expressShippingCost;
                Console.WriteLine($"You need to pay {normalShippingCost} as you asked for express shipping");
            }

            Console.WriteLine($"Your final total including shipping is {total:C2}");
        }

        /// <summary>
        /// A method to see what amount of tax you need to pay
        /// </summary>
        public static void SalesTax()
        {
            double taxes = 0;
            double total = 0;
            string province = "";
            string country = "";

            Console.Write("What country do you live in? ");
            country = Console.ReadLine();

            //Checks if country is Canada
            if (country == "Canada")
            {
                Console.Write("What province? ");
                province = Console.ReadLine();

                //Checks users province
                if (province == "Alberta")
                {
                    taxes = 5; //Changes tax amount
                }
                else if (province == "Ontario" || province == "New Brunswick" || province == "Nova Scoti")
                {
                    taxes = 13; //Changes tax amount
                }
                else
                {
                    taxes = 11; //Changes tax amount
                }
            }
            else
            {
                taxes = 0; //Changes tax amount
            }

            Console.Write("What is the total order cost ");
            double orderCost = int.Parse(Console.ReadLine());

            //Calculates total cost including tax
            total = orderCost + orderCost * (taxes / 100);

            Console.WriteLine($"\nTotal cost including taxes: {total:C2}");
        }
    }
}
