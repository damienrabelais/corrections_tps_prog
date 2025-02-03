using System;
using System.Collections.Generic;
using System.Text;

namespace POOComplexe
{
    internal class Program
    {
        private const int MAX = 20;

        public static Complexe SaisirComplexe()
        {
            double xLu, yLu;
            Console.WriteLine("\nPartie réelle ?");
            xLu = double.Parse(Console.ReadLine());
            Console.WriteLine("\nPartie imaginaire ?");
            yLu = double.Parse(Console.ReadLine());
            return new Complexe(xLu, yLu);
        }

        public static int Menu()
        {
            int choix;
            Console.WriteLine("\n1. Afficher la somme de deux nombres complexes saisis par l’utilisateur");
            Console.WriteLine("2. Afficher la soustraction de deux nombres complexes saisis par l’utilisateur");
            Console.WriteLine("3. Afficher le produit de deux nombres complexes saisis par l’utilisateur");
            Console.WriteLine("4. Afficher l'inverse d’un nombre complexe saisi par l’utilisateur");
            Console.WriteLine("5. Afficher le module d’un nombre complexe saisi par l’utilisateur");
            Console.WriteLine("6. Ajouter un Complexe dans un tableau");
            Console.WriteLine("7. Faire la somme des nombres complexes du tableau.");
            Console.WriteLine("8. Quitter");
            choix = int.Parse(Console.ReadLine());
            return choix;
        }

        public static void Main()
        {
            // Notez que pour l'affichage des résultats  la chose est un peu rustique
            // c'est le prix à payer de la concision
            int choixSaisi, positionLibre = 0, i;
            Complexe[] lesComplexes = new Complexe[MAX - 1];
            Complexe somme;
            do
            {
                choixSaisi = Menu();
                switch (choixSaisi)
                {
                    case 1:
                        {
                            Console.WriteLine(SaisirComplexe().Addition(SaisirComplexe()).ToString());
                            break;
                        }
                    // Si a et b deux complexes : a.Addition(b) (appel ToString sur rés. de l’addition)
                    case 2:
                        {
                            Console.WriteLine(SaisirComplexe().Soustraction(SaisirComplexe())); // idem
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(SaisirComplexe().Produit(SaisirComplexe())); // idem
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(SaisirComplexe().Inverse()); // idem
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine(SaisirComplexe().GetModule());
                            break;
                        }
                    case 6:
                        {
                            if (positionLibre <= MAX)
                            {
                                lesComplexes[positionLibre] = SaisirComplexe();
                                positionLibre = positionLibre + 1;
                            }
                            else
                            {
                                Console.WriteLine("Tableau plein.");
                            }
                            break;
                        }
                    case 7:
                        {
                            somme = new Complexe(0d, 0d);
                            for (i = 0; i <= positionLibre - 1; i++)
                                somme = somme.Addition(lesComplexes[i]);
                            Console.WriteLine(somme); // Appel implicite toString
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Au revoir.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Erreur de saisie.");
                            break;
                        }
                }
            }
            while (choixSaisi != 8);
        }

    }
}
