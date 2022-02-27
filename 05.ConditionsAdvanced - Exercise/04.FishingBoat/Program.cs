using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishersNum = int.Parse(Console.ReadLine());
            double totalMoney = 0.0;

            const double priceForSpring = 3000;
            const double priceForSummerAndAutumn = 4200;
            const double priceForWinter = 2600;

            switch (season)
            {
                case "Winter":
                    totalMoney = priceForWinter;
                     break;
                case "Spring":
                    totalMoney = priceForSpring;
                    break;
                case "Summer":
                    totalMoney = priceForSummerAndAutumn;
                    break;
                case "Autumn":
                    totalMoney = priceForSummerAndAutumn;
                    break;
            }

            if (fishersNum <= 6)
            {
                totalMoney -= totalMoney * 0.10;
            }
            else if (fishersNum >= 7 && fishersNum <= 11)
            {
                totalMoney -= totalMoney * 0.15;
            }
            else if (fishersNum >= 12)
            {
                totalMoney -= totalMoney * 0.25;
            }
            if (fishersNum % 2 == 0 && season != "Autumn")
            {
                totalMoney -= totalMoney * 0.05;
            }

            if (budget >= totalMoney)
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (budget < totalMoney)
            {
                double moneyNeeded = totalMoney - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }

        }
    }
}
