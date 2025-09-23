namespace datove_typy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Destinné číslo
            float desCislo = 4.123456789f; //f se v případě floatu vždy musí zapsat
            //float se zaokrouhluje v případě více čísel
            double myDouble = 4.123456789; //d se u doublu nemusí psát
            Console.WriteLine(desCislo);
            Console.WriteLine(myDouble);

            //boolean
            bool myBool = true;
            myBool = false;
            Console.WriteLine(myBool);

            //char - jeden znak
            char znak = 'c'; //jednoduché uvozovky
            //SHIFT + ¨¨ (ta klávesa je poblíž ENTER a vedle !)
            znak = 'd';
            Console.WriteLine(znak);

            //Vstup pro znak
            Console.WriteLine("Napiš jedno písmeno");
            char input = Console.ReadKey().KeyChar;
            //KeyChar musí být součástí, aby to rovnou bralo výstup z klávesy jako písmeno.
            Console.WriteLine();
            Console.WriteLine(input);

            //Výpis znaků
            Console.WriteLine(input + "" + znak); //bez stringu to bude chary sčítat
            Console.WriteLine(input + znak); //převedou se na int a sečtou se
            //hodnoty znaků viz. ASCII tabulka

            //Převod datových typů

            //int x = "9";
            //int y = 'd';
            //char na int lze, string na int nelze

            //Implicit casting
            //char -> int -> long -> float -> double (nelze naopak)
            float myFloat = znak; //char -> float (lze)
            Console.WriteLine(myFloat);
            //znak = myFloat; //float -> char (nelze)

            //Explicit casting
            //otočená řada jako u implicit castingu
            znak = (char)myFloat;
            //jenom se přidává (typ na který převádíme)
            Console.WriteLine(znak);

            //Když chci načíst od uživatele vstup
            //int inputX = Console.ReadLine(); tohle nelze
            //Console.Readline() načítá string

            //Sčítačka
            string inputX = Console.ReadLine();
            //inputX převedu na int x pomocí Convert
            int x = Convert.ToInt32(inputX);
            
            //inputY převedu na int y pomocí Parse
            string inputY = Console.ReadLine();
            int y = int.Parse(inputY);
        
            Console.WriteLine(x+y);

            //Sčítačka 2.0 bez string proměnných navíc
            x = Convert.ToInt32(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            Console.WriteLine(x + y);

        }
    }
}
