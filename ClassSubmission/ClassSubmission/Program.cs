using System;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User, please enter a number.");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            Math output = new Math();
            output.IntOut(inputNumber);
        }
    };
    class Math
    {
        public void IntOut(int inputNumber)
        {
            int sum = (inputNumber / 2);
            Console.WriteLine("Your number divided by 2 is: " + sum);
            Console.ReadLine();
        }
    }

}
