using System;

namespace Etudiant
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant etud1 = new Etudiant("ETROQUIEN", "Jessica");

            etud1.DateNaissance = new DateTime(2001, 03, 16);

            System.Console.WriteLine(etud1.Description());
        }
    }
}
