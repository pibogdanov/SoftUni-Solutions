using System;
using System.Linq;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            int logInAttemptsCounter = 0;

            string passwordAttemptInput = Console.ReadLine();

            while (true) 
            {
                if (logInAttemptsCounter == 3)
                {
                    Console.WriteLine($"User {username} blocked!");

                    break;
                }

                string password = new (username.Reverse().ToArray());

                if (passwordAttemptInput == password)
                {
                    Console.WriteLine($"User {username} logged in.");

                    break;
                }

                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                logInAttemptsCounter++;

                passwordAttemptInput = Console.ReadLine();
            }
        }
    }
}
