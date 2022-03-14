using System;

namespace _01OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string currBook = Console.ReadLine();
            int count = 0;

            while (currBook != "No More Books")
            {
                if (currBook == book)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    return;
                }
                count++;
                currBook = Console.ReadLine();
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {count} books.");

        }
    }
}
