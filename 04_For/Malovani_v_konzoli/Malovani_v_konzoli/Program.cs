namespace Malovani_v_konzoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chci udělat do konzole čáru z hastagů - #######
            for (int i = 0; i < 100; i++)
            {
                Console.Write('#');
            }
            Console.WriteLine();

            //Přerušovaná čára #-#-#-#
            for (int i = 0; i < 100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write('#');
                } else
                {
                    Console.Write('-');
                }
                
            }
            Console.WriteLine();

            //Přerušovaná čára s různým počtem hastagů a spojovníků ####--####--####--####
           
            //Stokrát budu opakovat '####--'
            for (int i = 0; i < 100; i++)
            {
                //Console.Write("#####");
                //Vnitřní for cyklus, co se opakuje 4krát a vypisuje vždy #
                for (int j = 0; j < 4; j++)
                {
                    Console.Write('#');
                }
                //Vnitřní for cyklus, který se opakuje 2krát a vypisuje vždy -
                for (int n = 0; n < 2; n++)
                {
                    Console.Write('-');
                }
            }
            Console.WriteLine();

            //2D čtverec
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}
