using System;

namespace _07MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int minNum = 10000;

            while (input != "Stop")
            {
                int num = int.Parse(input);

                if (num < minNum)
                {
                    minNum = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
