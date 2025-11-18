namespace Test_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
