using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();

            double selling = double.Parse(Console.ReadLine());

            if (selling > 0)
            {
                double percentDifference;

                double totalSelling = 0;

                if (city == "Sofia")
                {
                    if ( (selling >= 0) && (selling < 501) )
                    {
                        percentDifference = selling * 0.05;
                    }

                    else if (selling < 1001)
                    {
                        percentDifference = selling * 0.07;
                    }

                    else if (selling <= 10000)
                    {
                        percentDifference = selling * 0.08;
                    }

                    else if (selling > 10000)
                    {
                        percentDifference = selling * 0.12;
                    }

                    else
                    {
                        Console.WriteLine("error");

                        return;
                    }
                }

                else if (city == "Varna")
                {
                    if ( (selling >= 0) && (selling < 501) )
                    {
                        percentDifference = selling * 0.045;
                    }

                    else if (selling < 1001)
                    {
                        percentDifference = selling * 0.075;
                    }

                    else if (selling <= 10000)
                    {
                        percentDifference = selling * 0.1;
                    }

                    else if (selling > 10000)
                    {
                        percentDifference = selling * 0.13;
                    }

                    else
                    {
                        Console.WriteLine("error");

                        return;
                    }
                }

                else if (city == "Plovdiv")
                {
                    if ( (selling >= 0) && (selling < 501) )
                    {
                        percentDifference = selling * 0.055;
                    }

                    else if (selling < 1001)
                    {
                        percentDifference = selling * 0.08;
                    }

                    else if (selling <= 10000)
                    {
                        percentDifference = selling * 0.12;
                    }

                    else if (selling > 10000)
                    {
                        percentDifference = selling * 0.145;
                    }

                    else
                    {
                        Console.WriteLine("error");

                        return;
                    }
                }

                else
                {
                    Console.WriteLine("error");

                    return;
                }

                totalSelling -= percentDifference;
                Console.WriteLine($"{Math.Abs(totalSelling):F2}");
            }

            else
            {
                Console.WriteLine("error");

                return;
            }
        }    
    }
}
