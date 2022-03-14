using System;

namespace _02ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string currTask = Console.ReadLine();
            string lastTask = "";
            int countOfTasks = 0;
            double amountOfGrades = 0;
            int badGradesCounter = 0;

            while (currTask != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badGradesCounter++;
                }
                if (badGradesCounter == badGrades)
                {
                    Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
                    return;
                }

                amountOfGrades += grade;
                lastTask = currTask;
                countOfTasks++;
                currTask = Console.ReadLine();
            }
            double averageScore = amountOfGrades / countOfTasks;
            Console.WriteLine($"Average score: {averageScore:f2}");
            Console.WriteLine($"Number of problems: {countOfTasks}");
            Console.WriteLine($"Last problem: {lastTask}");

        }
    }
}
