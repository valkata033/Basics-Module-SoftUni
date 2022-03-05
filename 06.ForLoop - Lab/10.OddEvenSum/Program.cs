using System;

namespace _10OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < count; i++)
            {
                int evenNum = int.Parse(Console.ReadLine());
                int oddNum = int.Parse(Console.ReadLine());
                if (evenNum % 2 == 0)
                {
                    evenSum += evenNum;
                }
                if (oddNum % 2 != 0)
                {
                    oddSum += oddNum;
                }
                                
            }
           
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                int diferens = evenSum - oddSum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diferens)}");
            }


        }
    }
}
