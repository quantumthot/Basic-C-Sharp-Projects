using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person , IQuittable
    {
        Person name = new Person();

        public void Quit()
        {
            Console.WriteLine("You quit");
        }
    }
       
}
