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

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const int multiple = 8;
            const int valMax = 10;

            string affichage = "";

            for (int i = 0; i <= valMax; i++)
            {
                // Interpolated string (C#>=v6)
                int resultat = i * multiple;
                affichage +=
                $"{i:00} x {multiple,4} = {resultat:C}";

                affichage += "\n";
            }

            Console.WriteLine(affichage);
            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
