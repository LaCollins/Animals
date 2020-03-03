using System;
using Animals.Reptiles;

namespace Animals //Bundle of classes
{
    class Program //Bundle of Methods
    {
        static void Main(string[] args)
        {
            var americanAlligator = new Alligator(100);

            americanAlligator.IsAquatic = true;

            var africanAlligator = new Alligator(2);

            africanAlligator.IsAquatic = false;

            americanAlligator.Run(75);
            africanAlligator.Run(4);

            americanAlligator.Run(40);

            Console.ReadKey();
        }
    }
}
