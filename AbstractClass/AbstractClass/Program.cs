using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person name = new Employee();
            name.firstName = "Sample ";
            name.lastName = "Student ";
            name.sayName();
        }
    }
}
