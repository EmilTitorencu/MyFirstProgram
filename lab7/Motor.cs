using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Motor
    {
        public readonly int capacitateCilindrica;
        public readonly int putere;
        public readonly string tipCombustibil;

        public Motor(int capacitateCilindrica, int putere, string tipCombustibil)
        {
            this.capacitateCilindrica = capacitateCilindrica;
            this.putere = putere;
            this.tipCombustibil = tipCombustibil;
        }

        public void Pornire()
        {
            Console.WriteLine("brr");
        }

        public void Oprire()
        {
            Console.WriteLine("par poc pac");
        }
    }
}
