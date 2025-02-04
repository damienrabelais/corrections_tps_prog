using System;
using System.Collections.Generic;
using System.Text;

namespace POOCollection
{
    public class Entree
    {
        private string cle;
        private object valeur;

        public Entree(string pCle, object pValeur)
        {
            cle = pCle;
            valeur = pValeur;
        }
        public string GetCle()
        {
            return cle;
        }
        public object GetValeur()
        {
            return valeur;
        }
        public override string ToString()
        {
            return "Clé : " + cle + "\nValeur : " + valeur.ToString();
        }
    }
}
