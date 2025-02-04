using System;
using System.Collections.Generic;
using System.Text;

namespace POOCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection MaCollection;
            MaCollection = new Collection();
            MaCollection.Ajouter("22", "Côtes d'armor");
            MaCollection.Ajouter("35", "Ille Et Vilaine");
            MaCollection.Ajouter("29", "Finistère");
            MaCollection.Ajouter("56", "Morbihan");
            Console.WriteLine(MaCollection.Retourner("29"));
            Console.WriteLine(MaCollection.ToString());
            Console.WriteLine(MaCollection.NombreDElements());
            Console.WriteLine(MaCollection.Existe("89"));
            Console.WriteLine(MaCollection.Existe("35"));
            Console.WriteLine(MaCollection.Supprimer("22"));
            Console.WriteLine(MaCollection.Supprimer("29"));
            Console.WriteLine(MaCollection.Supprimer("45"));
            Console.WriteLine(MaCollection.ToString());
            MaCollection.Vider();
            Console.WriteLine("////////////////////////////////");
            Console.WriteLine(MaCollection);
            // le ".ToString" n'est pas nécessaire
            Console.ReadLine();

        }
    }
}
