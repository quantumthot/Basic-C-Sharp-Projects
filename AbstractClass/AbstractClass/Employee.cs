using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Employee : Person , IQuittable
    {
        Person name = new Person();
        
        public void Quit(Person person)
        {
            throw new NotImplementedException();
        }
    }
       
}
