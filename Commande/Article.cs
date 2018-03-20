using System;

namespace Commande
{
    /// <summary>
    /// Un article du système d'ingformation.
    /// </summary>
    public class Article
    {
        private string _designation;
        private double _prixUnitaire;
        private string _reference;

        /***
         * Constructeur
         */
        /// <summary>
        /// Instancie
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="designation"></param>
        /// <param name="prixUnitaire"></param>
        public Article(string reference, string designation, double prixUnitaire)
        {
            this.Reference = reference;
            this.Designation = designation;
            this.PrixUnitaire = prixUnitaire;
        }


        /// <summary>
        /// Prix unitaire de l'article
        /// <exception cref="ArgumentOutOfRangeException">Une exception est levée si le prix unitaire de l'article est négatif</exception>
        /// </summary>
        public double PrixUnitaire
        {
            get { return this._prixUnitaire; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("PrixUnitaire", value,
                        "Le prix unitaire doit être supérieur ou égale à 0");
                }

                this._prixUnitaire = value;
            }
        }


        /// <summary>
        /// Désignation de l'article
        /// <exception cref="ArgumentException">Une exception est levée si la désignation n'est pas renseignée.</exception>
        /// </summary>
        public string Designation
        {
            get { return this._designation; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La désignation de l'article n'est pas renseignée");
                }

                this._designation = value;
            }
        }

        /// <summary>
        /// Référence de l'article
        /// <exception cref="ArgumentException">Une exception est levée si la référence n'est pas renseignée </exception>
        /// </summary>
        public string Reference
        {
            get { return this._reference; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La référence de l'article n'est pas renseignée");
                }

                this._reference = value;
            }
        }

        /// <summary>
        /// Retourne une chaine de caractère pour controller les valeurs stockées dans l'instance de la classe.
        /// </summary>
        /// <returns></returns>
        private string Description()
        {
            return $"Article : [{this.Reference}], \"{this.Designation}\", pu:{this.PrixUnitaire:C}";
        }

        public override string ToString()
        {
            return this.Description();
        }
    }
}