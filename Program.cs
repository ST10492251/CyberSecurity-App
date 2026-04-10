using System;
using System.Net;

namespace CyberSecurity_App
{
    public class Program
    {
       public static void Main(string[] args)
        {
            string input = "";

            voice_logo logo = new voice_logo();
            greet_user user = new greet_user();
            get_response bot = new get_response();

            while (input != "exit")
            {
                Console.Write("\nYou: ");
                input = Console.ReadLine().ToLower();

                string response = bot.Response(input, user.Name);

                Console.WriteLine("Bot: " + response);
            }
        }
    }
}