using System;

namespace lab3ex2
{
    /* Scrieti o functie care va determina daca un numar este sau nu numar prim. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul care va fi verificat daca este sau nu prim=");
            int numar = int.Parse(Console.ReadLine());
            if (IsPrim(numar)) 
            { 
                Console.WriteLine("Numarul " + numar + " este prim");
            } else
            {
                Console.WriteLine("Numarul " + numar + " NU este prim");
            }
        }

        static bool IsPrim(int numar)
        {
            if (numar < 2)
            {
                return false;
            }

            for (int i = 2; i < numar; i++)
            {
                if (numar % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
