using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            IQuittable obj1 = new Employee();
            obj1.Quit();
        }
    }
}
