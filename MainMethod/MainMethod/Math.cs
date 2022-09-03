using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Math
    {
        public int Add(int userInput) // Add method will take in inputNumber from user
        {

            int addition = userInput + userInput;
            return addition;
        }

        public float Square(double val)
        {
            float squared = (float)(val * val);
            return squared;
        }


        public int Divide(int userInput2)
        {
            
            int division = userInput2 / userInput2;
            return division;
        }
    }
}

