namespace Lode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //předem nastavená velikost hrací plochy
            int velikost = 8;

            //vytvoření tří poli pro hru
            int[,] hrac = new int[velikost,velikost];
            int[,] hrac_strely = new int[velikost, velikost];
            int[,] souper = new int[velikost, velikost];

            //naplnění polí vodou (0)
            hrac = NaplnPole(hrac);
            hrac_strely = NaplnPole(hrac_strely);
            souper = NaplnPole(souper);

            //Výpis pole
            VypisPole(hrac);
        }
        //Metoda na výpis hracího pole
        static void VypisPole(int[,] pole)
        {
            //Výpis indexů sloupců
            Console.Write(" "); //mezera kvůli posunu
            for (int i = 0; i < pole.GetLength(1); i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                //Vypíšu index řádku
                Console.Write(i); //kdybych chtěl začít 1, tak i+1
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    switch(pole[i,j])
                    {
                        case 0:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(" ");
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write('L');
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write('X');
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write('O');
                            break;
                    }
                    Console.ResetColor(); //vyresetuje barvu konzole
                }
                Console.WriteLine();
            }
        }

        //Metoda na naplnění pole, defaultní hodnota náplně je 0
        static int[,] NaplnPole(int[,] pole, int napln = 0)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = napln;
                }
            }
            return pole;
        }
    }
}
