using System;

namespace HousingEstate1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jozefko = new Person("Jozef", "Mrkvicka", 50);
            Console.WriteLine($"{jozefko.ToString()}"); ///ide to pogchamp
            Flat first = new Flat( 1, 20, 2);
            Console.WriteLine($"{first.ToString()}");
        }
        
     
        
    }
}

