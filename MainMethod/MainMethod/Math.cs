using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Math
    {
        //public int Add(int userInput, double val, int length) // Add method will take in inputNumber from user
        //{

        //    int addition = userInput + userInput;
        //    return addition;

        //    float squared = (float)(val * val);
        //    return (int)squared;


        //    int division = length / length;
        //        return division;
        //}


        public int Add(int userInput) // Add method will take in inputNumber from user
        {

            int addition = userInput + userInput;
            return addition;
        }

        public float Add(double val)
        {
            float squared = (float)(val * val);
            return squared;
        }


        public string Add(string userInput2)
        {
            int letters = userInput2.Length;
            int numbs = letters / letters;
            string val = Convert.ToString(numbs);




            return val;
        }
    }
}

