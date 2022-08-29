using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonomous Income Comparison Program");

            Console.WriteLine("Person 1: What is your hourly rate?");
            int yourRate1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 1: Hours worked per week?");
            int yourHours1 = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine("Person 2: What is your hourly rate?");
            int yourRate2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2: Hours worked per week?");
            int yourHours2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 1, your annual salary is:");
            int a = yourRate1;
            int b = yourHours1;
            int c = (a * b * 52);
            Console.WriteLine(c);

            Console.WriteLine("Person 2, your annual salary is:");
            int d = yourRate2;
            int e = yourHours2;
            int f = (d * e * 52);
            Console.WriteLine(f);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(c > f);




        }
    }
}
