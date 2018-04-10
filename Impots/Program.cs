// 
// Fichier : Program.cs

#region

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Impots
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Habitation> habitations = new List<Habitation>();

            habitations.Add(new HabitationProfessionnelle("ImportExport", "AMIENS", 2500, 130));
            habitations.Add(new HabitationProfessionnelle("Export", "AMIENS", 250, 10));
            habitations.Add(new HabitationIndividuelle("Jessica", "AMIENS", 100, 5, false));
            habitations.Add(new HabitationProfessionnelle("Import", "AMIENS", 1200, 90));
            habitations.Add(new HabitationIndividuelle("Jean", "AMIENS", 130, 6, true));

            // Affichage des habitations comme des Habitation
            Console.WriteLine("Les habitations");
            Console.WriteLine("===============");
            foreach (Habitation habitation in habitations)
            {
                Console.WriteLine(habitation.Decrire());
            }

            Console.Write(Environment.NewLine);
            Console.WriteLine("Les habitations");
            Console.WriteLine("===============");



            // Affichage des habitations selon leur type réel
            foreach (Habitation habitation in habitations)
            {
                if (habitation.GetType() == typeof(HabitationIndividuelle))
                {
                    // Utilisation d'une variable intermédiaire et de l'opérateur as
                    HabitationIndividuelle hi = habitation as HabitationIndividuelle;
                    Console.WriteLine(hi.Decrire());
                    Console.WriteLine("     " + hi.Impot());
                }
                else
                {
                    if (habitation.GetType() == typeof(HabitationProfessionnelle))
                    {
                        // Utilisation du casting
                        Console.WriteLine(((HabitationProfessionnelle)habitation).Decrire());
                        Console.WriteLine("     " + ((HabitationProfessionnelle)habitation).Impot());
                    }
                }
            }

            Console.Write(Environment.NewLine);
            Console.WriteLine("Les impôts");
            Console.WriteLine("==========");
            double montantImpot = 0;
            foreach (Habitation habitation in habitations)
            {
                Console.WriteLine("{0} : {1:C}", habitation.Proprietaire, habitation.Impot());
                montantImpot += habitation.Impot();
            }

            Console.WriteLine("\n");
            Console.WriteLine($"Montant collecté par la commune : {montantImpot:C}");

            Console.WriteLine("Appuyer sur une touche pour terminer");
            Console.ReadKey();
        }
    }
}