using System;

namespace lab1ex7
{
    /* Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va rog sa introduceti un numar intreg ( ex: 10 )");

            Console.Write("Numar=");
            int numar = int.Parse(Console.ReadLine());

            if ((numar % 2)==0)
            {
                Console.Write("par");
            } else
            {
                Console.Write("impar");
            }
        }
    }
}
