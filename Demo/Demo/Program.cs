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
                affichage += 
                string.Format("{0:00} x {1,4} = {2:C}",
                    i,          // element : 0
                    multiple,   // element : 1
                    i * multiple// element : 2
                    );

                affichage += "\n";
            }

            Console.WriteLine(affichage);
            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
