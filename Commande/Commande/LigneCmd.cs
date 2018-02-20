﻿using System;
using System.Dynamic;

namespace Commande
{
    class LigneCmd : IComparable<LigneCmd> // Nom complet de la classe Commande.LigneCmd
    {
        // Création des champs utilisable uniquement à l'intérieur de la classe
        // Les champs privés commencent par _
        private string _designation;
        private double _prixUnitaire;
        private double _quantite;

        // Le constructeur est une méthode (une fonction) appellée au moment
        // de la création de l'objet.
        // Il a le même nom que la classe et il n'a pas de type de retour
        public LigneCmd(string designation, double quantite, double prixUnitaire)
        {
            Designation = designation;
            Quantite = quantite;
            PrixUnitaire = prixUnitaire;
        }

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
                    // pour notre cas
                    throw new ArgumentOutOfRangeException($"Prix unitaire négatif : {value}");
                }
                else
                {
                    _prixUnitaire = value;
                }
            }
        }

        public double Quantite
        {
            get { return _quantite; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"Quantité négative : {value}");
                }
                else
                {
                    _quantite = value;
                }
            }
        }

        public double Montant
        {
            // Proriété en lecture seul puisque pas de "set"
            get {return  Quantite * PrixUnitaire;}
        }

        
        public int CompareTo(LigneCmd ligCmd)
        {
            int compare;

            compare = this.PrixUnitaire.CompareTo(ligCmd.PrixUnitaire);

            return compare;
        }

        public string Description()
        {
            return
                $"{Designation} pu:{PrixUnitaire:C}, qt:{Quantite}, mnt:{Montant:C}";
        }

        public string DescriptionSimple()
        {
            return
                $"{Designation} ({PrixUnitaire:C})";
        }
    }
}
