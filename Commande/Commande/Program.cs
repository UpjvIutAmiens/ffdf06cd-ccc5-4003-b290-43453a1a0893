using System;

namespace Commande
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration d'une référence capable de pointer vers un
            // objet de type LigneCmd
            LigneCmd l1;

            // Création d'un objet LigneCmd avec l'opérateur new et stockage
            // de la référence dans l1
            l1 = new LigneCmd();

            l1.designation = "gomme";
            l1.prixUnitaire = 1.3;
            l1.quantite = 10;

            Console.WriteLine(l1.Description());
        }
    }
}
