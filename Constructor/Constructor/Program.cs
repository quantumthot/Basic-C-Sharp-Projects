using System;

namespace Constructor
{
    class Constructor
    {
        static void Main(string[] args)
        {
            var user = new User("Tyler");
            const string location = "Zoo";
            Console.WriteLine("{0} {1}", user, location);
        }           
    }
    public class User
    {
        public User(string username) : this (username, "Home")
        {
        }

        public User(string username, string location)
        {
            this.username = username;
            this.location = location;
        }

        public string username { get; set; }
        public string location { get; set; }
    }
}
