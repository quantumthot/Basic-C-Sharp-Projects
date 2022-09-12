using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new List<Employee>(); // Instantionating new list from class Employee called employee

            var employee1 = new Employee() { id = 1, firstName = "Joe", lastName = "Dingleberry" }; // setting variables to new employee list
            var employee2 = new Employee() { id = 2, firstName = "Michael", lastName = "Jordan" };
            var employee3 = new Employee() { id = 3, firstName = "Mike", lastName = "Tyson" };
            var employee4 = new Employee() { id = 4, firstName = "Lazy", lastName = "Susan" };
            var employee5 = new Employee() { id = 5, firstName = "Jimmy", lastName = "Hoffa" };
            var employee6 = new Employee() { id = 6, firstName = "Peter", lastName = "Piper" };
            var employee7 = new Employee() { id = 7, firstName = "Carl", lastName = "Sagan" };
            var employee8 = new Employee() { id = 8, firstName = "Jake", lastName = "LeSnake" };
            var employee9 = new Employee() { id = 9, firstName = "Robert", lastName = "Pants" };
            var employee10 = new Employee() { id = 10, firstName = "Joe", lastName = "Balogna" };

            employee.Add(employee1); // adding variables to employee list
            employee.Add(employee2);
            employee.Add(employee3);
            employee.Add(employee4);
            employee.Add(employee5);
            employee.Add(employee6);
            employee.Add(employee7);
            employee.Add(employee8);
            employee.Add(employee9);
            employee.Add(employee10);

            //  iterates all entries in Employee list //
            //foreach (var emp in employee)
            //{
            //    Console.WriteLine("Id: {0}, First Name: {1}, Last Name: {2}", emp.id, emp.firstName, emp.lastName);
            //}
            //Console.ReadLine();

            var joe = new List<Employee>(); // new list called joe

            var result = from s in employee
                         where s.firstName == "Joe" // result is finding everyone in the list with the first name Joe
                         select s;

            foreach (var joes in result)
            {
                joe.Add(joes);             // adding Joes to new list joe
            }
            Console.WriteLine("Here's a new list called joeList, that has Joes.");
            Console.ReadLine();

            foreach (var joeList in joe)
            {
                Console.WriteLine("Id: {0}, First Name: {1}, Last Name: {2}", joeList.id, joeList.firstName, joeList.lastName);
            }
            Console.ReadLine();

            List<Employee> anotherJoe = employee.Where(e => e.firstName == "Joe").ToList(); //Making new list using lambda 
            Console.WriteLine("Here's a new list called anotherJoeList, that has Joes.");
            Console.ReadLine();

            foreach (var anotherJoeList in anotherJoe)
            {
                Console.WriteLine("Id: {0}, First Name: {1}, Last Name: {2}", anotherJoeList.id, anotherJoeList.firstName, anotherJoeList.lastName);
            }
            Console.ReadLine();

            List<Employee> employeeOver5 = employee.Where(e => e.id > 5).ToList(); //Making new list using lambda 
            Console.WriteLine("Here's a new list called employeeOver5, that has employees with an ID over 5.");
            Console.ReadLine();

            foreach (var emp in employeeOver5)
            {
                Console.WriteLine("Id: {0}, First Name: {1}, Last Name: {2}", emp.id, emp.firstName, emp.lastName);
            }
            Console.ReadLine();









            Console.ReadLine();
        }
    }
}
