using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Autoturism auto1 = new Autoturism("Ford","Mondeo",2018,4,new Motor(2000,150,"benzina"));
            Autoturism auto2 = new Autoturism("Skoda", "Octavia", 2020, 4, new Motor(2500, 160, "motorina"));
            Console.WriteLine(Autoturism.puternic.Description);            
        }
    }
}
