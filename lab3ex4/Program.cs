using System;

namespace lab3ex4
{
    /* Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la tastatura. Scrieti functii care vor returna
• Cel mai mare numar din vector
• Cel mai mic numar din vector
• Numerele divizibile cu 3
• Numerele prime din vector */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti cate numere va avea vectorul ce va verificat=");
            int[] vector = ReadVector(int.Parse(Console.ReadLine()));

            Console.WriteLine("Cel mai mare numar = " + MaxVector(vector));
            Console.WriteLine("Cel mai mic  numar = " + MinVector(vector));

            int[] divizibile = GetDivizibile(vector);
            for(int i=0; i<divizibile.Length; i++)
            {
                Console.WriteLine(divizibile[i]+" este divizibil cu 3");
            }

            int[] prime = GetPrime(vector);
            for (int i = 0; i < prime.Length; i++)
            {
                Console.WriteLine(prime[i] + " este prim");
            }
        }

        static int[] ReadVector(int numar)
        {
            int[] vector = new int[numar];

            for (int i=0;i<numar;i++)
            {
                Console.Write("Numarul "+(i+1)+" = ");
                vector[i]=int.Parse(Console.ReadLine());
            }

            return vector;
        }

        static int MaxVector(int[] vector)
        {
            int max= vector[0];
            for (int i=1;i<vector.Length;i++)
            {
                if (vector[i]>max)
                {
                    max = vector[i];
                }
            }
            return max;
        }

        static int MinVector(int[] vector)
        {
            int min = vector[0];
            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] < min)
                {
                    min = vector[i];
                }
            }
            return min;
        }


        static int[] GetDivizibile(int[] vector)
        {
            bool[] divizible=new bool[vector.Length];
            int cateDivizibile = 0;
            for (int i=0;i< vector.Length; i++)
            {
                if (vector[i] % 3==0)
                {
                    cateDivizibile++;
                    divizible[i] = true;
                } else
                {
                    divizible[i] = false;
                }
            }

            int[] rezultat = new int[cateDivizibile];
            int pos = 0;
            for (int i=0; i<vector.Length; i++)
            {
                if (divizible[i])
                {
                    rezultat[pos] = vector[i];
                    pos++;
                }
            }

            return rezultat;
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

        static int[] GetPrime(int[] vector)
        {
            bool[] prime = new bool[vector.Length];
            int catePrime = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (isPrim(vector[i]))
                {
                    catePrime++;
                    prime[i] = true;
                }
                else
                {
                    prime[i] = false;
                }
            }

            int[] rezultat = new int[catePrime];
            int pos = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (prime[i])
                {
                    rezultat[pos] = vector[i];
                    pos++;
                }
            }

            return rezultat;
        }
    }
}
