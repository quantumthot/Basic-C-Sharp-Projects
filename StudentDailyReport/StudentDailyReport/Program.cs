using System;

namespace StudentDailyReport
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); // This displays the string in the parenthesis
            Console.WriteLine("Student Daily Report");// This displays the string in the parenthesis

            Console.WriteLine("What is your name?");// This displays the string in the parenthesis
            string yourName = Console.ReadLine(); // will store a string.

            Console.WriteLine("What course are you on?");// This displays the string in the parenthesis
            string yourCourse = Console.ReadLine();// will store a string.

            Console.WriteLine("What page number?");// This displays the string in the parenthesis
            int yourPage = Convert.ToInt32(Console.ReadLine());// will store as an int
       
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");// This displays the string in the parenthesis
            bool yourHelp = Convert.ToBoolean(Console.ReadLine());// will store a bool

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");// This displays the string in the parenthesis
            string yourExperience = Console.ReadLine();// will store a string.

            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");// This displays the string in the parenthesis
            string yourFeedback = Console.ReadLine();// will store a string.

            Console.WriteLine("How many hours did you study today?");// This displays the string in the parenthesis
            int yourHours = Convert.ToInt32(Console.ReadLine());// will store an int

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");// This displays the string in the parenthesis
        }
    }
}
