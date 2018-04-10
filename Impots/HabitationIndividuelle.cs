// 
// Fichier : HabitationIndividuelle.cs

using System.Text;

namespace Impots
{
    class HabitationIndividuelle : Habitation
    {
        #region Propriétés

        public int NbPiece { get; set; }
        public bool Piscine { get; set; }

        #endregion

        #region Constructeurs

        public HabitationIndividuelle(string proprietaire, string adresse, double surface, int nbPiece, bool piscine)
            : base(proprietaire, adresse, surface)
        {
            this.NbPiece = nbPiece;
            this.Piscine = piscine;
        }

        #endregion

        public override double Impot()
        {
            const double montantParPiece = 100;
            const double montantPiscine = 500;

            double impot = base.Impot();
            impot += NbPiece * montantParPiece;
            impot += Piscine ? montantPiscine : 0;

            return impot;
        }

        public new string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendFormat(" ; NbPiece : {0} ; Piscine : {1}", NbPiece, Piscine);

            return sb.ToString();
        }

        public new string Decrire()
        {
            return string.Format("HabitationIndividuelle : {0}", this.ToString());
        }
    }
}