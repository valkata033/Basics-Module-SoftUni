using System;

namespace _04Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int goal = 10000;
            int totalSteps = 0;

            while (totalSteps < goal)
            {
                string command = Console.ReadLine();
                if (command == "Going home")
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    totalSteps += stepsLeft;
                    break;
                }
                int steps = int.Parse(command);
                totalSteps += steps;
            }
            if (totalSteps >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                int stepsOverTheGoal = totalSteps - goal;
                Console.WriteLine($"{stepsOverTheGoal} steps over the goal!");
            }
            else
            {
                int stepsToReachTheGoal = goal - totalSteps;
                Console.WriteLine($"{stepsToReachTheGoal} more steps to reach goal.");
            }
        }
    }
}
