using System;

namespace lab1ex6
{
    /* Se citesc trei numere de la tastatura , x,y,z . Scrieti un program care va afisa cele trei valori in ordine descrescatoare */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va rog sa introduceti cele 3 numere care vor fi comparate ( ex: 10.5 )");

            decimal max;
            decimal min;

            Console.Write("x=");
            decimal x = decimal.Parse(Console.ReadLine());

            Console.Write("y=");
            decimal y = decimal.Parse(Console.ReadLine());

            if (x >= y)
            {
                max = x; min = y;
            } else
            {
                max = y; min = x;
            }

            Console.Write("z=");
            decimal z = decimal.Parse(Console.ReadLine());

            if (min >= z)
            {
                Console.Write(max); Console.Write(" "); Console.Write(min); Console.Write(" "); Console.Write(z);
            } else if ( z >= max )
            {
                Console.Write(z); Console.Write(" "); Console.Write(max); Console.Write(" "); Console.Write(min);
            } else
            {
                Console.Write(max); Console.Write(" "); Console.Write(z); Console.Write(" "); Console.Write(min);
            }


        }
    }
}
