using System.ComponentModel;

namespace KdyUzPadneSestka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program hází kostkou k6 a hází, dokud nehodí 6!");
            Random kostka = new Random();

            //proměnná pro ukládání hodů
            int hod = 0;
            char opakovani = 'a';

            //Vnější while se opakuje, dokud hodnota v proměnné opakovani  se rovna 'a'
            while(opakovani == 'a')
            {
                //proměnná pro počítání počtu hodů
                int pocet_hodu = 0;

                do
                {
                    hod = kostka.Next(1, 7); //hod 1-6
                    Console.Write(hod + ", ");
                    pocet_hodu++;
                } while (hod != 6);
                //cyklus se opakuje, pokud se hod nerovná 6
            
                Console.WriteLine(); //Zalomení řádku
                Console.WriteLine($"Celkově jsem hodil kostkou {pocet_hodu}krát, než jsem hodil 6");
                Console.WriteLine("Pokud chceš házení opakovat stiskni tlačítko 'a'");
                opakovani = Console.ReadKey().KeyChar;
            }
        }
    }
}
