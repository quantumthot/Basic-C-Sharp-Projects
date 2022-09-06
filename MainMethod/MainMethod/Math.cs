using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Math
    {
        public int Add(int userInput) 
        {
            int addition = userInput + userInput;
            return addition;
        }

        public int Add(decimal val)
        {
            decimal squared = (val * val);
            int numba = Convert.ToInt32(squared);
            return numba;
        }


        public int Add(string userInput2)
        {
            int numbs2 = userInput2.Length;
            int numbs3 = numbs2 / numbs2;
            return numbs3;
        }
    }
}

