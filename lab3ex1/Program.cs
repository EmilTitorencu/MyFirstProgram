using System;

namespace lab3ex1
{
    /* Scrieti o functie care va calcula suma cifrelor unui numar. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul pentru care vom calcula suma cifrelor=");
            int numar = int.Parse(Console.ReadLine());
            Console.WriteLine("Suma cifrelor numarului "+numar+" este ="+GetSumaCifre(numar));
        }

        static int GetSumaCifre(int numar)
        {
            int suma= numar % 10;

            while (numar/10!=0)
            {                
                numar /= 10;
                suma += numar % 10;
            }

            return suma;
        }
    }
}
