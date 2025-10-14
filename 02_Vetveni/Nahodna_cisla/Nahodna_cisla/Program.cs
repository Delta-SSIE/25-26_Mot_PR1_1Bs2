namespace Nahodna_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generace náhodných čísel

            //Musíte si vytvořit generátor
            //Generátor stačí v celém kódu jenom jednou
            //dle jeho názvu (Random nazev = new Random()) se volá v kódu
            Random generator = new Random();

            //Jak s generátorem generovat náhodná čísla?
            //nazev.Next(spodní hranice (včetně), horní hranice (bez))
            Console.WriteLine(generator.Next(0, 2)); //0-1
            Console.WriteLine(generator.Next(0, 2));
            Console.WriteLine(generator.Next(0, 2));
            Console.WriteLine(generator.Next(0, 2));
            Console.WriteLine(generator.Next(0, 2));

            int kostka = generator.Next(1, 7); //1-6
            Console.WriteLine($"Hod 6stěnné kostky má výsledek {kostka}");

            //Zvláštnosti
            Console.WriteLine(generator.NextDouble()); //0-1 (double)
        }
    }
}
