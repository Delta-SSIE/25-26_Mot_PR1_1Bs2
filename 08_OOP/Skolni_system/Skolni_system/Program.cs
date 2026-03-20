namespace Skolni_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Student pepca = new Student(0, true);
            Student dominik = new Student(1, false, "Dominik");

            Console.WriteLine(pepca.jmeno);
            Console.WriteLine(dominik.jmeno);
            */

            Student[] skola = new Student[0]; //pole studentů s velikostí nula

            while (true) //menu v nekonečné smyčce
            {
                Console.Clear();
                Console.WriteLine("Napiš mi, co chceš dělat");
                Console.WriteLine("1. Zadat studenta\n2. Vygenerovat studenty\n3. Vypsat studety");
                int volba = OverVstup();
                
                switch(volba)
                {
                    case 1:
                        Console.WriteLine("Zadej mi jméno nového studenta");
                        string jmeno = Console.ReadLine();
                        Array.Resize(ref skola, skola.Length + 1);
                        skola[skola.Length - 1] = new Student(skola.Length, false, jmeno);
                        break;
                    case 2:
                        Console.WriteLine("Kolik chceš studentů vygenerovat?");
                        int pocet = OverVstup();
                        for (int i = 0; i < pocet; i++)
                        {
                            Array.Resize(ref skola, skola.Length + 1);
                            skola[skola.Length - 1] = new Student(skola.Length,true);
                        }
                        break;
                    case 3:
                        for (int i = 0; i < skola.Length; i++)
                        {
                            skola[i].PredstavSe();
                        }
                        Console.ReadKey();
                        break;
                }
            }
        }

        static int OverVstup()
        {
            int cislo = 0;
            while(!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Zadej číslo!");
            }
            return cislo;
        }
    }
}
