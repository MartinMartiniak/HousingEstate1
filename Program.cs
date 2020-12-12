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

            Flat second = new Flat(2, 30, 3);
            Console.WriteLine($"{second.ToString()}");
            
            Flat third = new Flat(3, 40, 4);
            Console.WriteLine($"{third.ToString()}");
            
            Flat fourth = new Flat(4, 35, 3);
            Console.WriteLine($"{fourth.ToString()}");
            
            Flat fifth = new Flat(5, 25, 2);
            Console.WriteLine($"{fifth.ToString()}");
        }
        
     
        
    }
}

