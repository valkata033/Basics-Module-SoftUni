using System;

namespace _08NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            int currentNumber = 0;

            for (int i = 0; i < number; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxNumber)
                    maxNumber = currentNumber;

                if (currentNumber < minNumber)
                    minNumber = currentNumber;
            }

            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
