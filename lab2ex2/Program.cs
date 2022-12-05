using System;

namespace lab2ex2
{
    /* Scrieti un program care va afisa factorialul unui numar n, n fiind citit de la tastatura. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Va rugam sa introduceti numarul intreg pentru care vom calcula factorialul=");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i=1;i<=n;i++)
            {
                factorial *= i;
            }

            Console.Write("Factorialul numarului="+ factorial);
        }
    }
}
