namespace Znaky_Slova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi slovo");
            string slovo = Console.ReadLine();

            //Console.WriteLine(slovo[0]); //vypíše písmeno na 0. indexu
            /*
            Console.WriteLine(slovo[0]);
            Console.WriteLine(slovo[1]);
            Console.WriteLine(slovo[2]);4
            */

            int pocitadlo = 0; //pomocné počitadlo

            while(slovo.Length > pocitadlo)
                //opakuj dokud pocitadlo je menší než délka slova
            {
                Console.WriteLine(slovo[pocitadlo]); //vypíše znak na indexu hodnoty proměnné pocitadlo
                pocitadlo++; //po každém průchodu cyklu zvýším počítadlo o 1
            }


            Console.WriteLine("Zadej mi znak a já ti řeknu, zda v daném slově je, či není");
            char znak = Console.ReadKey().KeyChar;

            //Cyklus, který projde slovo a zjistí, zda v něm je přítomen znak uložený v proměnné znak.

            //vynulovaní počitadla
            pocitadlo = 0;
            //proměnná, která bude zaznamenávat, zda byl znak nalezen
            bool nalezeno = false;

            while (slovo.Length > pocitadlo)
            {
                //Pokud se znak ve slově na indexu pocitadlo rovná znaku
                if (slovo[pocitadlo] == znak)
                {
                    nalezeno = true;
                    break; //ukončení cyklu
                }
                pocitadlo++;
            }

            Console.WriteLine("\nByl znak nalezen: " + nalezeno);

            //Cyklus, který projde slovo a zjistí kolikrát v něm je daný znak
            pocitadlo = 0;
            int pocet_znaku = 0;

            while (slovo.Length > pocitadlo)
            {
                if (slovo[pocitadlo] == znak)
                {
                    pocet_znaku++;
                }
                pocitadlo++;
            }

            Console.WriteLine($"Počet znaků '{znak}' ve slově '{slovo}' je {pocet_znaku}");


        }
    }
}
