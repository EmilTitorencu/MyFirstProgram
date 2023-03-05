using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Dulap
    {
        private int lungime;
        private int latime;
        private int inaltime;

        public Dulap(int lungime, int latime, int inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }

        public int GetVolum()
        {
            return this.latime * this.lungime * this.inaltime;
        }
    }
}
