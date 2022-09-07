using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Math add = new Math(); // Instantiating class

            add.Sum(6 , 4); //calls the method normally
            add.Sum(a: 6, b: 4); //calls the method specifying the parameters by name
        }
    };

    class Math
    {
        public void Sum(int a, int b) // Add method will take in inputNumber from user
        {
            int adding = a + a; 
            Console.WriteLine("Here's a number: " + b);
            Console.ReadLine();
        }
    }
}

