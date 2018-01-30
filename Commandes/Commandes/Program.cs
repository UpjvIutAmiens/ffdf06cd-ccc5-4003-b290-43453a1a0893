using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creation d'une référence l1 qui peut pointer un objet LigneCmd
            LigneCmd l1;

            // Création d'un objet LigneCmd référencé par l1
            l1 = new LigneCmd();

            l1.designation = "Gomme";
            l1.prixUnitaire = 1.3;
            l1.quantite = 10;

            Console.WriteLine("L1 : " + l1.Description());
            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
