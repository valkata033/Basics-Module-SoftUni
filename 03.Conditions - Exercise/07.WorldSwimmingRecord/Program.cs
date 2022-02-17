using System;

namespace _07WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeFor1Meter = double.Parse(Console.ReadLine());

            double distanceInSecond = distance * timeFor1Meter;
            double delay = Math.Floor(distance / 15) * 12.5;

            double totalTime = distanceInSecond + delay;

            if (totalTime < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - record:f2} seconds slower.");
            }

        }
    }
}
