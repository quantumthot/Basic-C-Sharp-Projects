using System;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User, please enter a number.");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Math output = new Math(); // Instantiate Math class
            output.IntIn(inputNumber);// Plugs in inputNumber to method IntIn for output
            output.IntOut(out int number); //Ouput for IntOut number
            output.IntOut(out _, out int number1); //Ouput for IntOut number
            Hey.Hello(); // Calls Hello method 
            Console.ReadLine();
        }
    };
    class Math
    {
        public void IntIn(int inputNumber)
        {
            int sum = (inputNumber / 2);
            Console.WriteLine("Your number divided by 2 is: " + sum);
            Console.ReadLine();
        }
        public void IntOut(out int number)
        {
            number = 36;
            Console.WriteLine("Here's a number: " + number);
            Console.ReadLine();
        }

        public void IntOut(out int numbers, out int number1)
        {
            numbers = 18;
            number1 = 23;
            Console.WriteLine("Here's another number: " + number1);
            Console.ReadLine();
        }
    };
    static class Hey
    {
        public static void Hello()
        {

                string message = "This is from my static method.";
                Console.WriteLine(message);

        }
    }
}


