namespace Etudiant
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant etud1 = new Etudiant("ETROQUIEN", "Jessica");

            System.Console.WriteLine(etud1.Description());
        }
    }
}
