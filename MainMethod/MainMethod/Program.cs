using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mymath = new Math(); // This calls in the class "Math" and naming the var mymath


            // Part 1 ///////////////////////////
            Console.WriteLine("User, please enter a whole number you want to perform a math function with..");
            int userInput = Convert.ToInt32(Console.ReadLine());


            int addition = mymath.Add(userInput); // Calls in the Add method
            Console.WriteLine("Your number added by itself equals: " + addition);


            // Part 2 ///////////////////////////
            Console.WriteLine("User, please enter a decimal you want to perform a math function with..");

            decimal val = Convert.ToDecimal(Console.ReadLine()); // Converting to decimal


            decimal squared = mymath.Add(val); // plugs in the squared method
            Console.WriteLine("Your number multiplied by itself equals: " + squared);

            // Part 3 ///////////////////////////
            Console.WriteLine("User, please enter a word you want to perform a math function with..");
            string userInput2 = Console.ReadLine();

            //string length = userInput2; // using string length as number for division

            int division = mymath.Add(userInput2); // Calls in the squared method

            Console.WriteLine("Your word divided by itself equals: " + division);

        }
    }
}