using System;

namespace lab3ex3
{
    /* Scrieti o functie care va determina daca un numar este sau nu patrat perfect. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul care va fi verificat daca este sau nu patrat perfect=");
            int numar = int.Parse(Console.ReadLine());
            if (IsPatratPerfect(numar))
            {
                Console.WriteLine("Numarul " + numar + " este patrat perfect");
            }
            else
            {
                Console.WriteLine("Numarul " + numar + " NU este patrat perfect");
            }
        }

        static bool IsPatratPerfect(int numar)
        {
            return Math.Sqrt(numar) == (int) Math.Sqrt(numar);
        }
    }
}
