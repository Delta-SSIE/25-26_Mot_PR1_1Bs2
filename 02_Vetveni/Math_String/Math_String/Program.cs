namespace Math_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math třída

            Console.WriteLine(Math.Max(10,5)); //Math.Max(cislo1,cislo2) vrátí vyšší z těchto čísel
            Console.WriteLine(Math.Min(10,5)); //Math.Max(cislo1,cislo2) vrátí nižší z těchto čísel

            Console.WriteLine(Math.PI); //hodnota PI (double)
            Console.WriteLine(Math.E); //hodnota Euklidovského čísla (double)

            Console.WriteLine(Math.Sqrt(9)); //druhá odmocnina z čísla 9
            Console.WriteLine(Math.Pow(2,5)); //mocnění
            //první číslo bude umocněné tím druhým (v našem případě 2 na 5tou)

            //STRING
            string txt = "Ahoj";
            string txt2 = "Čus";
            //Délka řetězce
            Console.WriteLine(txt.Length); //string.Length vrací počet znaků
            Console.WriteLine(txt.Length > txt2.Length);

            //Vyjmutí 1 charu ze stringu
            char a = txt[0]; //vyjme ze stringu txt znak na 0. indexu
            //"Ahoj" = 0. index = 'A'; 1. 'h'; 2. 'o'; 3. 'j'
            //Hranaté závorky: Pravý alt + F = [ ; Pravý alt + G = ]
            Console.WriteLine(a);

            Console.WriteLine(txt[3]); //vypíše písmeno na 3. indexu (j)

            //Poslední ze stringu aniž bych věděl index posledního znaku
            char posledni_znak = txt[txt.Length - 1];
            //délka - 1; "Ahoj" délka = 4; 4-1=3 (poslední index je 3)
            Console.WriteLine(posledni_znak);

            //Program zjisti zda znak je malé písmeno
            Console.WriteLine("Zadej mi znak");
            char znak = Console.ReadKey().KeyChar;
            
            //Převod char na int
            /*
            int cislo_zeZnaku = znak;
            Console.WriteLine(cislo_zeZnaku);
            */
            
            //ASCII tabulka převodu znaků na čísla
            // a = 97; z = 122; malá abeceda 97-122
            if(znak >= 97 && znak <= 122)
            {
                Console.WriteLine("Jedná se o malé písmeno");
            } else
            {
                Console.WriteLine("Nejedná se o malé písmeno");
            }


            //Program - První písmeno slova je velké písmeno?
            Console.WriteLine("Zadej mi slovo");
            string slovo = Console.ReadLine();

            //ASCII tabulka; 65 = A a 90 = Z
            //slovo[0] je znak na 0. indexu (první znak daného slova)
            if (slovo[0] >= 65 && slovo[0] <= 90)
            {
                Console.WriteLine("První písmeno slova JE velké písmeno");
            }
            else
            {
                Console.WriteLine("První písmeno slova NENÍ velké písmeno");
            }

        }
    }
}
