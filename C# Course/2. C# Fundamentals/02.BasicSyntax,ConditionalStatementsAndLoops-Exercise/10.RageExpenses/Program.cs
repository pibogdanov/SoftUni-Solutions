using System;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());

            double mousePrice = double.Parse(Console.ReadLine());

            double keyboardPrice = double.Parse(Console.ReadLine());

            double displayPrice = double.Parse(Console.ReadLine());

            int brokenHeadsetCounter = 0;

            int brokenMouseCounter = 0;

            int brokenKeyboardCounter = 0;

            double price = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                brokenHeadsetCounter++;

                brokenMouseCounter++;

                bool isHeadsetBroken;

                if (brokenHeadsetCounter == 2)
                {
                    isHeadsetBroken = true;

                    brokenHeadsetCounter = 0;

                    price += headsetPrice;
                }

                else
                {
                    isHeadsetBroken = false;
                }

                bool isMouseBroken;

                if (brokenMouseCounter == 3)
                {
                    isMouseBroken = true;

                    brokenMouseCounter = 0;

                    price += mousePrice;
                }

                else
                {
                    isMouseBroken = false;
                }

                if (isHeadsetBroken && isMouseBroken)
                {
                    brokenKeyboardCounter++;

                    price += keyboardPrice;
                }

                if (brokenKeyboardCounter == 2)
                {
                    brokenKeyboardCounter = 0;

                    price += displayPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {price:f2} lv.");
        }
    }
}
