using System;

namespace _08GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); 
            double rating = double.Parse(Console.ReadLine()); 
            int classes = 1;
            double lastRating = 4.0; 


            while (classes < 12)
            {
                double thisTimeRating = double.Parse(Console.ReadLine()); 
                rating += thisTimeRating;

                if (lastRating < 4 && thisTimeRating < 4)
                {
                    Console.WriteLine($"{name} has been excluded at {classes} grade");
                    break;
                }
                classes++; 
                lastRating = thisTimeRating; 

            }
            if (classes == 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {rating / 12:f2}");
            }
        }
    }
}
using System;

namespace _08GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); 
            double rating = double.Parse(Console.ReadLine()); 
            int classes = 1;
            double lastRating = 6.0; 


            while (classes < 12)
            {
                double thisTimeRating = double.Parse(Console.ReadLine()); 
                rating += thisTimeRating;

                if (lastRating < 4 && thisTimeRating < 4)
                {
                    Console.WriteLine($"{name} has been excluded at {classes} grade");
                    break;
                }
                classes++; 
                lastRating = thisTimeRating; 

            }
            if (classes == 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {rating / 12:f2}");
            }
        }
    }
}
