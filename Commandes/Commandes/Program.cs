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
            l1 = new LigneCmd("Gomme", 10, 1.3);


            // Second objet avec une autre syntaxe
            LigneCmd l2 = new LigneCmd(
                quantite: 100,
                designation: "Crayon",
                prixUnitaire: 0.21
                
            );

            LigneCmd l3 = new LigneCmd("Bureau", 50, 1000);


            Console.WriteLine("L1 : " + l1.Description());
            Console.WriteLine("L2 : " + l2.Description());
            Console.WriteLine("L3 : " + l3.Description());
            Console.WriteLine("Press a key");
            // Console.ReadKey();
        }
    }
}
