using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Person
    {
        public string firstName;
        public string lastName; 
        public void sayName()
        {
            Console.WriteLine("Name: "+ firstName + lastName);
            Console.ReadLine();
        }
    }
}
