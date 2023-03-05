using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Autoturism
    {
        private readonly Motor motor;
        private readonly string marca;
        private readonly string model;
        private readonly int anFabricatie;
        private readonly Usa[] usi;

        public static int nrAutovehicule;
        public static Autoturism puternic;

        public Autoturism(string marca, string model, int anFabricatie, int nrUsi, Motor motor)
        {
            this.motor = motor;
            this.marca = marca;
            this.model = model;
            this.anFabricatie = anFabricatie;
            this.usi = new Usa[nrUsi];
            for (int i=0;i<nrUsi;i++)
            {
                this.usi[i] = new Usa();
            }
            nrAutovehicule++;
            if (nrAutovehicule==1 || motor.putere>puternic.motor.putere)
            {
                puternic = this;
            }
        }

        public string GetDescription()
        {
            return $"{this.marca} {this.model} {this.anFabricatie} {this.motor.capacitateCilindrica} {this.motor.putere} {this.motor.tipCombustibil} {this.usi.Length}";
        }

        public string Description
        {
            get
            {
                return $"{this.marca} {this.model} {this.anFabricatie} {this.motor.capacitateCilindrica} {this.motor.putere} {this.motor.tipCombustibil}  {this.usi.Length}";
            }
        }

        public void Pornire()
        {
            Console.WriteLine("masina porneste");
            foreach (var usa in this.usi)
            {
                usa.Inchide();
            }
            this.motor.Pornire();
        }

        public void Oprire()
        {
            Console.WriteLine("masina se opreste");
            this.motor.Oprire();
            foreach (var usa in this.usi)
            {
                usa.Deschide();
            }
            
        }
    }
}
