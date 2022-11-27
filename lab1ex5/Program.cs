using System;

namespace lab1ex5
{
    /* Se citesc doua numere de la tastatura , x,y . Scrieti un program care va afisa cele doua valori in ordine crescatoare */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va rog sa introduceti cele 2 numere care vor fi comparate ( ex: 10.5 )");

            Console.Write("x=");
            decimal x = decimal.Parse(Console.ReadLine());

            Console.Write("y=");
            decimal y = decimal.Parse(Console.ReadLine());

            if (x<= y)
            {
                Console.Write(x);
                Console.Write(" ");
                Console.Write(y);
            } else
            {
                Console.Write(y);
                Console.Write(" ");
                Console.Write(x);
            }
        }
    }
}
