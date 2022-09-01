using System;
using System.Collections.Generic;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>(); // initializing list for integers
            integerList.Add(3);                      // Adding integers to the list
            integerList.Add(6);
            integerList.Add(9);
            integerList.Add(12);
            integerList.Add(13);

            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine()); // asking user to pick a whole number and converting from string to int.

                for (int i = 0; i < integerList.Count; i++) // iterates through list
                {
                    int numberTwo = integerList[i] / numberOne; // divides each number in list by user imput number
                    Console.WriteLine(integerList[i] + " divided by " + numberOne + " equals " + numberTwo);
                }
                   
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type in a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // Will give user an error message..
            }
            finally
            {
                Console.ReadLine();
            }


        }
    }
}
