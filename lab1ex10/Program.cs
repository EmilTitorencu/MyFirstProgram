using System;

namespace lab1ex10
{
    /* Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la tastatura. Numarul are exact 2 cifre*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va rog sa introduceti numarul cu exact 2 cifre ( ex: 10 )");

            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());

            int sumaCifre = x / 10 + x % 10;
            Console.Write("Suma cifrelor=");
            Console.Write(sumaCifre);
        }
    }
}
