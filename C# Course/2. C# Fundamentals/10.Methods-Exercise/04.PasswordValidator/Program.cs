using System;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordValid(password);
        }

        static void PasswordValid(string password)
        {
            bool length = false;

            bool lettersDigits = true;

            bool digits2 = false;

            int counterDigits = 0;

            if ( (password.Length > 5) && (password.Length < 11))
            {
                length = true;
            }

            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            for (int i = 0; i < password.Length; i++)
            {
                char currentSymbol = password[i];

                if ( ((int)currentSymbol > 47) && ((int)currentSymbol < 58) )
                {
                    counterDigits++;
                }

                if ( ((int)currentSymbol < 48) || ((int)currentSymbol > 122) ||
                     ((int)currentSymbol > 90) && ((int)currentSymbol < 97)  ||
                     ((int)currentSymbol > 57) && ((int)currentSymbol < 65) 
                   )
                {
                    lettersDigits = false;
                }
            }

            if (lettersDigits == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (counterDigits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            else if (counterDigits >= 2)
            {
                digits2 = true;
            }

            if ( (length) && (lettersDigits) && (digits2) )
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
