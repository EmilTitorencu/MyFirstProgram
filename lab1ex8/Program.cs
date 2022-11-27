using System;

namespace lab1ex8
{
    /* Se citesc doua numere de la tastatura , x si y. Scrieti un program care va verifica daca x este divizibil cu y. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va rog sa introduceti cele 2 numere care vor fi verificate ( ex: 10 )");

            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());

            Console.Write("y=");
            int y = int.Parse(Console.ReadLine());

            if ((x % y) == 0)
            {
                Console.Write("divizibil");
            }
            else
            {
                Console.Write("indivizibil");
            }
        }
    }
}
