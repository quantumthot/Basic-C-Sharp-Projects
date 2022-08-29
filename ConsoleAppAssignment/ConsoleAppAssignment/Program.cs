using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console APP Assignment");

            // do statement
            int i = 0; // initialization

            while (i < 10) // condition
            {
                Console.WriteLine("i = {0}", i);

                i++; // increment
            }

            // do while statement
            int x = 0;
            do
            {
                Console.WriteLine(x); // this will count from 0 - 9, when it hits 10 the program will end
                x++;
            } while (x < 10);
        }
    }
}
