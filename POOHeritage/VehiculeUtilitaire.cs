using System;
using System.Collections.Generic;
using System.Text;

namespace POOHeritage
{
    public class VehiculeUtilitaire : Vehicule
    {
        private double chargeUtile;
        private double longueur;
        private double largeur;
        private double hauteur;

        public VehiculeUtilitaire(
            string code, string libelle, double prixJour,
            double chargeUtile, double longueur, double largeur, double hauteur
            ) : base(code, libelle, prixJour)
        {
            this.chargeUtile = chargeUtile;
            this.longueur = longueur;
            this.largeur = largeur;
            this.hauteur = hauteur;
        }

        public double GetChargeUtile() { return chargeUtile; }

        // volume = longueur*largeur*hauteur
        public double volume() { return longueur * largeur * hauteur; }

        public override string ToString()
        {
            return base.ToString() +
            "\nCharge utile : " + chargeUtile.ToString() +
            "\nLongueur : " + longueur.ToString() +
            "\nLargeur : " + largeur.ToString() +
            "\nHauteur : " + hauteur.ToString();
        }
    } // classe

}
