namespace AdminPanel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdminCs adminCs = new AdminCs("Mehemmed", "Super", "Sectionu", "12345");
            Console.WriteLine(adminCs.sifre);

        }
    }
}