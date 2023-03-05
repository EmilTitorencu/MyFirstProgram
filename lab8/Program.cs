using System;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {            
            Tren tren = new Tren("cursa Bucuresti  - Constanta", new Locomotiva());
            tren.AdaugareVagon(new VagonMarfa(1000,2020,TipMarfa.Cereale,100));
            tren.AdaugareVagon(new VagonMarfa(1100, 2019, TipMarfa.Carbuni, 110));
            tren.AdaugareVagon(new VagonPersoane(1200,2015,100));
            tren.AdaugareVagon(new VagonPersoaneClasa1(1200, 2015, 100));

            /*tren.Plecare();
            tren.Sosire();*/

            Console.WriteLine($"nr total de locuri {tren.NumarDeLocuri}");

            int[] sumar = tren.SumarMarfa;
            Console.WriteLine($"capacitate cereale {sumar[(int)TipMarfa.Cereale]}");
            Console.WriteLine($"capacitate carbuni {sumar[(int)TipMarfa.Carbuni]}");
            Console.WriteLine($"capacitate otel {sumar[(int)TipMarfa.Otel]}");
        }
    }
}
