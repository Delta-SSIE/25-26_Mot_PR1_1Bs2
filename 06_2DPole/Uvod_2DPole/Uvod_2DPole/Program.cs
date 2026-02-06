namespace Uvod_2DPole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jednorozměrné pole
            int[] jCisla = { 1, 5, 6 }; //incializace pole s konkrétními hodnotami
            string[] jPrazdnePole = new string[10]; //vytvoření string pole, které je prázdné a má 10 míst

            //Dvourozměrné pole 2D
            //Celé pole je {} a každý řádek má {}
            int[,] cisla =
            {
                { 10, 5, 1 },
                { 8, 12, 6 },
                { 7, 11, 3 }
            };

            string[,] prazdnePole = new string[10, 5]; //10 řádků a 5 sloupců

            //Výpis z 2D pole
            Console.WriteLine(cisla[1,1]); //1 řádek (bacha 1 index, tzn. druhý řádek v pořadí) a 1 sloupec
            Console.WriteLine(cisla[1,2]);
            Console.WriteLine(cisla[2,0]);

            prazdnePole[8, 4] = "Pepa"; //přidá Pepu na 8. index řádku do 4. indexovaného sloupce
            Console.WriteLine(prazdnePole[8,4]);

            //Průchod 2D polem

            //Foreach - vypíše vždy obsah jednoho řádku od 0. a pak pokračuje na další řádek
            foreach (int cislo in cisla)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();

            //For - pro výpis jako matice/tabulka
            Console.WriteLine(prazdnePole.GetLength(0)); //vrací počet řádků
            Console.WriteLine(prazdnePole.GetLength(1)); //vrací počet sloupců

            //Vnější for cyklus jde po řádcích
            for (int i = 0; i < cisla.GetLength(0); i++)
            {
                //Vnitřní for na i-tém řádku projde všechny sloupce
                for (int j = 0; j < cisla.GetLength(1); j++)
                {
                    Console.Write(cisla[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
