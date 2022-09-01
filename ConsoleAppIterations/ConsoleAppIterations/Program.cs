using System;
using System.Collections.Generic;


namespace ConsoleAppIterations
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Iterations Console APP: Part 1");

            //String Array/////////////////////////////////////////////
            string[] Fruits = new string[5]; // Initializing array

            Fruits[0] = ("apples");
            Fruits[1] = ("oranges");
            Fruits[2] = ("pears");
            Fruits[3] = ("plums");
            Fruits[4] = ("bananas");

            Console.WriteLine("User, please enter some text."); // Asking user to enter text 
            string addLine = Console.ReadLine(); // This will take users input, and set iot as a string variable

            foreach (var s in Fruits) // saying each variable (strings) in Fruits array... 
            {
                Console.WriteLine(s + " " + addLine); // .. to output strings while adding user input to each one.
            }



            Console.WriteLine("Iterations Console APP: Part 2");

            int x = 1;

            // Creating infinite loop
            // using while loop
            while (true)
            {   // If statement will break once conditions are met
                if (x == 5)
                    break;
                // This statement will be printed
                // infinite times
                Console.WriteLine("Hello, World!");
                x++;
            }


            Console.WriteLine("Iterations APP: Part 3");

            int y = 1;

            // Creating infinite loop
            // using while loop
            while (true)
            {   // If statement will break once conditions are met
                if (4 < y)
                    break;
                // This statement will be printed
                // infinite times
                Console.WriteLine("Hello, Friend!");
                y++;
            }

            int z = 1;

            // Creating infinite loop
            // using while loop
            while (true)
            {   // If statement will break once conditions are met
                if (6 <= z)
                    break;
                // This statement will be printed
                // infinite times
                Console.WriteLine("Sup, Homie!");
                z++;
            }

            Console.WriteLine("Iterations Console APP: Part 4");

            // New string
            List<string> stringList = new List<string>() { "Hello", "there", "how", "are", "you?" };


            for (int i = 0; i < stringList.Count; i++) // Itterating through the list, one at a time.
            {
                Console.WriteLine("Enter {1} to select {0}", i, stringList[i]); // Asks user to enter a given word
            }

            bool isFound = false; // setting up a bool for the break

            while (true)
            {
                string entry = Console.ReadLine();


                if (!stringList.Contains(entry)) // If text entered does not match a given string, 
                {
                    Console.WriteLine("Entry not found, please enter text."); // then this message will be produced
                }
                else
                {
                    for (int i = 0; i < stringList.Count; i++) // iterate through 
                    {
                        if (stringList[i] == entry) // if entry matches one of the strings...
                        {
                            Console.WriteLine("Entry found at index: " + i); //.. it will tell you what word matched showing its paired index number
                            isFound = true;
                            break; // if word is found the codewill break its loop
                        }
                    }
                    if (isFound)
                    {
                        break;
                    }
                }
            }


            Console.WriteLine("Iterations Console APP: Part 5");

            List<string> animals = new List<string>() { "cat", "dog", "duck", "goose", "goose" };

            Console.WriteLine("User, please enter some text.");

            string search = Console.ReadLine();

            bool isFound1 = false;

            for (int i = 0; i < animals.Count; i++)
            {
                int match = animals[i].IndexOf(search);
                if (match != -1)
                {
                    isFound1 = true;
                    Console.WriteLine("you found a match, at index: {0} which is {1}", i, animals[i]);
                }
            }
            if (!isFound1)
            {
                Console.WriteLine("You did not find a match.");
            }


            Console.WriteLine("Iterations Console APP: Part 6");

            List<string> names = new List<string>() { "Steve", "Stevie", "Steven", "Stephen", "Steven" };
            List<string> namer = new List<string>(); // set up blank list, so when moving strings we can detect duplicates

            foreach (string name in names) //iteration through names
            {
                if (namer.Contains(name)) // if empty list "namer" ...
                {
                    Console.WriteLine("{0} - This item is a duplicate.", name); // ..contains a specific string, it will output a message saying the item is a duplicate
                }
                else // if the list "namer" does  not contain the item..
                {
                    Console.WriteLine("{0} - This item is unique.", name); //..output message will be "this item is unique."
                }
                namer.Add(name);
            }

        }
    }
}

