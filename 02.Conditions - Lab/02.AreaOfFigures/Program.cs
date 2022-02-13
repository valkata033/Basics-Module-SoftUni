using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string type = Console.ReadLine();
            if (type == "square")
            {
                double sideOfSquare = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideOfSquare * sideOfSquare:f3}");
            }
            else if (type == "rectangle")
            {
                double sideOfRectangle1 = double.Parse(Console.ReadLine());
                double sideOfRectangle2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideOfRectangle1 * sideOfRectangle2:f3}");
            }
            else if (type == "circle")
            {
                double radiusOfCircle = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * radiusOfCircle * radiusOfCircle:f3}");
            }
            else if (type == "triangle")
            {
                double sideLength = double.Parse(Console.ReadLine());
                double heightLength = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideLength * heightLength / 2:f3}");
            }



        }
    }
}
