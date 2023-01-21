using System;

namespace _08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    {
                        Console.WriteLine("12");
                    }

                    break;

                case "Tuesday":
                    {
                        Console.WriteLine("12");
                    }

                    break;

                case "Wednesday":
                    {
                        Console.WriteLine("14");
                    }
                    
                    break;

                case "Thursday":
                    {
                        Console.WriteLine("14");
                    }
                break;

                case "Friday":
                    {
                        Console.WriteLine("12");
                    }

                break;

                case "Saturday":
                    {
                        Console.WriteLine("16");
                    }

                break;

                case "Sunday":
                    {
                        Console.WriteLine("16");
                    }

                break;

                default:
                    {
                        Console.WriteLine("Error");
                    }

                break;
            }
        }
    }
}
