namespace Resize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializace pole
            int[] cisla = { 2, 5, 6, 7 }; //velikost -> 4
            string[] slova = new string[10]; //prázdné pole s velikostí 10

            Console.WriteLine(cisla[0]);
            Console.WriteLine(slova[0]);

            Console.WriteLine(slova[5]);
            //Console.WriteLine(cisla[5]);

            //Resize
            Console.WriteLine(slova.Length);
            Array.Resize(ref slova, 5); //změna velikosti pole slova z 10 na 5
            Console.WriteLine(slova.Length);

            foreach (int cislo in cisla)
            {
                Console.WriteLine(cislo); //2, 5, 6, 7 
            }
            Array.Resize(ref cisla, 2);//změna velikosti pole cisla z 4 na 2
            foreach (int cislo in cisla)
            {
                Console.WriteLine(cislo);//2, 5
            }

            //Praktické použití
            string[] hraci = { "Pepa", "Lukáš", "Zdenda", "Karel" };
            foreach (string hrac in hraci)
            {
                Console.Write(hrac);
            }
            Console.WriteLine();

            //Jak do pole přidat Martina?
            Array.Resize(ref hraci, hraci.Length + 1); //zvětšení pole hráčů o 1
            hraci[hraci.Length - 1] = "Martin"; //na poslední (nový) index v poli přidám Martina
            foreach (string hrac in hraci)
            {
                Console.Write(hrac);
            }
            Console.WriteLine();

            //Jak z pole odebrat Lukáše
            string lavicka = ""; //pomocná proměnná
            lavicka = hraci[1]; //Lukáš
            hraci[1] = hraci[hraci.Length - 1]; //Martinem přepisuji hodnotu Lukáše
            hraci[hraci.Length - 1] = lavicka; //Lukášem přepíšu původní hodnotu Martina
            foreach (string hrac in hraci)
            {
                Console.Write(hrac);
            }
            Console.WriteLine();
            Array.Resize(ref hraci, hraci.Length - 1); //zkrácení pole o 1
            foreach (string hrac in hraci)
            {
                Console.Write(hrac);
            }
            Console.WriteLine();





        }
    }
}
