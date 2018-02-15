using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Complexe c1 = new Complexe(2, 4);
            Console.WriteLine("Nombre Complexe 1: ");
            Console.WriteLine("  Partie réelle : {0}", c1.PartieReelle);
            Console.WriteLine("  Partie imaginaire : {0}", c1.PartieImaginaire);
            Console.WriteLine("  Nombre Complexe : {0}", c1.Afficher());

            Console.Out.WriteLine("\n");
            Complexe c2 = new Complexe();
            c2.PartieReelle = 3;
            c2.PartieImaginaire = -2;
            Console.WriteLine("Nombre Complexe 2: ");
            Console.WriteLine("  Partie réelle : {0}", c2.PartieReelle);
            Console.WriteLine("  Partie imaginaire : {0}", c2.PartieImaginaire);
            Console.WriteLine("  Nombre Complexe : {0}", c2.Afficher());


            Console.Out.WriteLine("\n");
            Console.Out.WriteLine("La somme: ");
            Complexe c3 = c1.Plus();      //L'objet C3 est construit et sa référence est retournée par la méthode Plus
            Console.WriteLine(c3.Afficher());


            Console.Out.WriteLine("\n");
            Console.Out.WriteLine("La Différence: ");
            Complexe C4 = c1.Moins(c2);
            Console.WriteLine(C4.Afficher());


            Console.WriteLine("Appuyer sur une touche pour terminer");
            Console.ReadKey();

        }
    }

}
