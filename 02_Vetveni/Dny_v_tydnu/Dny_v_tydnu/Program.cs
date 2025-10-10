namespace Dny_v_tydnu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi pořadové číslo dne (1-7)");
            int den = int.Parse(Console.ReadLine());

            if(den == 1)
            {
                Console.WriteLine("PONDĚLÍ");
            } else if(den == 2)
            {
                Console.WriteLine("ÚTERÝ");
            } else if(den == 3)
            {
                Console.WriteLine("STŘEDA");
            } else if(den == 4)
            {
                Console.WriteLine("ČTVRTEK");
            } else if(den == 5)
            {
                Console.WriteLine("PÁTEK");
            } else if(den == 6)
            {
                Console.WriteLine("SOBOTA");
            } else if(den == 7)
            {
                Console.WriteLine("NEDĚLE");
            } else
            {
                Console.WriteLine("Neplatný vstup!");
            }
        }
    }
}
