// 
// Fichier : HabitationProfessionnelle.cs

#region

using System;
using System.Diagnostics;
using System.Text;

#endregion

namespace Impots
{
    class HabitationProfessionnelle : Habitation
    {
        #region Propriétés

        public int NbEmploye { get; set; }
        public double Surface { get; set; }

        #endregion

        #region Constructeurs

        public HabitationProfessionnelle(string proprietaire, string adresse, double surface, int nbEmploye)
            : base(proprietaire, adresse, surface)
        {
            this.Surface = surface;
            this.NbEmploye = nbEmploye;
        }

        #endregion

        public override double Impot()
        {
            const double montantTrancheEmploye = 1000;
            const double trancheEmploye = 10;

            double impot = base.Impot();
            double nbTranche = Math.Ceiling(this.NbEmploye / trancheEmploye);

            impot += nbTranche * montantTrancheEmploye;

            Debug.WriteLine(string.Format("Nb Tranche : {0:0.00} pour {1} employés", nbTranche, this.NbEmploye));

            return impot;
        }

        public new string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendFormat(" ; NbEmploye : {0}", NbEmploye);

            return sb.ToString();
        }

        public new string Decrire()
        {
            return string.Format("HabitationProfessionnelle : {0}", this.ToString());
        }
    }
}