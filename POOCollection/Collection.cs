using System;
using System.Collections.Generic;
using System.Text;

namespace POOCollection
{
    public class Collection
    {
        private const int MAX = 10;
        private Entree[] tableau = new Entree[MAX - 1];
        private int positionLibre;

        public Collection()
        {
            positionLibre = 0;
        }

        private int GetPosition(string cle)
        {
            // On cherche dans tableau l'élément ayant pour clé 'cle',
            // si trouvé on retourne son index (position dans le tableau), 
            // sinon on retourne -1
            int i = 0;

            if (positionLibre == 0) return -1; // On sort directement

            while ((tableau[i].GetCle() != cle) & (i < positionLibre - 1))
                i = i + 1;

            if (tableau[i].GetCle() == cle)
            {
                return i;
            }
            else
            {
                return -1;
            } // On a pas trouvé
        }

        public bool Ajouter(string cle, object valeur)
        {
            if (Existe(cle) | positionLibre > MAX) // on aurait pu écrire this.Existe(cle)
            {
                // la clé est présente, on ne fait pas l'ajout et on retourne faux
                // ou le tableau est plein
                return false;
            }
            else
            {
                // On créer un objet Entrée, 
                // que l'on ajoute dans la première case libre du tableau
                tableau[positionLibre] = new Entree(cle, valeur);
                positionLibre = positionLibre + 1;
                return true;
            }
        }

        public object Retourner(string cle)
        {
            int i = 0;
            i = GetPosition(cle);
            if (i != -1) // Trouvé
            {
                return tableau[i].GetValeur(); // Retourne l'objet associé à la clé
            }
            else // La clé n'est pas présente
            {
                return null;
            }
        }

        public bool Supprimer(string cle)
        {
            int i, j;
            i = GetPosition(cle);
            if (i != -1) // clé Trouvé
            {
                // Tassement vers la droite
                // On écrase la case en décalant vers la gauche 
                // les autres cases du tableau 
                for (j = i; j <= positionLibre - 2; j++)
                    tableau[j] = tableau[j + 1];

                positionLibre = positionLibre - 1;
                return true;
            }
            else // clé non trouvée
            {
                return false;
            }
        }

        public bool Existe(string cle)
        {
            return GetPosition(cle) != -1;
        }

        public void Vider()
        {
            positionLibre = 0;
            // Toutes les cases sont libres (à partir de la case 0)
        }

        public int NombreDElements()
        {
            // L'index de position libre correspond 
            // au nb d'éléments dans le tableau
            return positionLibre;
        }

        public override string ToString()
        {
            int i;
            string chaine = "";
            for (i = 0; i <= positionLibre - 1; i++)
                chaine = chaine + "\n" + tableau[i].ToString();
            return chaine;
        }
    }
}
