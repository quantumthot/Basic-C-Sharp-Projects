using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Constructor
    {
        static void Main(string[] args)
        {
            var user = new User("Tyler"); 
            const string location = "Zoo"; // Creating a const string
            Console.WriteLine("{0} {1}", user, location);
        }           
    }
    public class User
    {
        public User(string username) : this (username, "Home") //second constructor pulling in from constructor below.
        {
        }

        public User(string username, string location) // original constructor
        {
            this.username = username;
            this.location = location;
        }

        public string username { get; set; }
        public string location { get; set; }
    }
}
