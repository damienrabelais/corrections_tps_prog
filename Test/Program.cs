using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {


    


            Compte c1; // c1 pointera vers un objet Compte, avant instanciation valeur = null


            // création de l'objet de c1 (instanciation)
            c1 = new Compte("450D12", "Martin", 1000d);

            Console.WindowWidth = 160;
            Console.WriteLine("Solde (Propriété) : " + c1.Solde.ToString());
           c1.Solde = 4512;

          
            Console.WriteLine("Solde (Propriété) : " + c1.Solde.ToString());
            /*
             * C.W(hd.Taille);
             * hd.Taille = 20To;
             * 
             * p.Frequence = 500GH;
             * 
             * 
             * 
             * */
            

            Console.ReadLine();
        }
    }
}
