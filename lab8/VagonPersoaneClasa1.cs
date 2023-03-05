using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class VagonPersoaneClasa1 : VagonPersoane
    {
        public VagonPersoaneClasa1(int masa, int anFabricatie, int numarLocuri) : base(masa, anFabricatie, numarLocuri)
        {
        }

        public void OprireAC()
        {
            Console.WriteLine("se opreste AC");
        }

        public void PornireAC()
        {
            Console.WriteLine("se porneste AC");
        }
    }
}
