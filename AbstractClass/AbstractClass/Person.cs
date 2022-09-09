using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
