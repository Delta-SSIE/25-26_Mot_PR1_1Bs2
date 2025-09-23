namespace uvod_programovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Přepis výstupu Hello, World! na Ahoj světe!
            Console.WriteLine("Ahoj světe!"); //komentář za příkazem
            Console.WriteLine("Ahoj světe!");
            Console.WriteLine("Ahoj světe!");

            
            Console.WriteLine("Ahoj světe!");

            /*
                Tohle je komentář
                na více řádků
                o tom, že program
                neřeší mezery mezi příkazy!
             */

            //CTRL+K+C zakomentování kódu
            //Console.WriteLine("Ahoj světe!");

            Console.WriteLine("Ahoj světe!");

            //Incializace proměnné
            //typ název_proměnné = hodnota_proměnné
            string jmeno = "Honza";
            Console.WriteLine("Ahoj " + jmeno + "!");
            //Změna hodnoty u proměnné jmeno na Pepa
            jmeno = "Pepa";
            Console.WriteLine("Ahoj " + jmeno + "!");
        }
    }
}
