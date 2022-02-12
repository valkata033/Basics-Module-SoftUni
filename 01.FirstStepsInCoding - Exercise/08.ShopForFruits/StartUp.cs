using System;

namespace ShopForFruits
{
    class StartUp
    {
        static void Main(string[] args)
        {
            
            double priceForStrawberries = double.Parse(Console.ReadLine());
            double amountOfBananas = double.Parse(Console.ReadLine());
            double amountOfOranges = double.Parse(Console.ReadLine());
            double amountOfRaspberries = double.Parse(Console.ReadLine());
            double amountOfStrawberries = double.Parse(Console.ReadLine());

            double priceForRaspberries = priceForStrawberries / 2;
            double priceForOranges = priceForRaspberries - (priceForRaspberries * 0.40);
            double priceForBananas = priceForRaspberries - (priceForRaspberries * 0.80);
            double sumForRaspberries = amountOfRaspberries * priceForRaspberries;
            double sumForOranges = amountOfOranges * priceForOranges;
            double sumForBanans = amountOfBananas * priceForBananas;
            double sumForStrawberries = amountOfStrawberries * priceForStrawberries;
            double totalSumForProducts = sumForBanans + sumForOranges + sumForRaspberries + sumForStrawberries;

            Console.WriteLine($"{totalSumForProducts:f2} lv.");


        }
    }
}
