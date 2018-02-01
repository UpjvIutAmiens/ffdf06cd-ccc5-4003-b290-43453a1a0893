using System;
using System.Dynamic;

namespace Commande
{
    class LigneCmd // Nom complet de la classe Commande.LigneCmd
    {
        // Création des champs utilisable uniquement à l'intérieur de la classe
        // Les champs privés commencent par _
        private string _designation;
        private double _prixUnitaire;
        private double _quantite;

        // Les propriétés "filtrent" les accès aux champs
        // Les propriétés public commencent par une majuscule
        public string Designation
        {
            // Accès en lecture
            get { return _designation; }
            // Accès en écriture. La valeur donnée à la
            // propriété est stockée dans la variable "value"
            set { _designation = value; }
        }

        public double PrixUnitaire
        {
            get { return _prixUnitaire; }
            set
            {
                if (value < 0)
                {
                    // Gestion des erreurs par une "exception"
                    // throw lève une exception
                    // L'exception est ArgumentOutOfRange qui est explicite
                    // pour note cas
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _prixUnitaire = value;
                }
            }
        }

        public double Quantite { get; set; }

        public double montant()
        {
            return Quantite * PrixUnitaire;
        }

        public string Description()
        {
            return
                $"{Designation} pu:{PrixUnitaire:C}, qt:{Quantite}, mnt:{montant():C}";
        }
    }
}
