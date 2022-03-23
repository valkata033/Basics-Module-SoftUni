using System;

namespace _04TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int gradeCount = 0;
            double sumOfAllGrades = 0;

            while (input != "Finish")
            {
                double sumOfGrades = 0;
                for (int i = 1; i <= juryCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                    sumOfAllGrades += grade;
                    gradeCount++;
                }
                double average = sumOfGrades / juryCount;
                Console.WriteLine($"{input} - {average:f2}.");

                input = Console.ReadLine();
            }

            double finalAverageScore = sumOfAllGrades / gradeCount;
            Console.WriteLine($"Student's final assessment is {finalAverageScore:f2}.");

        }
    }
}
