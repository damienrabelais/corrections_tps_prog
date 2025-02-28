namespace POOGestionCatalogueCollections
{
    internal class Produit
    {
        private string designation;
        private double prixHT;
        private double tauxTVA;
                
        public Produit(string pDesignation, double pPrixHT, double pTauxTVA)
        {
            designation = pDesignation;
            prixHT = pPrixHT;
            tauxTVA = pTauxTVA;
        }

        public void AugmenterPrix(double pourcentage)
        {
            prixHT = prixHT + pourcentage / 100d * prixHT;
        }
        public void BaisserPrix(double pourcentage)
        {
            prixHT = prixHT - pourcentage / 100d * prixHT;
        }

        public double GetPrixHT()
        {
            return prixHT;
        }
        public string GetDesignation()
        {

            return designation;
        }

        public double GetTauxTVA()
        {
            return tauxTVA;
        }
        public void SetTauxTVA(double nouvTauxTVA)
        {
            tauxTVA = nouvTauxTVA;
        }

        public double GetPrixTTC()
        {
            return prixHT + tauxTVA * prixHT / 100d;
        }

        public override string ToString()
        {
           return "\nDésignation : " + designation + "\nPrix HT : " + prixHT.ToString() + "\nTaux TVA : " + tauxTVA.ToString() + "\nPrix TTC : " + GetPrixTTC().ToString();
        }
        public string ToCSV()
        {
            return designation + ";" + prixHT.ToString() + ";" + tauxTVA.ToString();
        }

    }
}
