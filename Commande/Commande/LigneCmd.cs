namespace Commande
{
    class LigneCmd // Nom complet de la classe Commande.LigneCmd
    {
        public string designation;
        public double prixUnitaire;
        public double quantite;

        public double montant()
        {
            return quantite * prixUnitaire;
        }

        public string Description()
        {
            return
                $"{designation} pu:{prixUnitaire:C}, qt:{quantite}, mnt:{montant():C}";
        }
    }
}
