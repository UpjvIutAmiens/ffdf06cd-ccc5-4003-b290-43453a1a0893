namespace Commandes
{
    class LigneCmd // Nom complet de la classe Commandes.LigneCmd
    {
        public string designation;
        public double prixUnitaire;
        public double quantite;

        public string Description()
        {
            return $"{designation}, pu:{prixUnitaire}, qt:{quantite}";
        }
    }
}
