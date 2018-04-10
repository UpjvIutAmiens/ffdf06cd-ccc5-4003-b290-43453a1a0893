namespace Impots
{
    class Habitation
    {
        public string Proprietaire { get; set; }
        public string Adresse { get; set; }
        public double Surface { get; set; }

        public Habitation(string proprietaire, string adresse, double surface)
        {
            this.Proprietaire = proprietaire;
            this.Adresse = adresse;
            this.Surface = surface;
        }

        public virtual double Impot()
        {
            return Surface * 2;
        }

        public new string ToString()
        {
            return string.Format("Prop : {0} ; Adr : {1} ; Surface : {2}", Proprietaire, Adresse, Surface);
        }

        public string Decrire()
        {
            return string.Format("Habitation : {0}", this.ToString());
        }
    }
}
