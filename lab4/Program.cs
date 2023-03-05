using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul */
            /* RunEx1(); */

            /* Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m, k. Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
                 Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i rezultatul.
                 Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i rezultatul. */
            /* RunEx2(); */

            /* Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n m, respectiv m,n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la tastaura. Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I rezultatul. */
            /* RunEx3(); */

            /* Scrieti o functie recursiva care va afisa in ordine elementele unui vector de intregi. */
            /* RunEx4(); */

            /* Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n, apelati-o si afisati-i rezultatul.*/
            /* RunEx5(); */

            /* Scrieti o functie recursiva care va calcula al n-lea element din sirul lui Fibonacci, n fiind citit de la tastatura, apelati-o si afisati-I rezultatul. */
            /* RunEx6(); */

            /* Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va afisa urmatoarea piramida a numerelor: 1 22 333 */
            /* RunEx7(); */

            /*Se citesc doua numere de la tastatura. Scrieti un program care va calcula cel mai mare divizor comun al numerelor  */
            /* RunSuplim1(); */

            /* Scrie un program care afiseaza numerele de la 1 la N. Daca numarul este multiplu de 3, sa se afiseze Fizz, daca este multiplu de 3 sa se afiseze Buzz, daca e multiplu si de 3 si de 5 (ex: 15) sa se afiseze FizzBuzz, in restul cazurilor sa se afiseze numarul. */
            /* RunSuplim2(); */
        }

        static void RunEx1()
        {
            Console.Write("Introduceti numarul de elemente al vectorului=");
            int[] vector = GetReverseVector(ReadVectorUnidimensional(int.Parse(Console.ReadLine())));
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(i + "=" + vector[i]);
            }
        }

        static void RunEx2()
        {
            Console.WriteLine("Introduceti cele 3 dimensiuni ale matricii:");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            int[,,] matrice = ReadMatriceTridimensionala(n, m, k);
            Console.WriteLine("Suma elemente = " + GetSumaElementeMatriceTridimensionala(matrice));
            Console.WriteLine("Element maxim = " + GetElementMaximMatriceTridimensionala(matrice));
        }

        static void RunEx3()
        {
            Console.Write("Dimensiunea n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Dimensiunea m=");
            int m = int.Parse(Console.ReadLine());
            int[,] produs = GetInmultireMatrici(ReadMatriceBidimensionala(n, m), ReadMatriceBidimensionala(m, n));
            for (int i = 0; i < produs.GetLength(0); i++)
            {
                for (int j = 0; j < produs.GetLength(1); j++)
                {
                    Console.Write(i + "," + j + "=");
                    Console.WriteLine(produs[i, j]);
                }
            }
        }

        static void RunEx4()
        {
            Console.Write("Introduceti numarul de elemente al vectorului=");
            int[] vector = ReadVectorUnidimensional(int.Parse(Console.ReadLine()));
            int[] orderedVector = OrderVector(vector);
            for (int i = 0; i < orderedVector.Length; i++)
            {
                Console.WriteLine(i + "=" + orderedVector[i]);
            }
        }

        static void RunEx5()
        {
            Console.Write("Introduceti n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Suma=");
            Console.Write(SumNumere(1, n));
        }

        static void RunEx6()
        {
            Console.Write("Introduceti n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Numarul n=");
            if (n <= 1)
            {
                Console.Write(n);
            }
            else
            {
                Console.Write(GetFibonacci(0, 1, 2, n));
            }
        }

        static void RunEx7()
        {
            Console.Write("Introduceti n=");
            int n = int.Parse(Console.ReadLine());
            ShowPyramid(1, n);
        }

        static void RunSuplim1()
        {
            Console.Write("Introduceti n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Divizor maxim=");
            Console.Write(GetDivizorMaxim(n, m));
        }

        static void RunSuplim2()
        {
            Console.Write("Introduceti n=");
            int n = int.Parse(Console.ReadLine());
            ShowFizzBuzz(n);
        }

        static int[] ReadVectorUnidimensional(int n)
        {
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + " = ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            return vector;
        }

        static int[,] ReadMatriceBidimensionala(int n, int m)
        {
            int[,] matrice = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(i + "," + j + "=");
                    matrice[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrice;
        }

        static int[,,] ReadMatriceTridimensionala(int n, int m, int k)
        {
            int[,,] matrice = new int[n, m, k];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int l = 0; l < k; l++)
                    {
                        Console.Write(i + "," + j + "," + l + "=");
                        matrice[i, j, l] = int.Parse(Console.ReadLine());
                    }
                }
            }
            return matrice;
        }

        static int[] GetReverseVector(int[] vector)
        {
            int[] reverseVector = new int[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                reverseVector[i] = vector[vector.Length - i - 1];
            }
            return reverseVector;
        }


        static int GetSumaElementeMatriceTridimensionala(int[,,] matrice)
        {
            int suma = 0;
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    for (int l = 0; l < matrice.GetLength(2); l++)
                    {
                        suma += matrice[i, j, l];
                    }
                }
            }
            return suma;
        }

        static int GetElementMaximMatriceTridimensionala(int[,,] matrice)
        {
            int max = matrice[0, 0, 0];
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    for (int l = 0; l < matrice.GetLength(2); l++)
                    {
                        if (matrice[i, j, l] > max)
                        {
                            max = matrice[i, j, l];
                        }
                    }
                }
            }
            return max;
        }

        static int[,] GetInmultireMatrici(int[,] matrice1, int[,] matrice2)
        {
            int[,] produs = new int[matrice1.GetLength(0), matrice2.GetLength(1)];
            for (int i = 0; i < matrice1.GetLength(0); i++)
            {
                for (int j = 0; j < matrice2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrice2.GetLength(0); k++)
                    {
                        produs[i, j] += matrice1[i, k] * matrice2[k, j];
                    }
                }
            }
            return produs;
        }

        static bool IsVectorOrdonat(int[] vector)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                if (vector[i] > vector[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        static int[] OrderVector(int[] vector)
        {
            if (IsVectorOrdonat(vector))
            {
                return vector;
            }

            int var;
            for (int i = 0; i < vector.Length - 1; i++)
            {
                if (vector[i] > vector[i + 1])
                {
                    var = vector[i];
                    vector[i] = vector[i + 1];
                    vector[i + 1] = var;
                }
            }

            return OrderVector(vector);
        }

        static int SumNumere(int crt, int n)
        {
            if (crt == n)
            {
                return crt;
            }

            return crt * SumNumere(crt + 1, n);
        }

        static int GetFibonacci(int n2, int n1, int crt, int n)
        {
            if (crt == n)
            {
                return n2 + n1;
            }

            return GetFibonacci(n1, n2 + n1, crt + 1, n);
        }

        static void ShowPyramid(int crt, int n)
        {
            if (crt > n)
            {
                return;
            }

            for (int i = 1; i <= crt; i++)
            {
                Console.Write(crt);
                if (i == crt)
                    Console.WriteLine("");
            }

            ShowPyramid(crt + 1, n);
        }

        static int GetDivizorMaxim(int n, int m)
        {
            int min, divizor = 1;
            if (n <= m)
            {
                min = n;
            }
            else
            {
                min = m;
            }

            for (int i = 1; i <= min; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    divizor = i;
                }
            }
            return divizor;
        }

        static void ShowFizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i%3==0)
                {
                    Console.Write("Fizz");
                }

                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }

                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write(i);
                }

                Console.WriteLine("");
            }
        }
    }
}
