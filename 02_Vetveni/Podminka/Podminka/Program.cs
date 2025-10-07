namespace Podminka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi číslo a já ti řeknu, jestli je větší než 10!");
            //Načtu vstup od uživatele do int
            int cislo = int.Parse(Console.ReadLine());
            //<> pravý alt + . ,
            Console.WriteLine($"Číslo {cislo} je větší než 10? {cislo>10}");

            //Základní podmínka IF
            //if(podminka) podmínka musí být TRUE/FALSE
            //{} vše ve složených závorkách se spustí, pokud je podmínka TRUE
            if(cislo > 10) //tady se musí napsat podmínka
            {
                //tento kód se spustí, pokud je podmínka splněna (TRUE)
                //v našem případě, to znamená, že cislo je větší než 10!
                Console.WriteLine($"Hurá! {cislo} je větší než 10!");
            }

            //IF s ELSE 
            if (cislo > 10) //když
            {
                //tento kód se spustí, pokud je podmínka splněna (TRUE)
                Console.WriteLine($"Hurá! {cislo} je větší než 10!");
            }else //jinak
            {
                //tento kód se spustí, pokud je podmínka NEsplněna (FALSE)
                Console.WriteLine($"Bohužel! {cislo} není větší než 10!");
            }

            //Semafor - ELSE IF
            Console.WriteLine("Svítí na semaforu zelená? (a/n)");
            string odpoved = Console.ReadLine();
            /* původní verze čistě IF a ELSE
            if(odpoved == "a")
            {
                Console.WriteLine("JDI!");
            } else
            {
                Console.WriteLine("STŮJ!");
            }
            */
            //ELSE IF
            if (odpoved == "a")
            {
                //Pokud podmínka odopoved == "a" je TRUE, pak se provede tento kód
                Console.WriteLine("JDI!");
            }
            else if(odpoved == "n")
            {
                //Pokud první podmínka je FALSE a podmínka odpoved == "n" je TRUE, tak se provede tento kód
                Console.WriteLine("STŮJ!");
            } else
            {
                //Pokud jsou obě podmínka FALSE, pak se provede tento kód
                Console.WriteLine("Neznámý vstup!");
            }
        }
    }
}
