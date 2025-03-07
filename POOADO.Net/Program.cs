using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace POOADO.Net
{
    internal class Program
    {
        public static void Main()
        {
            NpgsqlConnection maCo;
            string CHAINECONNEXION = "Server=127.0.0.1;Port=5432;User ID=postgres;Password=postgres;Database=Biblio;";
            maCo = new NpgsqlConnection(CHAINECONNEXION);
            int nb, choix;
            string requête;
            NpgsqlCommand maCde; // On pourra utiliser le même nom ici
            do
            {
                Console.WriteLine("\n1. Afficher les éditeurs - PubId, Name - dont le nom commence par une lettre donnée");
                Console.WriteLine("2. Ajouter un éditeur (saisis des seuls champs name, adress, city, zip) (affichage id généré)");
                Console.WriteLine("3. Supprimer un titre dans la table Titles (saisie de l'ISBN).");
                Console.WriteLine("4. Ajouter un titre dans la table  Titles, lui affecter un auteur, et un éditeur");
                Console.WriteLine("5. Quitter\n");
                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    // 1. Afficher les éditeurs - PubId, Name - dont le nom commence par une lettre donnée
                    case 1: 
                        {
                            try
                            {
                                maCo.Open();
                                requête = "Select PubId, Name from Publishers where Name like @lettre";
                                maCde = new NpgsqlCommand(requête, maCo);
                                Console.WriteLine("Lettre ?");
                                string lettre = Console.ReadLine();
                                maCde.Parameters.AddWithValue("@lettre", lettre+"%");
                                NpgsqlDataReader jeuEnregistrements;
                                jeuEnregistrements = maCde.ExecuteReader();
                                while (jeuEnregistrements.Read())
                                {
                                    Console.WriteLine(jeuEnregistrements["PubId"]);
                                    Console.WriteLine(jeuEnregistrements["Name"]);
                                }
                                jeuEnregistrements.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            finally
                            {
                                maCo.Close();
                            }

                            break;
                        }
                    // 2. Ajouter un éditeur (saisis des seuls champs name, adress, city, zip) (affichage id généré)
                    case 2:
                        {
                            try
                            {
                                maCo.Open();
                                Console.WriteLine("Nom (Name) ?");
                                string nom = Console.ReadLine();
                                Console.WriteLine("Adresse (Address) ?");
                                string adresse  = Console.ReadLine();
                                Console.WriteLine("Ville (City) ?");
                                string ville = Console.ReadLine();
                                Console.WriteLine("Code Postal (Zip) ?");
                                int codePostal = int.Parse(Console.ReadLine());
                                // pubid, serial, sera automatiquement renseigné par PostgreSQL
                                // les autres champs non renseignés seront à null
                                requête = "Insert into publishers (name,address, city, zip) values (@nom, @adresse,@ville, @codePostal)  RETURNING pubid";
                                maCde = new NpgsqlCommand(requête, maCo);
                                maCde.Parameters.AddWithValue("@nom", nom);
                                maCde.Parameters.AddWithValue("@adresse", adresse);
                                maCde.Parameters.AddWithValue("@ville", ville);
                                maCde.Parameters.AddWithValue("@codePostal", codePostal);

                                // Si on ne souhaite pas connaître l'id généré : RETURNING pubid dans SELECT inutile
                                // int nb = maCde.ExecuteNonQuery(); 
                                // nb : nombre de ligne affectée par la requête (1 en cas de succès, 0 si échec)

                                // Si ON SOUHAITE connaître l'id généré (cas de l'énoncé). RETURNING pubid obligatoire
                                int noEditeur = (int)(maCde.ExecuteScalar());
                                Console.WriteLine("\nn° éditeur inséré : " + noEditeur.ToString() + "\n");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            finally
                            {
                                maCo.Close();
                            }
                            break;
                        }
                    case 3: // 3. Supprimer un titre dans la table 'Titles'
                        {
                            string ISBNASupp;
                            try
                            {
                                maCo.Open(); // ouverture de la connexion, à mettre dans le Try
                                                   // au cas où : problème réseau, SGBDR à l'arrêt etc.. 
                                Console.Write("ISBN du titre à supprimer ? ");
                                ISBNASupp = Console.ReadLine();
                                // On supp. d'abord les lignes associant titre à auteur (association)
                                // Si on supp. d'abord le titre, Title dans 'TitleAuthor' fera référence
                                // à un titre inexistant : violation de contrainte  de clé étrangère
                                requête = "DELETE FROM titleauthor WHERE ISBN=@ISBN";
                                maCde = new NpgsqlCommand(requête, maCo);
                                maCde.Parameters.AddWithValue("@ISBN", ISBNASupp);
                                nb = maCde.ExecuteNonQuery();
                                Console.WriteLine("Suppression de " + nb.ToString() + " ligne(s) dans TitleAuthor");
                                requête = "DELETE FROM titles WHERE ISBN=@ISBN";
                                maCde = new NpgsqlCommand(requête, maCo);
                                maCde.Parameters.AddWithValue("@ISBN", ISBNASupp);
                                nb = maCde.ExecuteNonQuery();
                                Console.WriteLine("Suppression de " + nb.ToString() + " ligne(s) dans Titles");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            finally
                            {
                                maCo.Close();
                            }
                            break;
                        }
                    case 4: // 4. Ajouter un titre dans la table Titles, lui affecter un auteur, et un éditeur
                        {
                            // on peut associer plusieurs auteurs,ici on se contentera d'un
                            try
                            {
                                maCo.Open();
                                Console.WriteLine("Titre ?");
                                string titleLu = Console.ReadLine();
                                Console.WriteLine("ISBN ?");
                                string isbnLu = Console.ReadLine();
                                Console.WriteLine("Année publication ?");
                                int year_publishedLu = int.Parse(Console.ReadLine());
                                // ////////// ON VERIFIE QUE L'EDITEUR EXISTE DANS publishers (NON DEMANDE !)
                                Int32 n;
                                int pubIdLu;
                                do // pubid dans Title doit exister dans Publishers
                                {
                                    // pubid est clé étrangère en référence à pubid dans Publishers
                                    Console.WriteLine("Identifiant de l'éditeur ?");
                                    pubIdLu = int.Parse(Console.ReadLine());
                                    requête = "select count(*) FROM publishers WHERE pubid=@pubid";
                                    maCde = new NpgsqlCommand(requête, maCo);
                                    maCde.Parameters.AddWithValue("@pubid", pubIdLu);
                                    n = Convert.ToInt32(maCde.ExecuteScalar());
                                    if (n == 0)
                                        Console.WriteLine("Identifiant de l'éditeur non trouvé. Ressaisir");
                                }
                                while (n != 1);
                                Console.WriteLine("Description ?");
                                string descriptionLu = Console.ReadLine();
                                Console.WriteLine("Notes ?");
                                string notesLu = Console.ReadLine();
                                Console.WriteLine("Sujet ?");
                                string subjectLu = Console.ReadLine();
                                Console.WriteLine("Commentaires ?");
                                string commentsLu = Console.ReadLine();

                                // //////// INSERTION DU LIVRE
                                requête = "Insert into titles values (@title, @year_published, @isbn, @pubid, @description, @notes, @subject, @comments)";
                                maCde = new NpgsqlCommand(requête, maCo);
                                maCde.Parameters.AddWithValue("@title", titleLu);
                                maCde.Parameters.AddWithValue("@year_published", year_publishedLu);
                                maCde.Parameters.AddWithValue("@isbn", isbnLu);
                                maCde.Parameters.AddWithValue("@pubid", pubIdLu);
                                maCde.Parameters.AddWithValue("@description", descriptionLu);
                                maCde.Parameters.AddWithValue("@notes", notesLu);
                                maCde.Parameters.AddWithValue("@subject", subjectLu);
                                maCde.Parameters.AddWithValue("@comments", commentsLu);
                                Console.WriteLine(requête);
                                // ExecuteNonQuery ... pas de retour de résultat
                                // n : nombre de ligne affectée par la requête (1 ici)
                                nb = maCde.ExecuteNonQuery();
                                Console.WriteLine("\nInsertion de " + nb.ToString() + " ligne(s)\n");

                                // /////////// AFFECTATION D'UN AUTEUR AU LIVRE 
                                // on saisit le Nom, Prénom de l'auteur 
                                // (champ author, cf. base Biblio)
                                // on retrouve l'identifiant correspondant à ces 
                                // Nom, Prénom, et on insère
                                // Ici on considère qu'il n'y a pas de doublons 
                                // (deux auteurs avec mêmes Nom, Prénom)
                                string AuteurLu;
                                do // on regarde si l'auteur existe (NON DEMANDE !)
                                {
                                    Console.WriteLine("Auteur (Nom, Prénom) ?");
                                    AuteurLu = Console.ReadLine();
                                    requête = "select count(*) FROM authors WHERE author=@author";
                                    maCde = new NpgsqlCommand(requête, maCo);
                                    maCde.Parameters.AddWithValue("@author", AuteurLu);
                                    n = Convert.ToInt32(maCde.ExecuteScalar());
                                    // Un simple Cast ne fonctionne pas, cas ou null retourné
                                    if (n == 0)
                                    {
                                        Console.WriteLine("Pas d'auteur avec ce nom.");
                                    }
                                }
                                while (n != 1);
                                // Lorsque l'on est sortie de la boucle, on a un auteur qui existe
                                // on va rechercher son identifiant au_id (identifiant auteur)
                                requête = "select au_id FROM authors WHERE author=@author";

                                maCde = new NpgsqlCommand(requête, maCo);
                                maCde.Parameters.AddWithValue("@author", AuteurLu);

                                NpgsqlDataReader jeuEnregistrements;
                                jeuEnregistrements = maCde.ExecuteReader();
                                jeuEnregistrements.Read(); // on a qu'un ligne à lire
                                int IdentifiantAuteur;
                                IdentifiantAuteur = Convert.ToInt32(jeuEnregistrements["au_id"]);
                                jeuEnregistrements.Close();
                                // INSERTION dans titleauthor
                                requête = "Insert into titleauthor values (@isbn, @au_id)";
                                maCde = new NpgsqlCommand(requête, maCo);
                                maCde.Parameters.AddWithValue("@isbn", isbnLu);
                                maCde.Parameters.AddWithValue("@au_id", IdentifiantAuteur);

                                n = maCde.ExecuteNonQuery();
                                Console.WriteLine("\nInsertion de " + n.ToString() + " ligne(s) dans titleauthor\n");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            finally
                            {
                                maCo.Close();
                            }

                            break;
                        }
                    case 5: // 5. Quitter
                        {
                            Console.WriteLine("Au revoir.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Choix erroné...");
                            break;
                        }
                }
            }
            while (choix != 5);
        }
    }
}
