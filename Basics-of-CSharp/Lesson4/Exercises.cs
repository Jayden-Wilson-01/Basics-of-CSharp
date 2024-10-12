/* Lesson 4 - Exercises
 * Jayden Wilson
 * 12 Oct 2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_CSharp.Lesson4
{
    public static class Exercises
    {
        /// <summary>
        /// A method to display the minimum and maximum values of most number variable types in c# to console.
        /// </summary>
        public static void MinMax()
        {
            //Signed Integers
            Console.WriteLine("Signed Integers");
            Console.WriteLine($"Int Max: {int.MaxValue}");
            Console.WriteLine($"Int Min: {int.MinValue}");
            Console.WriteLine($"short Max: {short.MaxValue}");
            Console.WriteLine($"short Min: {short.MinValue}");
            Console.WriteLine($"Sbyte Max: {sbyte.MaxValue}");
            Console.WriteLine($"Sbyte Min: {sbyte.MinValue}");
            Console.WriteLine($"long Max: {long.MaxValue}");
            Console.WriteLine($"long Min: {long.MinValue}");
            Console.WriteLine("");

            //Unsigned Integers
            Console.WriteLine("Unsigned Integers");
            Console.WriteLine($"Uint Max: {uint.MaxValue}");
            Console.WriteLine($"Uint Min: {uint.MinValue}");
            Console.WriteLine($"Ushort Max: {ushort.MaxValue}");
            Console.WriteLine($"Ushort Min: {ushort.MinValue}");
            Console.WriteLine($"byte Max: {byte.MaxValue}");
            Console.WriteLine($"byte Min: {byte.MinValue}");
            Console.WriteLine($"Ulong Max: {ulong.MaxValue}");
            Console.WriteLine($"Ulong Min: {ulong.MinValue}");
            Console.WriteLine("");

            //Other Integers
            Console.WriteLine("Other Integers");
            Console.WriteLine($"float Max: {float.MaxValue}");
            Console.WriteLine($"float Min: {float.MinValue}");
            Console.WriteLine($"decimal Max: {decimal.MaxValue}");
            Console.WriteLine($"decimal Min: {decimal.MinValue}");
            Console.WriteLine($"double Max: {double.MaxValue}");
            Console.WriteLine($"double Min: {double.MinValue}");
        }

        /// <summary>
        /// A method to show simple math calculations to console.
        /// </summary>
        public static void SimpleMath()
        {
            //12 x 45
            Console.WriteLine($"12 x 45 = {12 * 45}");

            //10 / 3 
            Console.WriteLine($"10 / 3 = {10 / 3}");

            //10 / 3 
            Console.WriteLine($"10 / 3 = {10d / 3d:f3}");

            //Remainder of 10 / 3
            Console.WriteLine($"Remainder of 10 / 3 = {10 % 3}");

            //32768 + 512
            Console.WriteLine($"32768 + 512 = {32768 + 512}");

            //16384 - 4431
            Console.WriteLine($"16384 - 4431 = {16384 - 4431}");

            //64 ^ 3
            Console.WriteLine($"64 ^ 3 = {Math.Pow(64, 3)}");
        }

        /// <summary>
        /// A method to display a total salary to console. 
        /// </summary>
        public static void Salary()
        {
            //Asks and gets salary from user
            Console.Write("Please enter your salary: ");
            int salary = int.Parse(Console.ReadLine());

            //Asks and gets bonus from user
            Console.Write("Please enter your bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            //Displays total to console in currency format
            Console.WriteLine($"Total: {salary + bonus:C2}");
        }
    }
}
