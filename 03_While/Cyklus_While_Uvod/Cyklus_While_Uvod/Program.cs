namespace Cyklus_While_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Odpočítávadlo
            /*
            Console.WriteLine("5!");
            Console.WriteLine("4!");
            Console.WriteLine("3!");
            Console.WriteLine("2!");
            Console.WriteLine("1!");
            Console.WriteLine("0!");
            Console.WriteLine("Start!");
            */

            //Odpočítávadlo s cyklem WHILE

            int pocitadlo = 5;

            //Cykluse se opakuje, dokud pocitadlo je větší, nebo rovno 0
            while(pocitadlo >= 0) //podmínka, pokud platí vykoná se tělo cyklu
            //Tělo cyklu - pokaždé se vykoná dokud podmínka platí
            {
                Console.WriteLine(pocitadlo + "!"); //výpis pocitadla
                pocitadlo--; //snížení pocitadla o 1
            }
            Console.WriteLine("Start!");

            int pocitadlo2 = 0;

            //Program, který počítá od 0 do 10
            while(pocitadlo2 <= 10)
            {
                Console.WriteLine(pocitadlo2);
                pocitadlo2++;
            }

            //Načítání slova z charů pomocí cyklu While
            /*
            string text = "";

            Console.WriteLine("Zadej mi znak a já ho pořidám do řetězce, který nakonec vypíšu! Pro ukončení zadej 0");
            char znak = Console.ReadKey().KeyChar;
            text += znak;
            while(znak != '0')
            {
                Console.WriteLine("\nZadej mi další znak: (0 pro ukončení)");
                znak = Console.ReadKey().KeyChar;
                text += znak;
            }
            Console.WriteLine("\n"+text);
            */


            //Načítač znaků do stringu v2 – DO WHILE
            string text = "";
            char znak = ' ';

            //Do while oproti while vykoná tělo cyklu, alespoň 1xkrát
            do
            {
                Console.WriteLine("\nZadej mi další znak: (0 pro ukončení)");
                znak = Console.ReadKey().KeyChar;
                //Podmínka, aby se do textu nepřidal ukončovací znak 0
                if(znak != '0')
                {
                    text += znak;
                } 
            } while (znak != '0') ;
            //podmínka cyklu se ověřuje nakonci až po průchodu tělem

            Console.WriteLine("\n" + text);
        }
    }
}
