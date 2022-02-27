using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double finalPrice = 0.0;

            const double priceOfRoses = 5;
            const double priceOfDahlias = 3.80;
            const double priceOfTulips = 2.80;
            const double priceOfNarcissus = 3;
            const double priceOfGladiolus = 2.50;
            
           switch (flowersType)
            {
                case "Roses":
                    if (flowersNumber > 80)
                    {
                        finalPrice -= flowersNumber * priceOfRoses * 0.10;
                    }
                    finalPrice += flowersNumber * priceOfRoses;
                    break;
                case "Dahlias":
                    if (flowersNumber > 90)
                    {
                        finalPrice -= flowersNumber * priceOfDahlias * 0.15;
                    }
                    finalPrice += flowersNumber * priceOfDahlias;
                    break;
                case "Tulips":
                    if (flowersNumber > 80)
                    {
                        finalPrice -= flowersNumber * priceOfTulips * 0.15;
                    }
                    finalPrice += flowersNumber * priceOfTulips;
                    break;
                case "Narcissus":
                    if (flowersNumber < 120)
                    {
                        finalPrice += flowersNumber * priceOfNarcissus * 0.15;
                    }
                    finalPrice += flowersNumber * priceOfNarcissus;
                    break;
                case "Gladiolus":
                    if (flowersNumber < 80)
                    {
                        finalPrice += flowersNumber * priceOfGladiolus * 0.20;
                    }
                    finalPrice += flowersNumber * priceOfGladiolus;
                    break;
            }
            if (budget >= finalPrice)
            {
                double moneyLeft = budget - finalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowersNumber} {flowersType} and {moneyLeft:f2} leva left.");
            }
            else if (budget < finalPrice)
            {
                double moneyNeeded = finalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }

        }
    }
}
