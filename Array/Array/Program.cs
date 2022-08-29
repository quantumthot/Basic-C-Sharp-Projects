using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static public void Main(string[] args)
        {
            //String Array/////////////////////////////////////////////////////////////////////////
            string[] stringArray = new string[5]; // Initializing array

            stringArray[0] = ("apples");
            stringArray[1] = ("oranges");
            stringArray[2] = ("pears");
            stringArray[3] = ("plums");
            stringArray[4] = ("bananas");

            for (int i = 0; i < stringArray.Length; i++) //Iterates through array
            {
                Console.WriteLine("Enter {0} to select {1}", i, stringArray[i]);  // This will list what is in the array for the user
            }

            string choicefruit = Console.ReadLine();        //Reads input from user
            int j = int.Parse(choicefruit);                 
            if (j > 4)      // If choice is greater than 4 error meassage will show
            {
                Console.WriteLine("This number does not exist in this array");   
            }
            else
            {
                Console.WriteLine("You have selected {0} which is {1}", j, stringArray[j]);
            }



            //Int Array///////////////////////////////////////////////////////////////////////////////
            int[] intArray = { 1, 3, 5 ,6 ,9, 12};

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("Enter {0} to select {1}", i, intArray[i]);
            }

            string choicenumber = Console.ReadLine();
            int k = int.Parse(choicenumber);
            if (k > 5)
            {
                Console.WriteLine("This number does not exist in this array");
            }
            else
            {
                Console.WriteLine("You have selected {0} which is {1}", k, intArray[k]);
            }
            

            //List//////////////////////////////////////////////////////////////////////////////////
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("there");
            intList.Add("how");
            intList.Add("are");
            intList.Add("you?");

            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine("Enter {0} to select {1}", i, intList[i]);
            }


            string choice = Console.ReadLine();
            int m = int.Parse(choice);
            if (m > 5)
            {
                Console.WriteLine("This number does not exist in this array");
            }
            else
            {
                Console.WriteLine("You have selected {0} which is {1}", m, intList[m]);
            }
            





        }
    }
}
