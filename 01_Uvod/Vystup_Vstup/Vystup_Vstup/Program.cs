namespace Vystup_Vstup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Příkaz na výpis do konzole (do řádku)
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Ahoj světe!");

            //Příkaz pro výpis na řádek (vypisuje, kde je kurzor a nelomí řádek)
            Console.Write("Ahoj ");
            Console.Write("světe2!");
            Console.WriteLine(" A tohle bude na novém řádku?"); //zalomení až po výpisu

            //Pokud chci něco vypsat do konzole
            //Na řádek a pak zalomit: Console.WriteLine(co chci vypsat)
            //Na jeden řádek bez zalomení: Console.Write(co chci vypsat)

            //Proměnné
            //Deklarace proměnné - typ nazev
            string jmeno;
            int cislo;
            int cele_cislo; //mezera pomocí _
            int celeCislo; //druhé slovo začíná Velkým písmenem

            //Incializace proměnné - typ nazev = hodnota
            string name = "Jan"; // string, že hodnota musí být ""
            int myInt = 5;

            Console.WriteLine(name);
            Console.WriteLine(myInt);
            //Console.WriteLine(jmeno); nelze vypsat hodnotu proměnné bez toho, aby měla nějakou hodnotu zadanou

            //Přiřazení hodnoty k proměnné
            //nazev = hodnota
            jmeno = "Honza";
            Console.WriteLine(jmeno);
            name = "John";
            Console.WriteLine(name);

            cislo = 10;
            Console.WriteLine(cislo); //10
            cislo = 5;
            Console.WriteLine(cislo); //5

            //Vypisování do konzole
            //"+" spojuje řetězce (v tomto kontextu)
            Console.WriteLine("Ahoj "+name+"!");
            Console.WriteLine(name + " " +jmeno);
            Console.WriteLine("My name is " + name + " and I'm " + myInt + " years old!");
            //pokud je int v rámci slepeného stringu, tak se jen slepí (vypíšou se vedle sebe) cislo+myInt = 55
            Console.WriteLine("You have " + cislo+myInt + " dollars!");
            //Pokud ale není v rámci stringu, tak se sečtou
            Console.WriteLine(cislo+myInt);
            //To lze udělat i vložením závorky
            Console.WriteLine("You have " + (cislo+myInt) + " dollars!");

            //Vložení vstupu od uživatele
            Console.WriteLine("Napiš mi své jméno:");
            string username = Console.ReadLine(); //čte z konzole vstup
            Console.WriteLine("Ahoj " + username + "!");

            //Jak vypsat pro uživatele ve stringu hodnoty proměnných bez +
            Console.WriteLine("Ahoj " + username + "!");
            //před první uvozovku se dá symbol dollaru $ (Alt Gr + ů)
            //Kamkoliv do stringu napsat název proměnné v složených závorkách {} (Alt Gr + B; Alt Gr + N) 
            Console.WriteLine($"Ahoj {username}!");
            //kam chci dát proměnnou tak napíšu její pozici za stringem počínaje 0 (ve složených závorkách)
            //a za string píšu za čátku názvy proměnných
            Console.WriteLine("Ahoj {0}!",username);
            
            //Syntaxe se dvěma proměnnýma
            Console.WriteLine("Ahoj {0} a je ti {1}!", username, myInt);
            Console.WriteLine($"Ahoj {username} a je ti {myInt}!");
        }
    }
}
