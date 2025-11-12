namespace Caesarova_sifra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi slovo a já ho zašifruji Caesarovou šifrou:");
            string slovo = Console.ReadLine();

            int pocitadlo = 0;
            string zas_slovo = "";

            int posun = 1;

            while(slovo.Length > pocitadlo)
            {
                char znak = slovo[pocitadlo]; //vytáhnu si znak na aktuálním indexu dle pocitadla
                int cislo = znak + posun; //znak převedu na čislo (hodnota v ASCII) a zvýším o 1
                if(cislo > 122) //pokud se dostanu za z
                {
                    cislo -= 26; //odečtu od toho počet znaků v abecedě
                }
                
                znak = (char)cislo; //cislo převedu zpět na znak přes explicit casting
                zas_slovo += znak; //přidám znak do zašifrovaného slova
                pocitadlo++;
            }

            Console.WriteLine(zas_slovo);

            //desifrace
            pocitadlo = 0;
            string des_slovo = "";

            while (zas_slovo.Length > pocitadlo)
            {
                char znak = zas_slovo[pocitadlo];
                int cislo = znak - posun;
                if (cislo < 97) 
                {
                    cislo += 26; 
                }

                znak = (char)cislo;
                des_slovo += znak; 
                pocitadlo++;
            }

            Console.WriteLine(des_slovo);

        }
    }
}
