using System;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationMoney = double.Parse(Console.ReadLine());
            double currMoney = double.Parse(Console.ReadLine());
            double totalMoney = currMoney;
            int days = 0;
            int spendCount = 0;

            while (spendCount != 5)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                days++;
                if (input == "save")
                {
                    totalMoney += money;
                    spendCount = 0;       
                }
                else if (input == "spend")
                {
                    spendCount++;
                    if (money > totalMoney)
                    {
                        totalMoney = 0;
                    }
                    else
                    {
                        totalMoney = totalMoney - money;
                    }
                }
                if (totalMoney >= vacationMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    return;
                }

            }
            Console.WriteLine("You can't save the money.");
            Console.WriteLine($"{days}");



        }   
    }
}
