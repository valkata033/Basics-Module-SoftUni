using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    double totalMoney = budget * 0.30;
                    Console.WriteLine($"Camp - {totalMoney:f2}");
                }
                else if (season == "winter")
                {
                    double totalMoney = budget * 0.70;
                    Console.WriteLine($"Hotel - {totalMoney:f2}");
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    double totalMoney = budget * 0.40;
                    Console.WriteLine($"Camp - {totalMoney:f2}");
                }
                else if (season == "winter")
                {
                    double totalMoney = budget * 0.80;
                    Console.WriteLine($"Hotel - {totalMoney:f2}");
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                    double totalMoney = budget * 0.90;
                Console.WriteLine($"Hotel - {totalMoney:f2}");
            }



        }
    }
}
