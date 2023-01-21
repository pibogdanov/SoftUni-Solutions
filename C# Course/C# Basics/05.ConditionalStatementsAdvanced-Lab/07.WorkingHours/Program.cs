using System;

namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());

            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    {
                        if ( (hours > 9) && (hours < 19) )
                        {
                            Console.WriteLine("open");
                        }

                        else
                        {
                            Console.WriteLine("closed");
                        }
                    }

                break;
            
                default:
                    {
                        Console.WriteLine("closed");
                    }

                break;
            }
        }
    }
}
