using System;

namespace lab2ex3
{
    /* Să se scrie un program care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatra */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Va rugam sa introduceti pentru cate numere vom calcula media aritmetica a celor pare=");
            int n = int.Parse(Console.ReadLine());
            int nrCurent;
            int sumaPare = 0;
            int nrPare = 0;
            int medieAritmetica;

            for (int i=1; i<=n; i++)
            {
                Console.Write("Nr. "+i+"=");
                nrCurent = int.Parse(Console.ReadLine()); ;
                if (nrCurent%2==0)
                {
                    sumaPare += nrCurent;
                    nrPare++;
                }
            }

            if (nrPare>0) { 
                medieAritmetica = sumaPare / nrPare;
                Console.Write("Media aritmetica a numerelor pare="+ medieAritmetica);
            } else
            {
                Console.Write("Nu avem numere pare pentru care sa calculam media");
            }
        }
    }
}
