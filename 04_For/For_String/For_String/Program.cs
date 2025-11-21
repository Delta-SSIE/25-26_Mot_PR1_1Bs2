namespace For_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi slovo");
            string slovo = Console.ReadLine();

            //"Ahoj"
            /* 
             * A
             * H
             * O
             * J
             */

            //Program, co vypíše slovo po znacích na řádek
            for (int i = 0; i < slovo.Length; i++)
                //slovo.length při slově "Ahoj" je 4
                //indexy začínají od 0
            {
                Console.WriteLine(slovo[i]); //vypiš znak ve slově na i-tém indexu
                //[ pravý alt + f ; ] pravý alt + g
            }

            //Vypsat do řádku, pouze každý 2. znak ze slova
            for (int i = 1; i < slovo.Length; i+=2)
            {
                Console.Write(slovo[i]);
            }
            Console.WriteLine();

            //Vypsat do řádku, pouze znaky 'o'/'O', nebo 'a'/'A' ze slova
            for (int i = 0; i < slovo.Length; i++)
            {
                if (slovo[i] == 'o' || slovo[i] == 'O' || slovo[i] == 'a' || slovo[i] == 'A')
                {
                    Console.Write(slovo[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
