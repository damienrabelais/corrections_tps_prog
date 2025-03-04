using System;
using System.Collections.Generic;
using System.Text;

namespace POOHeritage
{
    public abstract class Vehicule
    {
        private string code;
        private string libelle;
        private double prixJour;

        public Vehicule(string code, string libelle, double prixJour)
        {
            this.code = code;
            this.libelle = libelle;
            this.prixJour = prixJour;
        }
        public string GetCode() { return code; }
        public string GetLibelle() { return libelle; }
        public double GetPrixJour() { return prixJour; }
        public void SetPrixJour(double nouvPrixJour) { prixJour = nouvPrixJour; }
        public double CoutLocation(double nombreJours) { return prixJour * nombreJours; }

        public override string ToString()
        {
            return "Code catégorie : " + code +
                 "\nLibellé catégorie : " + libelle +
                 "\nPrix location journalière : " + prixJour.ToString();
        }
    } // classe

}
