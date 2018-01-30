using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Afficher la tables des 8 (multiplation)
            // Concaténation : +
            // Saut de ligne : \n

            const int multiple = 8;
            const int valMax = 10;

            string affichage = "";

            for (int i = 0; i <= valMax; i++)
            {
                affichage = affichage + i;
                affichage += " x " + multiple + " = " 
                    + i * multiple;
                affichage += "\n";
            }

            Console.WriteLine(affichage);
            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
