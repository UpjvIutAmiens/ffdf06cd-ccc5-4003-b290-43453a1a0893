namespace Commandes
{
    class LigneCmd // Nom complet de la classe Commandes.LigneCmd
    {
        // Champs
        // Convention d'écriture en C#.
        // Les champs privés commencent par _
        private string _designation;
        private double _quantite;
        private double _prixUnitaire;
        

        // Propriétés
        // Convention d'écriture : commence par une majuscule
        public double PrixUnitaire
        {
            // Accès en lecture
            get
            {
                return _prixUnitaire;
            }
            // Accès en écriture
            set
            {
                // La donnée à stocker se trouve dans la variable
                // value (pas besoin de déclarer)
                if (value < 0)
                {
                    // throw lève une exception
                    throw new System.ArgumentOutOfRangeException($"pu négatif {value}");
                } else
                {
                    _prixUnitaire = value;
                }
            }
        }

        public string Designation
        {
            get
            {
                return _designation;
            }

            set
            {

                _designation = value;
            }
        }

        public double Quantite
        {
            get
            {
                return _quantite;
            }

            set
            {
                if (value < 0)
                {
                    // throw lève une exception
                    throw new System.ArgumentOutOfRangeException($"qt négatif {value}");
                }
                else
                {
                    _quantite = value;
                }
            }
        }

        public double Montant
        {
            get
            {
                return Quantite * PrixUnitaire;
            }
        }

        // méthodes
        public string Description()
        {
            return $"{Designation}, pu:{PrixUnitaire}, qt:{Quantite}, mnt:{Montant}";
        }
    }
}
