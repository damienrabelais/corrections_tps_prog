using System;
using System.Collections.Generic;
using System.Text;

namespace POOHeritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("///TEST VEHICULE////");
            //Vehicule v;
            //v = new Vehicule("VU01", "DS", 50);
            //Console.WriteLine(v);


            Console.WriteLine("\n\n///TEST VEHICULE UTILITAIRE////\n");
            VehiculeUtilitaire vUtilitaire;
            vUtilitaire = new VehiculeUtilitaire(
            "VU10", "Citroën Jumpy I", 100, 1000,
            4.5, 3, 2
            );
            Console.WriteLine(vUtilitaire);
            Console.WriteLine("Volume : " + vUtilitaire.volume().ToString());
            Console.WriteLine("Coût location : " + vUtilitaire.CoutLocation(10).ToString());


            Console.WriteLine("\n\n///TEST VEHICULE TOURISME////\n");
            VehiculeTourisme vTourisme;
            vTourisme = new VehiculeTourisme(
            "VU22", "Simca Aronde", 50, 5, 4, false
            );
            Console.WriteLine(vTourisme);
            Console.WriteLine("Coût location : " + vTourisme.CoutLocation(10).ToString());

            Console.ReadLine();


        }
    }
}
