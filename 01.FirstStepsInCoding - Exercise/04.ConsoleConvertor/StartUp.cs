using System;

namespace ConsoleConvertor
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //const double usd = 1.79549;

            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;

            Console.WriteLine($"{bgn:f2}");

        }
    }
}
