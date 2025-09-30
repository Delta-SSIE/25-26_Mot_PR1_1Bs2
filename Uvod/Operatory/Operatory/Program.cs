namespace Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            
            //Inkriminace
            x++; // x = x + 1
            x++; // x = x + 1
            //Deinkriminace
            x--; // x = x - 1
            Console.WriteLine(x);

            //Přiřazovací operátory
            //do proměnné x se uloží její původní hodnota + 2 
            x = x + 2;
            Console.WriteLine(x);
            //Zkracený zápis
            x += 2; // x = x + 2
            x -= 2; // x = x - 2
            Console.WriteLine(x);

            //Porovnávací operátory
            // == je rovná se
            // = je přiřaď hodnotu
            Console.WriteLine(1==1);
            Console.WriteLine(1 == 2);

            //Větší a menší
            //pravý ALT + , = < 
            //pravý ALT + . = >
            Console.WriteLine( 5 > 1);
            Console.WriteLine(1 < 5);

            //Větší nebo rovno a menší nebo rovno
            Console.WriteLine(5 < 5);
            Console.WriteLine(5 <= 5);

            //Negace (nerovná se)
            Console.WriteLine(5 != 5);
            Console.WriteLine(1 != 5);

        }
    }
}
