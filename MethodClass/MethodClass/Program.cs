using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Math mymath = new Math(); // This calls in the class "Math" and naming the var mymath
            
           
            Console.WriteLine("User, please enter a number you want to perform a math function with..");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("User, please enter another number..");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            int addition = mymath.Add(userInput1, userInput2); // Calls in the Add method   

            Console.WriteLine("Your number added by itself equals: " + addition + " and the number entered is:  " + userInput2);
        }
    }
}
