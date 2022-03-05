using System;

namespace _11CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double savedMoney = 0;
            double moneyGift = 10;
            int toysCount = 0;

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    savedMoney += moneyGift;
                    moneyGift += 10;

                    savedMoney--;
                }
                else
                {
                    toysCount++;
                }
            }

            double moneyForToys = toysCount * toyPrice;

            savedMoney += moneyForToys;

            if (savedMoney >= washingMachine)
            {
                Console.WriteLine($"Yes! {savedMoney - washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - savedMoney:f2}");
            }

        }
    }
}
