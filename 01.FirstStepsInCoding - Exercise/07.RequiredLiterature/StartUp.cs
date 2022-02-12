using System;

namespace RequiredLiterature
{
    class StartUp
    {
        static void Main(string[] args)
        {
          

            int pagesInBook = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int daysForReading = int.Parse(Console.ReadLine());

            double totalTimeForReading = pagesInBook / pagesPerHour;
            double totalHoursPerDay = totalTimeForReading / daysForReading;
            Console.WriteLine(totalHoursPerDay);

        }
    }
}
