namespace Test_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Počet podle cifer
            int jednaCifra = 0;
            int dveCifry = 0;
            int trojCifra = 0;
            int vetsiCifra = 0;

            double vstup = 0;

            do
            {
                Console.WriteLine("Zadej mi číslo. Pro ukončení zadej 0, či zap. číslo");
                while(!double.TryParse(Console.ReadLine(),out vstup))
                {
                    Console.WriteLine("Zadej číslo");
                }
                switch(vstup)
                {
                    case double v when v > 0 && v < 10:
                        jednaCifra++;
                        break;
                    case double v when v > 9 && v < 100:
                        dveCifry++;
                        break;
                    case double v when v > 99 && v < 1000:
                        trojCifra++;
                        break;
                    case double v when v > 999:
                        vetsiCifra++;
                        break;
                }

            } while (vstup > 0);

            Console.WriteLine($"Počet jednociferných čísel byl {jednaCifra}\nPočet dvouciferných byl {dveCifry}\nPočet trojciferných byl {trojCifra}\nPočet větších cifer byl {vetsiCifra}");
            */

            //2. Zmrzlinář

            int vanilka = 15;
            int cokolada = 20;

            int pocetV = 0;
            int pocetC = 0;
            int pocetM = 0;

            while (vanilka > 0 && cokolada > 0)
            {
                Console.WriteLine("Zadej mi jakou chceš příchuť 'm' - míchaná; 'c' - čokoládová; 'v' - vanilka");
                char prichut = Console.ReadKey().KeyChar;
                //Oštření vstupu
                while(!(prichut == 'm' || prichut == 'c' || prichut == 'v'))
                {
                    Console.WriteLine("Zadej pouze jednu z možností");
                    prichut = Console.ReadKey().KeyChar;
                }

                switch(prichut)
                {
                    case 'm':
                        vanilka--;
                        cokolada--;
                        pocetM++;
                        break;
                    case 'c':
                        cokolada--;
                        pocetC++;
                        break;
                    case 'v':
                        vanilka--;
                        pocetV++;
                        break;
                }
            }

            Console.WriteLine($"Zrmzlinář prodal {pocetM} míchaných, {pocetC} čokoládových, {pocetV} vanilkových zmrizlin.");
            Console.WriteLine($"Zrmzlináři zbylo {vanilka} vanilkové zmrzliny a {cokolada} čokoládové zmrzliny.");

        }
    }
}
