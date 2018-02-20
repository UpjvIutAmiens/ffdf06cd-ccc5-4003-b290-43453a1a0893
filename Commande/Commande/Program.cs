using System;
using System.Collections.Generic;
using System.Text;

namespace Commande
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            LigneCmd ligA = new LigneCmd("Parapluie aluminium", 8, 6.25);
            LigneCmd ligB = new LigneCmd("Briquet gaz", 21, 1.25);
            LigneCmd ligC = new LigneCmd("Stylo", 10, 0.33);



            LigneCmd ligMinimum, ligMedium, ligMaximum;
            if ((ligA.PrixUnitaire < ligB.PrixUnitaire) && (ligA.PrixUnitaire < ligC.PrixUnitaire))
            {
                // ligA minimum
                ligMinimum = ligA;
                if (ligB.PrixUnitaire < ligC.PrixUnitaire)
                {
                    // ligB medium
                    ligMedium = ligB;
                    // ligC maximum
                    ligMaximum = ligC;
                } else
                {
                    // ligC medium
                    ligMedium = ligC;
                    // ligB maximum
                    ligMaximum = ligB;
                }
            } else
            {
                if ((ligB.PrixUnitaire < ligA.PrixUnitaire) && (ligB.PrixUnitaire < ligC.PrixUnitaire))
                {
                    // ligB minimim
                    ligMinimum = ligB;
                    if (ligC.PrixUnitaire < ligA.PrixUnitaire)
                    {
                        // ligC medium
                        ligMedium = ligC;
                        // ligA maximum
                        ligMaximum = ligA;
                    }
                    else
                    {
                        // ligA medium
                        ligMedium = ligA;
                        // ligC minimum
                        ligMaximum = ligC;
                    }
                } else
                {
                    // C'est ligC le minimum
                    ligMinimum = ligC;

                    if (ligB.PrixUnitaire < ligA.PrixUnitaire)
                    {
                        // ligB medium
                        ligMedium = ligB;
                        // ligA maximum
                        ligMaximum = ligA;
                    }
                    else
                    {
                        // ligA medium
                        ligMedium = ligA;
                        // ligB minimum
                        ligMaximum = ligB;
                    }
                }
            }


            Console.WriteLine(ligA.DescriptionSimple());
            Console.WriteLine(ligB.DescriptionSimple());
            Console.WriteLine(ligC.DescriptionSimple());
            Console.WriteLine("\n\n\n=============== TRIE ===============\n");
            Console.WriteLine(ligMinimum.DescriptionSimple());
            Console.WriteLine(ligMedium.DescriptionSimple());
            Console.WriteLine(ligMaximum.DescriptionSimple());

            // Creation de la collection (List)
            List<LigneCmd> listLigneCmd = new List<LigneCmd>();
            listLigneCmd.Add(ligA);
            listLigneCmd.Add(ligB);
            listLigneCmd.Add(ligC);


            // Utilisation des collections
            listLigneCmd.Sort();
            Console.WriteLine("\n\n\n=============== TRI COLLECTION ===============\n");
            foreach (LigneCmd ligCmd in listLigneCmd)
            {
                Console.WriteLine(ligCmd.DescriptionSimple());
            }
        }
    }
}
