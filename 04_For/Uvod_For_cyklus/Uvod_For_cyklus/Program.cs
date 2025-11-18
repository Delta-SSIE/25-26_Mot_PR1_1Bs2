namespace Uvod_For_cyklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            for(int i = 0; i < 10; i++)
                //při začátku cyklu (pouze jednou) se incializuje proměnná i s hodnotou 0
                //podmínka se ověřuje vždy, pokud platí cyklus se opakuje 
                //i++ se stane vždy na konci průchodu tělem cyklu
            {
                Console.WriteLine($"Hodnota i: {i}");
            }

            Console.WriteLine();

            //Výpis od 1 do 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Hodnota i: {i}");
            }

            Console.WriteLine();

            //Výpis od 10 do 0
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Hod xkrát xstěnnou kostkou
            int pocetSten = 6;
            double pocetHodu = 1000;
            Random kostka = new Random();
            double soucetHodu = 0;

            for (int i = 0; i < pocetHodu; i++)
            {
                soucetHodu += kostka.Next(1, pocetSten + 1);
            }

            Console.WriteLine(soucetHodu/pocetHodu);

            //Program uživatele vyzve, aby zadával čísla kladná
            //Uživatel zadá celkově 10 čísel. Program na konci vypíše jejich součet.
            //Pokud ale uživatel zadá číslo záporné, pak zadávání okamžitě skončí.

            int soucet = 0;
            int cislo = 1;

            for (int i = 0; i < 10 && cislo > 0; i++)
            {
                Console.Write($"Zadej mi {i+1}. číslo: ");
                while(!int.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.WriteLine("Zadej číslo!");
                }
                if(cislo > 0)
                {
                    soucet += cislo;
                }
            }
            Console.WriteLine(soucet);
        }
    }
}
