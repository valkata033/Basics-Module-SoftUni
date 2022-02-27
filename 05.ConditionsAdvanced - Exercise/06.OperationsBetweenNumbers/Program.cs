using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operatior = Console.ReadLine();

            if (operatior == "+")
            {
                if ((num1 + num2) / 2 == 0)
                {
                    Console.WriteLine($"{num1} + {num2} = {(num1 + num2)} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num2} = {(num1 + num2)} - odd");
                }
            }
            else if (operatior == "-")
            {
                if ((num1 + num2) / 2 == 0)
                {
                    Console.WriteLine($"{num1} - {num2} = {(num1 - num2)} - even");
                }
                else if ((num1 + num2) / 2 != 0)
                {
                    Console.WriteLine($"{num1} - {num2} = {(num1 - num2)} - odd");
                }
            }
            else if (operatior == "*")
            {
                if ((num1 * num2) / 2 == 0)
                {
                    Console.WriteLine($"{num1} * {num2} = {(num1 * num2)} - even");
                }
                else if ((num1 + num2) / 2 != 0)
                {
                    Console.WriteLine($"{num1} * {num2} = {(num1 * num2)} - odd");
                }
            }
            else if (operatior == "/")
            {
                if (num2 != 0)
                {
                    double result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
                else if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
            }
            else if (operatior == "%")
            {
                if (num2 != 0)
                {
                    Console.WriteLine($"{num1} % {num2} = {(num1 % num2)}");
                }
                else if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
            }


        }
    }
}
