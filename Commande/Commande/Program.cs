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

            l1.designation = "gomme";
            l1.prixUnitaire = 1.3;
            l1.quantite = 10;

            LigneCmd l2 = new LigneCmd()
            {
                designation = "Crayon",
                prixUnitaire = 0.2,
                quantite = 5
            };

            // Problème avec cet objet
            LigneCmd l3 = new LigneCmd()
            {
                designation = "Bureau",
                prixUnitaire = -1000,
                quantite = 50
            };

            Console.WriteLine(l1.Description());
            Console.WriteLine(l2.Description());
            Console.WriteLine(l3.Description());
        }
    }
}
