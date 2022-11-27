using System;

namespace lab1ex2
{
    /* Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va rog sa introduceti cele 3 numere pentru care se va calcula media aritmetica.");
            Console.WriteLine("Valorile sunt numere zecimale ( ex: 10.5 ).");

            Console.Write("Nr1=");
            decimal nr1 = decimal.Parse(Console.ReadLine());

            Console.Write("Nr2=");
            decimal nr2 = decimal.Parse(Console.ReadLine());

            Console.Write("Nr3=");
            decimal nr3 = decimal.Parse(Console.ReadLine());

            decimal medieAritmetica = (nr1 + nr2 + nr3) / 3;
            Console.Write("Media aritmetica=");
            Console.WriteLine(medieAritmetica);
        }
    }
}
