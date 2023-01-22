using System;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string input;

            double moneyLeft = budget;

            while ((input = Console.ReadLine()) != "Game Time")
            {
                if (input == "OutFall 4")
                {
                    if (moneyLeft >= 39.99)
                    {
                        moneyLeft -= 39.99;

                        Console.WriteLine($"Bought {input}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                else if (input == "CS: OG")
                {
                    if (moneyLeft >= 15.99)
                    {
                        moneyLeft -= 15.99;

                        Console.WriteLine($"Bought {input}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                else if (input == "Zplinter Zell")
                {
                    if (moneyLeft >= 19.99)
                    {
                        moneyLeft -= 19.99;

                        Console.WriteLine($"Bought {input}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                else if (input == "Honored 2")
                {
                    if (moneyLeft >= 59.99)
                    {
                        moneyLeft -= 59.99;

                        Console.WriteLine($"Bought {input}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                else if (input == "RoverWatch")
                {
                    if (moneyLeft >= 29.99)
                    {
                        moneyLeft -= 29.99;

                        Console.WriteLine($"Bought {input}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                else if (input == "RoverWatch Origins Edition")
                {
                    if (moneyLeft >= 39.99)
                    {
                        moneyLeft -= 39.99;

                        Console.WriteLine($"Bought {input}");
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                else
                {
                    Console.WriteLine("Not Found");
                }

                if (moneyLeft == 0)
                {
                    Console.WriteLine("Out of money!");

                    return;
                }
            }

            double moneySpent = budget - moneyLeft;
            Console.WriteLine($"Total spent: ${moneySpent:F2}. Remaining: ${moneyLeft:F2}");
        }
    }
}
