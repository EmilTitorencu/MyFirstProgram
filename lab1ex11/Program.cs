using System;

namespace lab1ex11
{
    /* Folosind instructiunea switch scrieti un program care citind de la tastatura un numar intreg va verifica urmatoarele */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va rog sa introduceti un numarul intreg ");

            Console.Write("x=");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1: Console.WriteLine("unu"); break;
                case 2: Console.WriteLine("doi"); break;
                case 3: Console.WriteLine("trei"); break;
                case 5: Console.WriteLine("cinci"); break;
                case 8: Console.WriteLine("opt"); break;
                default: Console.WriteLine("neidentificat"); break;
            }
        }
    }
}
