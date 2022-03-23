using System;

namespace _01NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetnum = int.Parse(Console.ReadLine());
            int rows = 1;
            int currNum = 1;
            bool isEqual = false;

            while (isEqual == false)
            {
                for (int i = 1; i <= rows; i++)
                {
                    Console.Write(currNum + " ");
                    currNum++;
                    if (currNum > targetnum)
                    {
                        isEqual = true;
                        break;
                    }
                }
                Console.WriteLine();
                rows++;
            }
            
               
        }
    }
}
