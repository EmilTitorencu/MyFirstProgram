using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class Tren
    {
        private readonly string nume;
        private readonly Locomotiva locomotiva;
        private List<Vagon> vagoane;

        public Tren(string nume, Locomotiva locomotiva)
        {
            this.nume = nume;
            this.locomotiva = locomotiva;
            this.vagoane = new List<Vagon>();
        }

        public void AdaugareVagon(Vagon vagon)
        {
            vagoane.Add(vagon);
        }

        public void Plecare()
        {
            foreach(Vagon vagon in vagoane)
            {
                if (vagon is VagonPersoane)
                {
                    VagonPersoane vagonPersoane = vagon as VagonPersoane;
                    vagonPersoane.Inchidere();
                }
            }
            locomotiva.Pornire();
            Console.WriteLine("se porneste trenul");
        }

        public void Sosire()
        {
            Console.WriteLine("se opreste trenul");
            locomotiva.Oprire();
            foreach (Vagon vagon in vagoane)
            {

                if (vagon is VagonPersoaneClasa1)
                {
                    VagonPersoaneClasa1 vagonPersoaneClasa1 = vagon as VagonPersoaneClasa1;
                    vagonPersoaneClasa1.OprireAC();
                }
                if (vagon is VagonPersoane)
                {
                    VagonPersoane vagonPersoane = vagon as VagonPersoane;
                    vagonPersoane.Deschidere();
                }
            }
        }

        public int NumarDeLocuri
        {
            get
            {
                int numar=0;
                foreach (Vagon vagon in vagoane)
                {
                    if (vagon is VagonPersoane)
                    {
                        VagonPersoane vagonPersoane = vagon as VagonPersoane;
                        numar += vagonPersoane.NumarLocuri;                        
                    }
                }
                return numar;
            }
        }

        public int[] SumarMarfa
        {
            get
            {
                int[] sumar = new int[3];
                foreach (Vagon vagon in vagoane)
                {
                    if (vagon is VagonMarfa)
                    {
                        VagonMarfa vagonMarfa = vagon as VagonMarfa;
                        switch (vagonMarfa.TipMarfa)
                        {
                            case TipMarfa.Cereale:
                                sumar[(int)TipMarfa.Cereale] += vagonMarfa.Capacitate;
                                break;
                            case TipMarfa.Carbuni:
                                sumar[(int)TipMarfa.Carbuni] += vagonMarfa.Capacitate;
                                break;
                            case TipMarfa.Otel:
                                sumar[(int)TipMarfa.Otel] += vagonMarfa.Capacitate;
                                break;
                        }
                        
                    }
                }
                return sumar;
            }
        }
    }
}
