using System;

namespace lab2ex1
{
    /* Scrieti un program care va afisa suma cifrelor unui numar n, n fiind citit de la tastatura. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Va rugam sa introduceti numarul intreg pentru care vom calcula suma cifrelor=");
            int n = int.Parse(Console.ReadLine());
            int sumaCifre = n % 10;

            while ((n/10)!=0)
            {                
                n = n / 10;
                sumaCifre += n % 10;
            }

            Console.Write("Suma cifrelor="+ sumaCifre);
        }
    }
}
