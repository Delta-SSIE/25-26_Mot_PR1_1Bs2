namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int cislo = int.Parse(Console.ReadLine());
            //Chceme zabránit padaní při zadaní jiného vstupu než číslo

            Console.WriteLine("Zadej mi vstup");
            string vstup = Console.ReadLine();

            //int cislo = int.Parse(vstup);

            //pro bezepečný převod na číslo
            //datovy_typ.TryParse(vstup, out proměnná v datovém typu)

            int cislo = 0;
            int.TryParse(vstup, out cislo);
            //pokusí se to převést hodnotu v proměnné vstup na int a ten uloží do proměnné cislo
            //Console.WriteLine(cislo);
            //pokud je ve vstupu hodnota, která lze převést na int, tak se převede a uloží do cisla
            //pokud je ve vstupu hodnota, která NELZE převést na int, tak se nic do cisla neukládá (zůsztane tam původní 0)

            double des_cislo = 0;
            Console.WriteLine("Zadej mi des. číslo");
            double.TryParse(Console.ReadLine(), out des_cislo);
            //upravený TryParse, aby místo proměnné se stringem bral rovnou vstup do konzole
            Console.WriteLine(des_cislo);

            //TryParse a cyklus While (pro donucení uživatele, aby nám zadal číslo)
            int zad_cislo = 0;
            Console.WriteLine("Zadej mi číslo, prosím!");
            while(!int.TryParse(Console.ReadLine(),out zad_cislo))
                //! neguje výraz (pokud se podaří parsovat podmínka je true, jinak false) - tohle neguji
                //nyní podmínka říká, pokud se nepodařilo parsovat, tak podmínka je true
            {
                Console.WriteLine("Hele kámo, to není číslo! Zadej mi fakt CELÉ číslo!");
            }

            Console.WriteLine(zad_cislo);

            //TryParse a cyklus s des cislem

            float dess_cislo = 0;
            Console.WriteLine("Zadej mi des. cislo");
            while(!float.TryParse(Console.ReadLine(), out dess_cislo))
            {
                Console.WriteLine("Já jsem řekl desetinné číslo! Tak koukej zadat to a nic jiného!");
            }
            Console.WriteLine(dess_cislo);
        }

    }
}
