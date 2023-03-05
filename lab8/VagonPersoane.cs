using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class VagonPersoane : Vagon
    {
        public int NumarLocuri { get; private set; }

        public VagonPersoane(int masa, int anFabricatie, int numarLocuri) : base(masa, anFabricatie)
        {
            this.NumarLocuri = numarLocuri;
        }

        public void Inchidere()
        {
            Console.WriteLine("se inchid usile");
        }

        public void Deschidere()
        {
            Console.WriteLine("se deschid usile");
        }        
    }
}
