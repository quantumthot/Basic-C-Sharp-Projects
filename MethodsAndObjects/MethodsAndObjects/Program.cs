using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee fullName = new Employee();

            fullName.FirstName = "Sample ";
            fullName.LastName = "Student ";
            fullName.SayName();

        }
    }
}
