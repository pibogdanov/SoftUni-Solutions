using System;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;

            while (true) 
            {
                string input = Console.ReadLine();

                if (input == "Start")
                {
                    break;
                }

                double coin = double.Parse(input);

                if ( (coin == 0.1) || (coin == 0.2) || (coin == 0.5) || (coin == 1.0) || (coin == 2.0) ) 
                { 
                    balance += coin;
                }

                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine($"Change: {balance:F2}");

                    break;
                }

                if (input == "Nuts")
                {
                    if (balance >= 2)
                    {
                        balance -= 2;

                        Console.WriteLine("Purchased nuts");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                else if (input == "Water")
                {
                    if (balance >= 0.7)
                    {
                        balance -= 0.7;

                        Console.WriteLine("Purchased water");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                else if (input == "Crisps")
                {
                    if (balance >= 1.5)
                    {
                        balance -= 1.5;

                        Console.WriteLine("Purchased crisps");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                else if (input == "Soda")
                {
                    if (balance >= 0.8)
                    {
                        balance -= 0.8;

                        Console.WriteLine("Purchased soda");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                else if (input == "Coke")
                {
                    if (balance >= 1)
                    {
                        balance -= 1;

                        Console.WriteLine("Purchased coke");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
        }
    }
}