using System;
using System.Globalization;
using System.Text;

namespace Etudiant
{
    class Etudiant
    {
        // Les champs
        private string _nom;
        private string _prenom;
        private string _login;
        // Le point d'interrogation indique qu'on
        // peut affecter une valeur "null" à _dateNaissance (DateTime est une structure, pas une classe)
        private DateTime? _dateNaissance = null;

        // Les constructeurs
        public Etudiant(string nom, string prenom)
        {
            // Initialisation des champs
            Nom = nom;
            Prenom = prenom;
        }

        // Les propriétés
        public string Nom
        {
            get { return _nom; }

            set { _nom = value.ToUpper(); }
        }

        public string Prenom
        {
            get { return _prenom; }

            set
            {
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                _prenom = ti.ToTitleCase(value);
            }
        }

        public string Login
        {
            get { return _login; }

            set { _login = value.ToLower(); }
        }

        public DateTime? DateNaissance
        {
            get { return _dateNaissance; }

            set { _dateNaissance = value; }
        }

        public string Description()
        {
            // L'objet StringBuilder optimise les concaténations et la gestion de la mémoire

            StringBuilder result =new StringBuilder();
            result.Append($"{Nom} {Prenom}");

            // Ajout de la date de naissance uniquement si elle est renseignée
            if (DateNaissance != null)
            {
                // Formats
                // https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
                // https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
                result.Append($" dn:{DateNaissance:ddd d MMM yyyy}");
            }
            return result.ToString();
        }
    }
}