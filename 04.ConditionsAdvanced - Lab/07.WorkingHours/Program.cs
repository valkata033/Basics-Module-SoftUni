using System;

namespace _07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            double hour = double.Parse(Console.ReadLine());
            

            if (day == "Monday" || day == "Tuseday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
            {
                if (hour >= 10 || hour <= 18)
                {
                    Console.WriteLine("open");
                }
            }
            else if (day == "Sunday")
            {
                if (hour < 10 || hour > 18)
                {
                    Console.WriteLine("closed");
                }
            }
        }
    }
}
