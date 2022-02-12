using System;

namespace CharityCampaign
{
    class StartUp
    {
        static void Main(string[] args)
        {
           
            const double priceOfCake = 45;
            const double priceOfWaffles = 5.80;
            const double priceOfPancakes = 3.20;

            int daysOfCampaign = int.Parse(Console.ReadLine());
            int numberOfChefs = int.Parse(Console.ReadLine()); 
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            double sumOfCakes = numberOfCakes * priceOfCake;
            double sumOfWaffles = numberOfWaffles * priceOfWaffles;
            double sumOfPancakes = numberOfPancakes * priceOfPancakes;
            double totalSumPerDay = (sumOfCakes + sumOfWaffles + sumOfPancakes) * numberOfChefs;
            double totalSumForCampaign = totalSumPerDay * daysOfCampaign;
            double expenses = totalSumForCampaign / 8;
            double finalSum = totalSumForCampaign - expenses;

            Console.WriteLine(finalSum);


        }
    }
}
