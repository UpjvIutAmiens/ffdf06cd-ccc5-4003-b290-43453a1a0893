using System;
using System.Text;

namespace Commande
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Catalogue catalogue = new Catalogue();
            catalogue.AddArticle(new Article("A001", "Gomme", 0.24));
            catalogue.AddArticle(new Article("A002", "Crayon", 0.78));
            catalogue.AddArticle(new Article("A003", "Lampe", 42));
            catalogue.AddArticle(new Article("A004", "Classeur", 6));


            BonCommande bc1 = new BonCommande("BC001");
            bc1.AddLigneCmd(new LigneCmd(catalogue.GetArticleByRef("A001"), 100));
            bc1.AddLigneCmd(new LigneCmd(catalogue.GetArticleByRef("A003"), 3));
            bc1.AddLigneCmd(new LigneCmd(catalogue.GetArticleByRef("A004"), 589));

            AfficherBoncCommande(bc1);

            Console.WriteLine("Appuyer sur une touche pour quitter");
            Console.ReadKey();
        }

        private static void AfficherBoncCommande(BonCommande bc)
        {
            Console.WriteLine("Num Commande : {0}", bc.Numero);
            foreach (LigneCmd bcLigneCmd in bc.LigneCmds)
            {
                Console.WriteLine(bcLigneCmd);
            }

            Console.WriteLine("Montant : {0:C}", bc.MontantBonCommande);
        }
    }
}