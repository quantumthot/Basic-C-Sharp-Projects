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



            Console.WriteLine("User, please enter a whole number you want to perform a math function with..");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int addition = mymath.Add(userInput); // Calls in the Add method
            Console.WriteLine("Your number added by itself equals: " + addition);



            Console.WriteLine("User, please enter a decimal you want to perform a math function with..");
            string userInput1 = (Console.ReadLine()); //(Console.ReadLine() , out decimal);
            double val = Convert.ToDouble(userInput1); // Converting to decimal

            float squared = mymath.Square(val); // Calls in the squared method
            Console.WriteLine("Your number multiplied by itself equals: " + squared);


            Console.WriteLine("User, please enter a word you want to perform a math function with..");
            string userInput2 = Console.ReadLine(); //(Console.ReadLine() , out decimal);
            int length = userInput2.Length; // using string length as number for division


            int division = mymath.Divide(length); // Calls in the squared method
            Console.WriteLine("Your number divided by itself equals: " + division);
        }
    }
}