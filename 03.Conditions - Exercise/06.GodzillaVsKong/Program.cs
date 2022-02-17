using System;

namespace _06GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double budget = double.Parse(Console.ReadLine());
            int stuntman = int.Parse(Console.ReadLine());
            double priceForClothForOneStuntman = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double totalPriceForCloth = priceForClothForOneStuntman * stuntman;

            if (stuntman >= 150)
            {
                double discount = totalPriceForCloth * 0.10;
                totalPriceForCloth -= discount;
            }
            double totalMoney = decor + totalPriceForCloth;
            if (totalMoney > budget)
            {
                double neededMoney = totalMoney - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
            else
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            
        }
    }
}
