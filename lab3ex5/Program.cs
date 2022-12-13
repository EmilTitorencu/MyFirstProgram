using System;

namespace lab3ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul N=");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti numarul M=");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Arpsod a mancat "+(m-n+1)+" clatite");

            int[] tipuri = GetNumarTipClatite(n,m);
            Console.WriteLine(tipuri[0] + " clatite cu ciocolata");
            Console.WriteLine(tipuri[1] + " clatite cu gem");
            Console.WriteLine(tipuri[2] + " clatite cu inghetata");
            Console.WriteLine(tipuri[3] + " clatite cu zahar");
            Console.WriteLine(tipuri[4] + " clatite simple");
        }

        static int[] GetNumarTipClatite(int n, int m)
        {
            int[] tipuri = new int[5];

            for (int i=n;i<=m;i++)
            {
                if (isPrim(i))
                {
                    tipuri[0]++;
                } else if (IsPatratPerfect(i) || IsCubPerfect(i))
                {
                    tipuri[1]++;
                } else if (GetSumaDivizori(i)== i)
                {
                    tipuri[2]++;
                } else if (IsPar(i))
                {
                    tipuri[3]++;
                } else
                {
                    tipuri[4]++;
                }
            }

            return tipuri;
        }

        static bool isPrim(int numar)
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

        static bool IsPatratPerfect(int numar)
        {
            return Math.Sqrt(numar) == (int)Math.Sqrt(numar);
        }

        static bool IsCubPerfect(int numar)
        {
            return numar == (int) Math.Pow((int) Math.Pow(numar, (double) 1 /3),3);
        }

        static int GetSumaDivizori(int numar)
        {
            int suma = 1;
            for (int i=2;i<numar;i++)
            {
                if (numar % i==0)
                {
                    suma += i;
                }
            }
            return suma;
        }

        static bool IsPar(int numar)
        {
            return numar % 2 == 0;
        }
    }
}
