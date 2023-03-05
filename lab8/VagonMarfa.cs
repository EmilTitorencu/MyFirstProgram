using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class VagonMarfa : Vagon
    {
        public TipMarfa TipMarfa { get; private set; }
        public int Capacitate { get; private set; }

        public VagonMarfa(int masa, int anFabricatie, TipMarfa tipMarfa, int capacitate) :base(masa, anFabricatie)
        {
            this.TipMarfa = tipMarfa;
            this.Capacitate = capacitate;
        }
    }
}
