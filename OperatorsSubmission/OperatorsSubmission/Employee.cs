using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OperatorsSubmission
{
    class Employee
    {
        int id;
        string FirstName;
        string LastName;


        public Employee(int id, string FirstName, string LastName)
        {
            this.id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public void Display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("First Name : " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
                if((employee1.id == employee2.id))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if ((employee1.id != employee2.id))
            {
                return true;
            }
            return false;
        }  
    }
}
