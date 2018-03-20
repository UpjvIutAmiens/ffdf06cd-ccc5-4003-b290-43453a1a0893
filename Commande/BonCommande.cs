using System;
using System.Collections.Generic;

namespace Commande
{
    public class BonCommande
    {
        private List<LigneCmd> _ligneCmds;

        public BonCommande(string numero)
        {
            this.Numero = numero;

            this.Initializer();
        }

        private void Initializer()
        {
            this._ligneCmds = new List<LigneCmd>();
        }

        public List<LigneCmd> LigneCmds => this._ligneCmds;

        public DateTime Date { get; set; }

        public string Numero { get; set; }

        public double MontantBonCommande => this.CalculMontantTotal();


        public void AddLigneCmd(LigneCmd ligneCmd)
        {
            this.LigneCmds.Add(ligneCmd);
        }

        /// <summary>
        /// Calcul le montant total (à payer) du bon de commande (avec remise, TVA, ...)
        /// </summary>
        /// <returns>Montant du bon de commande</returns>
        private double CalculMontantTotal()
        {
            double montant = 0;

            foreach (LigneCmd ligneCmd in this.LigneCmds)
            {
                montant += ligneCmd.Montant;
            }

            return montant;
        }
    }
}