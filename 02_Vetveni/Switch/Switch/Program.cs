namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi pořadové číslo dne v týdnu (1-7)");
            int den = int.Parse(Console.ReadLine());

            //Switch se vždy zabývá hodnotou zapsanou v závorkách
            switch(den)
            {
                //hodnotu porovnává s jednotlivými case
                case 1:
                    Console.WriteLine("Pondělí!");
                    break; //ukončení bloku kódu, v tomto případě vyskočí ze switche ven
                case 2:
                    Console.WriteLine("Úterý!");
                    break;
                case 3:
                    Console.WriteLine("Středa!");
                    break;
                default: //default se sepne, když žádný case neodpovídá hodnotě den
                    Console.WriteLine("Chyba ve vstupu!");
                    break;
            }

            //Switch - je vikend

            switch(den)
            {
                case 6:
                    Console.WriteLine("Je to víkend");
                    break;
                case 7:
                    Console.WriteLine("Je to víkend");
                    break;
                case > 7:
                    Console.WriteLine("Neplatný vstup");
                    break;
                case < 1:
                    Console.WriteLine("Neplatný vstup");
                    break;
                default:
                    Console.WriteLine("Je to den v týdnu");
                    break;
            }

            //Switch porovnavacími a logickým operátory
            switch (den)
            {
                //deklaruje se proměnná x a přířadí se k ní hodnota den
                //pak lze za when zapsat podmínku (bool)
                case int x when (x == 7 || x == 6):
                    Console.WriteLine("Je to víkend");
                    break;
                case int x when (x < 1 || x > 7):
                    Console.WriteLine("Neplatný vstup");
                    break;
                default:
                    Console.WriteLine("Je to den v týdnu");
                    break;
            }
            
        }
    }
}
