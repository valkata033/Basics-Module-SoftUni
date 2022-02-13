using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double priceOfHoliday = double.Parse(Console.ReadLine());
            int numberOfPuzzels = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double totalIncome = numberOfPuzzels * 2.60 + numberOfDolls * 3 + numberOfBears * 4.10 + numberOfMinions * 8.20 + numberOfTrucks * 2;

            int numOfToys = numberOfBears + numberOfDolls + numberOfMinions + numberOfPuzzels + numberOfTrucks;

            if (numOfToys >= 50)
            {
                totalIncome = totalIncome - totalIncome * 0.25;
                
            }
            totalIncome = totalIncome - totalIncome * 0.10;
            if (totalIncome >= priceOfHoliday)
            {
                Console.WriteLine($"Yes! {totalIncome - priceOfHoliday:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceOfHoliday - totalIncome:f2} lv needed.");
            }
            
        }
    }
}
