namespace Sifra_zmenZnak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char znak_nahrad = ' ';
            char znak_zasif = ' ';

            //načtení malého písmena s kontrolou vstupu
            do
            {
                Console.WriteLine("Zadej mi malé písmeno, kterým budu měnit malé písmeno, který mi zadáš");
                znak_nahrad = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (!(znak_nahrad >= 97 && znak_nahrad <= 122));

            do
            {
                Console.WriteLine("Zadej mi malé písmeno, kterým budu měnit malé písmeno, který mi zadáš");
                znak_zasif = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (!(znak_zasif >= 97 && znak_zasif <= 122));

            Console.WriteLine("Zadej mi slovo, které budeme šifrovat a dešifrovat");
            string slovo = Console.ReadLine();

            //Sem uložím zašifrované slovo
            string zasif_slovo = "";

            int pocitadlo = 0;

            //cyklus, který prochází slovo po znacích
            while (slovo.Length > pocitadlo)
            {
                if (slovo[pocitadlo] == znak_zasif)
                    //pokud je znak ve slově na indexu pocitadlo roven znaku, který máme zašifrovat
                {
                    zasif_slovo += znak_nahrad; 
                    //nahraju do zašifrovaného slova znak, kterým máme šifrovaný znak nahradit
                } else
                {
                    zasif_slovo += slovo[pocitadlo]; 
                    //pokud se nejedná o znak, který máme šifrovat, tak ho nahraji do zašifrovaného slova
                }
                    pocitadlo++; //po každém průchodu tělem zvyš počítadlo o 1
            }

            Console.WriteLine(zasif_slovo);

            string des_slovo = "";
            pocitadlo = 0;

            //dešifrace

            while (zasif_slovo.Length > pocitadlo)
            {
                if (zasif_slovo[pocitadlo] == znak_nahrad)
                {
                    des_slovo += znak_zasif;
                }
                else
                {
                    des_slovo += slovo[pocitadlo];
                }
                pocitadlo++;
            }

            Console.WriteLine(des_slovo);

        }
    }
}
