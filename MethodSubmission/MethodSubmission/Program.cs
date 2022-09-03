using System;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mymath = new Math(); // This calls in the class "Math" and naming the var mymath


            Console.WriteLine("User, please enter a number you want to perform a math function with..");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("User, do you want to enter a second number to perform a math function with? Enter \"y\" or \"n\" ?..");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.WriteLine("User, please enter a second number you want to perform a math function with..");
                int userInput2 = Convert.ToInt32(Console.ReadLine());
                int addition = mymath.Add(userInput1, userInput2); // Calls in the Add method
                Console.WriteLine("{0} added by {1} equals: " + addition, userInput1, userInput2);
            }
            else
            {
                int userInput3 = 0;
                int addition = mymath.Add(userInput1, userInput3);
                Console.WriteLine("{0} added to {1} equals: " + addition, userInput1, userInput3);
            }
        }
    }
}
