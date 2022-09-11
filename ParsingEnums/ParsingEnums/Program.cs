using System;

namespace ParsingEnums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("User, please enter the current day of the week");
                DaysofTheWeek pickDay = (DaysofTheWeek)Enum.Parse(typeof(DaysofTheWeek), Console.ReadLine(), true);
                Console.WriteLine("The day you picked was {0}", pickDay);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual numerical day of the week.", ex.Message);
                Console.ReadLine();
            }

        }
        public enum DaysofTheWeek
        {    
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday =3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }
    }
}
