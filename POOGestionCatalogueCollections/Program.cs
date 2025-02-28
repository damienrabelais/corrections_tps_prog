using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace POOGestionCatalogueCollections
{
    class Program
    {
        public static void Charger(Hashtable pCollection, string pCheminFichier)
        {
            StreamReader monStreamReader;
            string ligne;
            string[] champs;
            Produit produitLu;
            try
            {
                // Création d'une instance de StreamReader pour permettre la lecture de notre CheminDuFichier
                monStreamReader = new StreamReader(pCheminFichier);
                //Lecture de toutes les lignes et affichage de chacune sur la page
                ligne = monStreamReader.ReadLine();
                while (ligne != null)
                {
                    champs = ligne.Split(';');
                    produitLu = new Produit(champs[1], double.Parse(champs[2]), double.Parse(champs[3]));
                    pCollection.Add(champs[0], produitLu);
                    ligne = monStreamReader.ReadLine();
                }
                monStreamReader.Close(); // Fermeture du StreamReader (! Ne pas oublier)
            }
            catch (Exception ex)
            {
                //Code exécuté en cas d'erreur
                Console.WriteLine("Une erreur est survenue au cours de la lecture !");
                Console.WriteLine(ex.Message);
            }
        } // méthode Charger

        public static void Sauvegarder(Hashtable pCollection, string pCheminFichier)
        {
            StreamWriter monStreamWriter;
            try
            {
                //Instanciation du StreamWriter avec passage du nom du CheminDuFichier 
                monStreamWriter = new StreamWriter(pCheminFichier);
                // Ecriture du texte dans votre CheminDuFichier
                foreach (DictionaryEntry entrée in pCollection)
                {
                    monStreamWriter.WriteLine(entrée.Key + ";" + ((Produit)entrée.Value).ToCSV());
                }
                //Fermeture du StreamWriter (Trés important)
                monStreamWriter.Close();
            }
            catch (Exception ex)
            {
                // Code exécuté en cas d'exception
                Console.WriteLine(ex.Message);
            }
        } // Sauvegarder

        public static void Main(string[] args)
        {
            Hashtable Catalogue;

            Produit unProduit, prodCherché;
            string référenceSaisie, designationSaisie;
            double pourcentageSaisi, nouveauTauxTVA;
            double prixHTSaisi, tauxTVASaisie;
            int Choix;
            bool Trouvé;

            Catalogue = new Hashtable();
            // charger la collection avec le fichier
            Charger(Catalogue, @"C:\TPsVBC#\Catalogue.txt");

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Ajouter un produit au catalogue ");
                Console.WriteLine("2. Augmenter le prix HT d'un produit");
                Console.WriteLine("3. Baisser le prix HT d'un produit");
                Console.WriteLine("4. Modifier le taux de TVA d'un produit");
                Console.WriteLine("5. Augmenter tous les produits du catalogue");
                Console.WriteLine("6. Supprimer un produit du catalogue");
                Console.WriteLine("7. Afficher toutes les informations sur tous les produits (inc. Prix TTC)");
                Console.WriteLine("8. Afficher toutes les informations sur un produit (inc. Prix TTC)");
                Console.WriteLine("9. Vider le catalogue");
                Console.WriteLine("10. Quitter");
                Console.WriteLine("Choix ?");
                Choix = int.Parse(Console.ReadLine());
                switch (Choix)
                {
                    case 1: // 1. Ajouter un produit au catalogue
                        {
                            Console.WriteLine("\nSaisir la désignation du produit.");
                            designationSaisie = Console.ReadLine();
                            Console.WriteLine("Saisir le prix HT du produit.");
                            prixHTSaisi = double.Parse(Console.ReadLine());
                            Console.WriteLine("Saisir le taux de TVA du produit.");
                            tauxTVASaisie = double.Parse(Console.ReadLine());
                            unProduit = new Produit(designationSaisie, prixHTSaisi, tauxTVASaisie);
                            do
                            {
                                Trouvé = false;
                                Console.WriteLine("Saisir la référence du produit.");
                                référenceSaisie = Console.ReadLine();
                                if (Catalogue.ContainsKey(référenceSaisie))
                                {
                                    Console.WriteLine("Référence déjà dans la collection.");
                                    Trouvé = true;
                                }
                            }
                            while (Trouvé);
                            Catalogue.Add(référenceSaisie, unProduit);
                            break;
                        }

                    case 2: // 2. Augmenter le prix HT d'un produit
                        {
                            Console.WriteLine("\nRéférence du produit ?");
                            référenceSaisie = Console.ReadLine();
                            prodCherché = (Produit)Catalogue[référenceSaisie];
                            if (prodCherché is null)
                            {
                                Console.WriteLine("Non trouvé");
                            }
                            else
                            {
                                Console.WriteLine("Pourcentage d'augmentation ?");
                                pourcentageSaisi = double.Parse(Console.ReadLine());
                                prodCherché.AugmenterPrix(pourcentageSaisi);
                            }
                            break;
                        }

                    case 3: // 3. Baisser le prix HT d'un produit
                        {
                            Console.WriteLine("\nRéférence du produit ?");
                            référenceSaisie = Console.ReadLine();
                            prodCherché = (Produit)Catalogue[référenceSaisie];
                            if (prodCherché is null)
                            {
                                Console.WriteLine("Non trouvé");
                            }
                            else
                            {
                                Console.WriteLine("Pourcentage de baisse ?");
                                pourcentageSaisi = double.Parse(Console.ReadLine());
                                prodCherché.BaisserPrix(pourcentageSaisi);
                            }

                            break;
                        }

                    case 4: // 4. Modifier le taux de TVA d'un produit
                        {
                            Console.WriteLine("\nRéférence du produit ?");
                            référenceSaisie = Console.ReadLine();
                            prodCherché = (Produit)Catalogue[référenceSaisie];
                            if (prodCherché is null)
                            {
                                Console.WriteLine("Non trouvé");
                            }
                            else
                            {
                                Console.WriteLine("Nouveau taux de TVA ?");
                                nouveauTauxTVA = double.Parse(Console.ReadLine());
                                prodCherché.SetTauxTVA(nouveauTauxTVA);
                            }

                            break;
                        }

                    case 5: // 5. Augmenter tous les produits du catalogue
                        {
                            Console.WriteLine("\nPourcentage d'augmentation ?");
                            pourcentageSaisi = double.Parse(Console.ReadLine());
                            foreach (Produit prod in Catalogue.Values)
                                prod.AugmenterPrix(pourcentageSaisi);
                            break;
                        }

                    case 6: // 6. Supprimer un produit du catalogue
                        {
                            Console.WriteLine("\nRéférence du produit ?");
                            référenceSaisie = Console.ReadLine();
                            if (!Catalogue.ContainsKey(référenceSaisie))
                            {
                                Console.WriteLine("Non trouvé");
                            }
                            else
                            {
                                Catalogue.Remove(référenceSaisie);
                                Console.WriteLine("Produit supprimé.");
                            }

                            break;
                        }

                    case 7: // 7. Afficher toutes les informations sur tous les produits (inc. Prix TTC)
                        {
                            foreach (DictionaryEntry entrée in Catalogue)
                            {
                                Console.WriteLine("\nRéférence : " + (string)entrée.Key);
                                Console.WriteLine("Désignation : " + ((Produit)(entrée.Value)).GetDesignation());
                                Console.WriteLine("Prix HT : " + ((Produit)(entrée.Value)).GetPrixHT().ToString());
                                Console.WriteLine("Taux de TVA : " + ((Produit)(entrée.Value)).GetTauxTVA().ToString());
                                Console.WriteLine("Prix TTC : " + ((Produit)(entrée.Value)).GetPrixTTC().ToString());
                                Console.WriteLine("");
                            }
                            break;
                        }
                    case 8: // 8. Afficher toutes les informations sur un produit (inc. Prix TTC)
                        {
                            Console.WriteLine("\nRéférence du produit ?");
                            référenceSaisie = Console.ReadLine();
                            prodCherché = (Produit)Catalogue[référenceSaisie];
                            if (prodCherché is null)
                            {
                                Console.WriteLine("Non trouvé");
                            }
                            else
                            {
                                Console.WriteLine("Désignation : " + prodCherché.GetDesignation());
                                Console.WriteLine("Prix HT : " + prodCherché.GetPrixHT().ToString());
                                Console.WriteLine("Taux de TVA : " + prodCherché.GetTauxTVA().ToString());
                                Console.WriteLine("Prix TTC : " + prodCherché.GetPrixTTC().ToString());
                            }

                            break;
                        }

                    case 9: // 9. Vider le catalogue
                        {
                            Catalogue.Clear();
                            break;
                        }

                    case 10:
                        {
                            Console.WriteLine("Au revoir.");
                            Sauvegarder(Catalogue, @"C:\TPsVBC#\Catalogue.txt");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\nChoix erroné.");
                            break;
                        }
                }
            }
            while (Choix != 10);
            Console.ReadLine();
        }
    }

}
