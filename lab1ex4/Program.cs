using System;

namespace lab1ex4
{
    /* Scrieti un program care va afisa semnul unui numar citit de la tastatura */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va rog sa introduceti un numar ( ex: 10.5 )");

            Console.Write("Numar=");
            decimal numar = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Semnul numarului este: ");
            if (numar>0)
            {
                Console.WriteLine("+");
            } else if (numar<0)
            {
                Console.WriteLine("-");
            } else
            {
                Console.WriteLine("0");
            }
        }
    }
}
