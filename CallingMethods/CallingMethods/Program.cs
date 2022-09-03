using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("User, please enter a number you want to perform a math function with..");
        int userInput = Convert.ToInt32(Console.ReadLine());

        Math mymath = new Math(); // This calls in the class "Math" and naming the var mymath

        int addition = mymath.Add(userInput); // Calls in the Add method
        Console.WriteLine("Your number added by itself equals: " + addition);

        int divide = mymath.Divide(userInput); // Calls in the divide method
        Console.WriteLine("Your number divided by itself equals: " + divide);

        int squared = mymath.Square(userInput); // Calls in the square method
        Console.WriteLine("Your number squared by itself equals: " + squared);
        Console.ReadLine();
        }
    }
}