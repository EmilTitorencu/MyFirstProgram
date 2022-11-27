using System;

namespace lab1ex3
{
    /* Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va rog sa introduceti un numar intreg ( ex: 5 )");

            Console.Write("Numar intreg=");
            int numar = int.Parse(Console.ReadLine());

            int ultimaCifra = numar % 10;
            Console.Write("Ultima cifra=");
            Console.Write(ultimaCifra);
        }
    }
}
