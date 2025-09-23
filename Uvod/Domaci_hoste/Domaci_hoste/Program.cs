namespace Domaci_hoste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vyřešení přes doplnění uvozovek k textům (stringům)
            Console.Write("Zadej skore domácích: ");
            string domaci = Console.ReadLine();

            Console.Write("Zadej skore hostů: ");
            string hoste = Console.ReadLine();

            Console.WriteLine("Výsledek zápasu je "+ domaci +" : "+hoste);
        }
    }
}
