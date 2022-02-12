using System;

namespace Birthday
{
    class StartUp
    {
        static void Main(string[] args)
        {
           

            double rent = double.Parse(Console.ReadLine());

            double priceOfCake = rent * 0.20;
            double priceOfDrinks = priceOfCake - priceOfCake * 0.45;
            double priceOfAnimator = rent / 3;

            double totalSum = rent + priceOfCake + priceOfDrinks + priceOfAnimator;
            Console.WriteLine(totalSum);

        }
    }
}
