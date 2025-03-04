using System;
using System.Collections.Generic;
using System.Text;

namespace POOHeritage
{
    public class VehiculeTourisme : Vehicule
    {
        private int nombreDePortes;
        private int nombreDePassagers;
        private bool climatisation;

        public VehiculeTourisme(
            string code, string libelle, double prixJour,
            int nombreDePortes, int nombreDePassagers, bool climatisation
            ) : base(code, libelle, prixJour)
        {
            this.nombreDePortes = nombreDePortes;
            this.nombreDePassagers = nombreDePassagers;
            this.climatisation = climatisation;
        }
        public int GetNombreDePortes() { return nombreDePortes; }
        public int GetNombreDePassagers() { return nombreDePassagers; }
        public bool GetClimatisation() { return climatisation; }

        public override string ToString()
        {
            return base.ToString() +
            "\nNombre de portes : " + nombreDePortes.ToString() +
            "\nNombre de passagers : " + nombreDePassagers.ToString() +
            "\nClimatisation : " + climatisation.ToString();
        }
    } // classe

}
