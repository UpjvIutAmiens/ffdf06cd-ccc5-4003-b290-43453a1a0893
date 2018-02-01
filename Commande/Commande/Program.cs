using System;
using System.Text;

namespace Commande
{
    class Program
    {
        static void Main(string[] args)
        {
            // Passer la console en UTF-8 pour le symbole Euro
            Console.OutputEncoding = Encoding.UTF8;

            // Déclaration d'une référence capable de pointer vers un
            // objet de type LigneCmd
            LigneCmd l1;

            // Création d'un objet LigneCmd avec l'opérateur new et stockage
            // de la référence dans l1
            l1 = new LigneCmd();

            l1.Designation = "gomme";
            l1.PrixUnitaire = 1.3;
            l1.Quantite = 10;

            LigneCmd l2 = new LigneCmd()
            {
                Designation = "Crayon",
                PrixUnitaire = 0.2,
                Quantite = 5
            };

            // Problème avec cet objet
            LigneCmd l3 = new LigneCmd()
            {
                Designation = "Bureau",
                PrixUnitaire = 1000,
                Quantite = 50
            };

            Console.WriteLine(l1.Description());
            Console.WriteLine(l2.Description());
            Console.WriteLine(l3.Description());
        }
    }
}
