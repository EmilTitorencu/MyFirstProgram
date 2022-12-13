using System;

namespace lab2ex4
{
    /* Scrieti un program care va determina daca un numar este sau nu palindrom.  */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Va rugam sa introduceti numarul care va fi verificat daca este sau nu palindrom=");
            int nInitial = int.Parse(Console.ReadLine());
            int n = nInitial;
            bool palindrom = true;            
            int nrCifre = 1;
            int cifra1, cifra2;

            while (n/10!=0)
            {
                n /= 10;
                nrCifre++;
            }

            for (int i=1; i<= nrCifre/2; i++) 
            {
                cifra1 = (nInitial / (int)Math.Pow(10, nrCifre-i))%10;
                cifra2 = (nInitial % (int)Math.Pow(10, i)) / (int)Math.Pow(10, i-1);

                if (cifra1!=cifra2)
                {
                    palindrom = false;
                    break;
                }
            }

            if (palindrom) { 
                Console.WriteLine("numarul "+ nInitial+" este palindrom");
            } else
            {
                Console.WriteLine("numarul " + nInitial + " NU este palindrom");
            }
        }
    }
}
