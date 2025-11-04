namespace Nacti_sude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program bude vyzívat uživatele k zadaní čísla, dokud nezadá sudé
            //pak ho vypíše s nejbližším vyšším lichým
            
            //proměnnou cislo si připravíme mimo cyklus
            int cislo = 0;

            do
            {
                //Tělo cyklu
                //Ptáme se na vložení čísla
                Console.WriteLine("Zadej mi SUDE číslo:");
                //číslo uložíme do proměnné cislo
                cislo = int.Parse(Console.ReadLine());
            } while (cislo % 2 == 1);
            //podmínka, pokud je zbytek po dělení 2 u cisla 1, tak je cislo liché a tedy opakujeme cyklus

            Console.WriteLine($"Sudé zadané číslo je {cislo} a jeho nejbližší vyšší liché je {cislo+1}");
        }
    }
}
