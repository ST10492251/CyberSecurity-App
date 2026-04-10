using System;

namespace CyberSecurity_App
{
    public class greet_user
    {
        public string Name { get; set; }

        public greet_user()
        {
            Console.WriteLine("Enter your name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Welcome " + Name + " to the CyberSecurity Awareness Bot!");   
        }
    }
}