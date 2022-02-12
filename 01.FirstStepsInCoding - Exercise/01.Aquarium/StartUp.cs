using System;

namespace Aquarium
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double volumeOfAquarium = length * width * height;
            double totalLiters = volumeOfAquarium * 0.001;
            double busyArea = interest * 0.01;
            double necessaryLiters = totalLiters * (1 - busyArea);

            Console.WriteLine(necessaryLiters); 

        }
    }
}
