using System;
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



            LigneCmd lig1, lig2, lig3;
            if ((ligA.PrixUnitaire < ligB.PrixUnitaire) && (ligA.PrixUnitaire < ligC.PrixUnitaire))
            {
                // ligA minimum
                lig1 = ligA;
                if (ligB.PrixUnitaire < ligC.PrixUnitaire)
                {
                    // ligB medium
                    lig2 = ligB;
                    // ligC maximum
                    lig3 = ligC;
                } else
                {
                    // ligC medium
                    lig2 = ligC;
                    // ligB maximum
                    lig3 = ligB;
                }
            } else
            {
                if ((ligB.PrixUnitaire < ligA.PrixUnitaire) && (ligB.PrixUnitaire < ligC.PrixUnitaire))
                {
                    // ligB minimim
                    lig1 = ligB;
                    if (ligC.PrixUnitaire < ligA.PrixUnitaire)
                    {
                        // ligC medium
                        lig2 = ligC;
                        // ligA maximum
                        lig3 = ligA;
                    }
                    else
                    {
                        // ligA medium
                        lig2 = ligA;
                        // ligC minimum
                        lig3 = ligC;
                    }
                } else
                {
                    // C'est ligC le minimum
                    lig1 = ligC;

                    if (ligB.PrixUnitaire < ligA.PrixUnitaire)
                    {
                        // ligB medium
                        lig2 = ligB;
                        // ligA maximum
                        lig3 = ligA;
                    }
                    else
                    {
                        // ligA medium
                        lig2 = ligA;
                        // ligB minimum
                        lig3 = ligB;
                    }
                }
            }


            Console.WriteLine(ligA.DescriptionSimple());
            Console.WriteLine(ligB.DescriptionSimple());
            Console.WriteLine(ligC.DescriptionSimple());
            Console.WriteLine("\n\n\n=============== TRIE ===============\n");
            Console.WriteLine(lig1.DescriptionSimple());
            Console.WriteLine(lig2.DescriptionSimple());
            Console.WriteLine(lig3.DescriptionSimple());
        }
    }
}
