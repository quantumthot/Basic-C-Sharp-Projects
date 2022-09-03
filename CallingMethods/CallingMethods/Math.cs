using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CallingMethods
{
    public class Math
    {
        public int Add(int inputNumber) // Add method will take in inputNumber from user
        { 
            int addition = (inputNumber + inputNumber);
            return addition;
        }

        public int Divide(int inputNumber) //Constructor
        {
            int divide = (inputNumber / inputNumber);
            return divide;
        }


        public int Square(int inputNumber) //Constructor
        {
            int squared = (inputNumber * inputNumber);
            return squared;
           
        }
    }
}