using System;
using System.Text;

namespace Complexe
{
    class Complexe
    {
        private double _partieReelle;                                  //partie réelle
        private double _partieImaginaire;                              //partie imaginaire

        public double PartieReelle
        {
            get { return _partieReelle; }
            set { _partieReelle = value; }
        }

        public double PartieImaginaire
        {
            get { return _partieImaginaire; }
            set { _partieImaginaire = value; }
        }

        public Complexe() { }

        public Complexe(double partieReelle, double partieImaginaire)
        {
            this._partieReelle = partieReelle;
        }

        public Complexe Plus(Complexe c)               //La méthode retourne un objet (référence)
        {
            double relle, imaginaire;
            relle = this._partieReelle + c._partieReelle;
            imaginaire = this._partieImaginaire + c._partieImaginaire;

            Complexe rs = new Complexe(relle, imaginaire);
            return ;
        }

        public Complexe Moins(Complexe c)                //La méthode retourne un objet (référence)
        {

        }

        public string Afficher()
        {
            StringBuilder sb = new StringBuilder();

            if (_partieImaginaire == 0)
                sb.Append(_partieReelle);
            else if (_partieImaginaire > 0)
            {
                if (_partieImaginaire == 1)
                    sb.Append(_partieReelle + "+i");
                else
                    sb.Append(_partieReelle + "+" + _partieImaginaire + "i");
            }
            else
            {
                if (_partieImaginaire == -1)
                    sb.Append(_partieReelle + "-i");
                else
                    sb.Append(_partieReelle + "" + _partieImaginaire + "i");
            }

            return sb.ToString();
        }
    }

}
