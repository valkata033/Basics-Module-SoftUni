﻿using System;

namespace _07SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            int sumNumbers = 0;

            for (int i = 0; i < numberCount; i++)
            {
                sumNumbers += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sumNumbers);
        }
    }
}
