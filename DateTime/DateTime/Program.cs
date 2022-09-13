using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now; // Creating new var that pulls in current time and date
            Console.WriteLine(now);
            Console.WriteLine("User, please enter a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            DateTime x = now.AddHours(userNumber); // Creating new var that adds userNumber to current time.
            Console.WriteLine("The time it will be in {0} hours will be {1}", userNumber, x);
            Console.ReadLine();
        }
    }
}