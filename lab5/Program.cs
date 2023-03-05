using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            RunEx6();
        }

        static void RunEx1()
        {
            /* Scrieti un program care va afisa pozitia unui substring intr-un string, ambele siruri de caractere fiind citite de la tastatura */
            Console.Write("Introduceti stringul:");
            string str = Console.ReadLine();
            Console.Write("Introduceti substringul:");
            string substr = Console.ReadLine();

            Console.Write($"Pozitia ocupata de substring:{str.IndexOf(substr)}");
        }

        static void RunEx2()
        {
            /* Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom. */
            Console.Write("Introduceti sirul de caractere:");
            if (IsPalindrom(Console.ReadLine()))
            {
                Console.WriteLine("este palindrom");
            }
            else
            {
                Console.WriteLine("nu este palindrom");
            }
        }

        static bool IsPalindrom(string str)
        {
            for (var i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        static void RunEx3()
        {
            /* Scrieti un program care va numara toate aparitiile unui caracter intr-un sir de caractere. Atat caracterul cautat cat si sirul de caractere vor fi citite de la tastatura */
            Console.Write("Introduceti sirul de caractere:");
            string str = Console.ReadLine();
            Console.Write("Introduceti caracterul cautat:");
            char car = (char)Console.Read();

            Console.WriteLine($"Nr apartii:{GetNrAparitii(str, car)}");
        }

        static int GetNrAparitii(string str, char car)
        {
            int nr = 0;
            foreach (var litera in str.ToCharArray())
            {
                if (litera == car)
                {
                    nr++;
                }
            }
            return nr;
        }

        static void RunEx4()
        {
            /* Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit de la tastatura, ignorand caseing-ul literelor */
            Console.Write("Introduceti sirul de caractere:");
            string str = Console.ReadLine();

            int[] litere = new int[byte.MaxValue];

            foreach (var car in str.ToCharArray())
            {
                litere[((byte)Char.ToLower(car))]++;
            }

            var litera = 0;
            var aparitii = 0;
            for (var i = 0; i < litere.Length; i++)
            {
                if (litere[i] > aparitii)
                {
                    litera = i;
                    aparitii = litere[i];
                }
            }

            Console.Write($"Litera {((char)litera)} are {litere[litera]} aparitii");
        }

        static void RunEx5()
        {
            /* Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.*/
            Console.Write("Introduceti sirul de caractere:");
            string str = Console.ReadLine();
            Console.Write($"Sirul normalizat: {GetStringNormalizat(str)}");
        }

        static string GetStringNormalizat(string str)
        {
            char[] normalizat = new char[str.Length];
            for (var i = 0; i < str.Length; i++)
            {
                if (i == 0 || Char.IsWhiteSpace(str[i - 1]))
                {
                    normalizat[i] = Char.ToUpper(str[i]);
                }
                else
                {
                    normalizat[i] = Char.ToLower(str[i]);
                }
            }
            return new string(normalizat);
        }

        static void RunEx6()
        {
            /* Screiti un program care va numara vocalele dintr-un sir de caractere citit de la tastatura.*/
            Console.Write("Introduceti sirul de caractere:");
            string str = Console.ReadLine();
            Console.Write($"Nr vocale: {GetNrVocale(str)}");
        }

        static int GetNrVocale(string str)
        {
            int nr = 0;

            string vocale = "aeiou";

            foreach (var litera in str.ToCharArray())
            {
                if (vocale.IndexOf(char.ToLower(litera))>=0)
                {
                    nr++;
                }
            }

            return nr;
        }
    }
}
