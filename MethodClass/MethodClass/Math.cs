using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClass
{
    class Math
    {
        public int Add(int userInput1, int userInput2) // Add method will take in inputNumber from user
        {
            if (userInput1 >= 0 )
            {
                int addition = userInput1 + userInput1;
                return addition;
            }
            else
            {
                int showNum = userInput2;
                return showNum;
            }
          
            
        }
    }
}
