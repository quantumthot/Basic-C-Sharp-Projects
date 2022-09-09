using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "Karl", "Malone");
            employee1.Display();

            Employee employee2 = new Employee(2, "John", "Stockton");
            employee2.Display();

            bool v = employee2 == employee1;
            bool w = employee2 != employee1;
            Console.WriteLine("Employee1 and Employee2's Ids match: " + v);
            Console.WriteLine("Employee1 and Employee2's Ids do not match: " + w);
            Console.ReadLine();
        }
    }
}