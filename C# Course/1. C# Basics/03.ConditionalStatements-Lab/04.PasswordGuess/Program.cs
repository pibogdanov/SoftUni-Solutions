using System;

namespace _04.PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string secretPassword = "s3cr3t!P@ssw0rd";

            if (password == secretPassword)
            {
                Console.WriteLine("Welcome");
            }

            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
