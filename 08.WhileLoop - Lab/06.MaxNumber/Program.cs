using System;

namespace _06MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int maxNum = -10000;

            while (input != "Stop")
            {
                int num = int.Parse(input);

                if (num > maxNum)
                {
                    maxNum = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
