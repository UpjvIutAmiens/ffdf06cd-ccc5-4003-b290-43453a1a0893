using System;
using System.Text;

namespace Commande
{
    public class LigneCmd
    {
        private double _prixUnitaire;
        private Article _articleCmd;
        private double _quantite;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="article"></param>
        /// <param name="quantite"></param>
        /// <param name="prixUnitaire"></param>
        public LigneCmd(Article article, double quantite, double prixUnitaire)
        {
            this.ArticleCmd = article;
            this.Quantite = quantite;
            this.PrixUnitaire = prixUnitaire;
        }

        public LigneCmd(Article article, double quantite)
            : this(article, quantite, article.PrixUnitaire) // Appel d'un constructeur de la même classe
        {
        }

        /// <summary>
        /// La quantité d'article qui est commandée.
        /// <exception cref="ArgumentException">Une exception est levée si la quantitée est négative</exception>
        /// </summary>
        public double Quantite
        {
            get { return _quantite; }

            set
            {
                if (value > 0)
                    _quantite = value;
                else
                    throw new ArgumentException("Erreur, la quantité doit être positive.");
            }
        }

        /// <summary>
        /// Le prix unitaire auquel l'article a été vendu.
        /// <exception cref="ArgumentException">Une exception est levée si le prix unitaire est négatif</exception>
        /// </summary>
        public double PrixUnitaire
        {
            get { return _prixUnitaire; }

            set
            {
                if (value >= 0)
                    _prixUnitaire = value;
                else
                    throw new ArgumentException("Erreur, le prix unitaire doit être positif.");
            }
        }

        /// <summary>
        /// Retourne le montant de la ligne de commande
        /// </summary>
        public double Montant
        {
            get { return CalculMontant(); }
        }

        /// <summary>
        /// L'article qui a été commandé
        /// </summary>
        public Article ArticleCmd
        {
            get { return _articleCmd; }
            set { _articleCmd = value; }
        }

        /// <summary>
        /// Calcul le montant de la ligne de commande
        /// </summary>
        /// <returns></returns>
        private double CalculMontant()
        {
            return PrixUnitaire * Quantite;
        }

        /// <summary>
        /// Retourne une chaine de caractère pour controller les valeurs stockées dans l'instance de la classe.
        /// </summary>
        /// <returns></returns>
        private string Description()
        {
            var result = new StringBuilder();

            result.Append("LigneCmd : ");
            result.AppendFormat("{0} - {1}", ArticleCmd.Reference, ArticleCmd.Designation);
            result.Append("; ");
            result.AppendFormat("pu:{0:C}", PrixUnitaire);
            result.Append("; ");
            result.AppendFormat("qt:{0}", Quantite);
            result.Append("; ");
            result.AppendFormat("mnt:{0:C}", Montant);

            return result.ToString();
        }

        public override string ToString()
        {
            return this.Description();
        }
    }
}