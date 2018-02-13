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

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.ArgumentException("Le nom n'est pas renseigné");
                }
                else
                {
                    _nom = value.ToUpper();
                }
            }
        }

        public string Prenom
        {
            get { return _prenom; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.ArgumentException("Le prénom n'est pas renseigné");
                }
                else
                {
                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

                    _prenom = ti.ToTitleCase(value.ToLower());
                }
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

        public string Age
        {
            get
            {
                if (DateNaissance != null)
                {
                    DateTime d = (DateTime)DateNaissance;
                    return calculAge(d);
                }

                throw new ArgumentNullException();
            }
        }

        private string calculAge(DateTime dateNaissance)
        {
            StringBuilder result = new StringBuilder();
            DateTime now = DateTime.Now;

            int days = now.Day - dateNaissance.Day;
            if (days < 0)
            {
                var newNow = now.AddMonths(-1);
                days += (int)(now - newNow).TotalDays;
                now = newNow;
            }


            int months = now.Month - dateNaissance.Month;
            if (months < 0)
            {
                months += 12;
                now = now.AddYears(-1);
            }

            int years = now.Year - dateNaissance.Year;

            if (years > 0)
            {
                result.AppendFormat("{0} ans", years);
            }

            if (months > 0)
            {
                if (result.Length > 0)
                {
                    result.Append(" et ");
                }

                result.AppendFormat("{0} mois", months);
            }

            if (days > 0)
            {
                if (result.Length > 0)
                {
                    result.Append(" et ");
                }
                result.AppendFormat("{0} jour(s)", days);
            }

            return result.ToString();
        }



        public string Description()
        {
            // L'objet StringBuilder optimise les concaténations et la gestion de la mémoire

            StringBuilder result = new StringBuilder();
            result.Append($"{Nom} {Prenom}");

            // Ajout de la date de naissance uniquement si elle est renseignée
            if (DateNaissance != null)
            {
                // Formats
                // https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
                // https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
                result.Append($", dn:{DateNaissance:ddd d MMM yyyy}");
                result.Append($", age:{Age}");
            }
            return result.ToString();
        }
    }
}