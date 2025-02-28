using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Compte

    {
        private string numéro;
        private string nom;
        private double solde;

        public Compte(string nouvNuméro, string nouvNom, double nouvSolde)
        // ! ! CONSTRUCTEUR ! !
        {
            numéro = nouvNuméro;
            nom = nouvNom;
            solde = nouvSolde;
        }

        public Compte() // ! ! CONSTRUCTEUR ! !
        {
            numéro = "";
            nom = "";
            solde = 0;
        }

        public string GetNuméro()
        {
            return numéro;

        }
       public string GetNomTitulaire()
        {
            return nom;
        }


       public void SetNomTitulaire(string nouvNom)
       {
            nom = nouvNom;
       }

       public double GetSolde()
        {

            return solde;
        }

        public bool Crediter(double montant)
        {
            if (montant > 0)
            {
               solde = solde + montant;
                return true;
            }
            else
            {
                return false;
            }
        }


        public string Numéro
        {
            get { return numéro; }
        }
        public string NomTitulaire
        {
            get { return nom; }
            set { nom = value; }
        }

        public double Solde
        {
            get { return solde; }
            set { solde = 9999999; }
        }

        public bool Debiter(double montant)
        {
            if (montant > 0 && solde - montant > 0)
            {
                solde = solde - montant;
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
