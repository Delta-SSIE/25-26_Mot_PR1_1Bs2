namespace Malovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D čtverec

            //Vnější for cyklus na procházení přes řádky
            for (int i = 0; i < 5; i++)
            {
                //Vnitřní for cyklus na procházení sloupců v řádku
                for (int j = 0; j < 5; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine(); //zalomení řádku za vnitřním for cyklem
            }
            Console.WriteLine("------");            
            
            //2D obdelník

            for (int i = 0; i < 5; i++) //počet řádků
            {
                for (int j = 0; j < 25; j++) //počet sloupců (tzn. kolik hashů je v řádku)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine("------");
            //2D obdelník - kde se budou na řádku kombinovat znaky # a X
            //#X#X#X#

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 25; j++) 
                {
                    if(j % 2 == 0)
                    {
                        Console.Write('#');
                    } else
                    {
                        Console.Write('X');
                    }
                    
                }
                Console.WriteLine();
            }
                Console.WriteLine("------");
            //2D obdelník - kde do poloviny řádku budou # a pak X
            //#####XXXXX
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 15; j++) //na řádek se vypíše 5x #
                {
                    Console.Write('#');
                }
                for (int n = 0; n < 15; n++) //na řádek se vypíše 5x X
                {
                    Console.Write('X');
                }
                Console.WriteLine(); //zalomí řádek
            }


        }
    }
}
