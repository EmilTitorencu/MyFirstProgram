using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Autoturism
    {
        private string marca;
        private string numarDeInmatriculare;
        private int capacitateCilindrica;

        public Autoturism(string marca, string numarDeInmatriculare, int capacitateCilindrica)
        {
            this.marca = marca;
            this.numarDeInmatriculare = numarDeInmatriculare;
            this.capacitateCilindrica = capacitateCilindrica;
        }

        /// <summary>
        /// Afiseaza caracteristicile masinii
        /// </summary>
        public void Tiparire()
        {
            Console.WriteLine($"{this.marca}, {this.numarDeInmatriculare}, {this.capacitateCilindrica}");
        }
    }
}
