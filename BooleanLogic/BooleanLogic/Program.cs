using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boolean Logic");

            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            int a = yourAge;


            Console.WriteLine("Have you ever had a DUI? true or false?");
            string duiTrue = Console.ReadLine();


            Console.WriteLine("How many speeding tickets do you have?");
            int yourTickets = Convert.ToInt32(Console.ReadLine());
            int c = yourTickets;


            Console.WriteLine("Qualified?");
            bool qualified = (a > 21 && duiTrue == "false" && c < 3);
            Console.WriteLine(qualified);
        }
    }
}
