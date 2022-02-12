using System;

namespace DepositCalculator
{
    class StartUp
    {
        static void Main(string[] args)
        {


            double depositSum = double.Parse(Console.ReadLine());
            int depositAmountPerMonth = int.Parse(Console.ReadLine());
            double interestPercent = double.Parse(Console.ReadLine());

            double interestSum = depositSum * interestPercent / 100;
            double interestPerMonth = interestSum / 12;
            double totalSum = depositSum + depositAmountPerMonth * interestPerMonth;
            Console.WriteLine(totalSum);


        }
    }
}
