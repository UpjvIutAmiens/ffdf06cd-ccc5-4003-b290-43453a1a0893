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

            l1.Designation = "Gomme";
            l1.PrixUnitaire = 1.3;
            l1.Quantite = 10;

            // Second objet avec une autre syntaxe
            LigneCmd l2 = new LigneCmd()
            {
                Designation = "Crayon",
                PrixUnitaire = 0.21,
                Quantite = 100
            };

            LigneCmd l3 = new LigneCmd();

            l3.Designation = "Bureau";
            l3.PrixUnitaire = -1000;
            l3.Quantite = 50;


            Console.WriteLine("L1 : " + l1.Description());
            Console.WriteLine("L2 : " + l2.Description());
            Console.WriteLine("L3 : " + l3.Description());
            Console.WriteLine("Press a key");
            // Console.ReadKey();
        }
    }
}
