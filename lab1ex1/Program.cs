using System;

namespace lab1ex1
{
    /* Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui paralelipiped dreptunghic , va afisa volumul lui */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va rog sa introduceti dimensiunile paralelipipedului dreptunghic.");
            Console.WriteLine("Valorile sunt numere zecimale ( ex: 10.5 ).");

            Console.Write("Lungime=");
            decimal lungime = decimal.Parse(Console.ReadLine());

            Console.Write("Latime=");
            decimal latime = decimal.Parse(Console.ReadLine());

            Console.Write("Inaltime=");
            decimal inaltime = decimal.Parse(Console.ReadLine());

            decimal volumParalelipiped = lungime * latime * inaltime;
            Console.Write("Volum=");
            Console.WriteLine(volumParalelipiped);
        }
    }
}
