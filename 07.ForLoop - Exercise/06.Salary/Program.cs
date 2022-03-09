using System;

namespace _06Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Facebook = 150;
            const int Instagram = 100;
            const int Reddit = 50;

            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string openedWebsites = Console.ReadLine();

                if (openedWebsites == "Facebook")
                {
                    salary -= Facebook;
                }
                else if (openedWebsites == "Instagram")
                {
                    salary -= Instagram;
                }
                else if (openedWebsites == "Reddit")
                {
                    salary -= Reddit;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }

        }
    }
}
