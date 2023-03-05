using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    abstract class Vagon
    {
        private readonly int masa;
        private readonly int anFabricatie;

        public Vagon(int masa, int anFabricatie)
        {
            this.masa = masa;
            this.anFabricatie = anFabricatie;
        }
    }
}
