namespace Uvod_Pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializace pole
            //pole o délce 3 s 3 třema zadanýma hodnotama
            int[] cisla = { 25, 30, 25 };
            //pole o délce 10 bez zadaných hodnot
            string[] jmena = new string[10];

            //Práce s hodnotami v poli
            Console.WriteLine(cisla[0]); //první prvek z pole cisla
            Console.WriteLine(cisla[2]); //prvek z pole čisla na indexu 2
            Console.WriteLine(cisla[cisla.Length-1]); //vypíše poslední prvek z pole cisla

            //Přepis hodnot
            cisla[0] = 5;
            jmena[0] = "Jaromír";
            jmena[1] = "Vavřinec";
            //nazevpole[index] = hodnota

            //Procházení pole
            //Cyklus for

            //Dokud je i menší než délka pole, tak se cyklus opakuje
            //Délka pole jmena je 10 a má indexy od 0 do 9
            for (int i = 0; i < jmena.Length; i++)
            {
                //Postupně změní všechny hodnoty v poli jmena na hodnotu "Jindřich"
                jmena[i] = "Jindřich";
            }
            for (int i = 0; i < jmena.Length; i++)
            {
                //Postupně vypíše všechny prvky z pole jmena
                Console.WriteLine(jmena[i]);
            }

            //Naplnění pole
            //Naplň pole násobky, násobky čisla uloženého v proměnné nasobek od 1-10
            int[] nasobky = new int[10];
            int nasobek = 2;

            for (int i = 0; i < nasobky.Length; i++)
            {
                nasobky[i] = nasobek * (i + 1);
                Console.WriteLine(nasobky[i]);
            }

            //Uživatel naplní pole čísly.
            //Následně se projde pole a vypíše se počet licých a sudých čísel

            int[] pole_cisla = new int[3];

            for (int i = 0; i < pole_cisla.Length; i++)
            {
                Console.WriteLine($"Napiš {i+1}. číslo");
                //pole_cisla[i] = int.Parse(Console.ReadLine());
                while (!int.TryParse(Console.ReadLine(), out pole_cisla[i]))
                {
                    Console.WriteLine("Zadej číslo!");
                }
            }

            int suda = 0;
            int licha = 0;

            for (int i = 0; i < pole_cisla.Length; i++)
            {
                if (pole_cisla[i] % 2 == 0)
                {
                    suda++;
                } else
                {
                    licha++;
                }
            }

            Console.WriteLine($"V poli je {suda} sudých čísel a {licha} lichých čísel!");

            //Foreach průchod kolekcemi (btw. pole je kolekce)

            //při každým průchodu foreachem se do proměnné jmeno načte hodnota z pole jmena
            //foreach vždy projde pole od začátku do konce
            foreach (string jmeno in jmena)
            {
                Console.WriteLine(jmeno);
            }

            /* Foreach neumí přepisovat hodnoty v poli, které prochází
            foreach (string jmeno in jmena)
            {
                jmeno = "Petr";
            }
            */

            foreach (int cislo in cisla)
            {
                Console.WriteLine(cislo);
            }


        }
    }
}
