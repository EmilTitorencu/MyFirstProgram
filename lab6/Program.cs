using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Autoturisme();
        }

        static void VolumDulap()
        {
            Dulap dulap = new Dulap(2, 3, 4);
            Console.WriteLine($"Volumul dulapului:{dulap.GetVolum()}");
        }

        static void Autoturisme()
        {
            Autoturism auto1 = new Autoturism("Ford","B79FVO",1000);
            auto1.Tiparire();
            Autoturism auto2 = new Autoturism("Skoda", "B80FVO", 1500);
            auto2.Tiparire();
        }
    }
}
