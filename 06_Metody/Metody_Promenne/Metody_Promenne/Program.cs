namespace Metody_Promenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] jmena = { "Honza", "Pavel", "Petr" };
            int index = 0;
            (index, jmena) = NajdiJmeno(jmena); //Tuple volání
            //to co se vratí jako int se uloží do indexu
            //to co se vrací jako string[] se uloží do jmen
            Console.WriteLine(jmena[index]);
            foreach (string jmeno in jmena)
            {
                Console.Write(jmeno + " ");
            }
            Console.WriteLine();

            //Reference
            int cislo = 2;
            NasobDvema(ref cislo);
            Console.WriteLine(cislo); //4
            //Out
            NasobDvema2(cislo,out cislo);
            Console.WriteLine(cislo); //8

            Console.WriteLine(staticNum);
            staticNum++;
            Plus();
            Console.WriteLine(staticNum);
        }

        //Statické proměnná, vidí jí všechny metody, které jsou ve třídě Program
        static int staticNum = 5;

        static void Plus()
        {
            staticNum++;
        }

        //Metoda s out
        static void NasobDvema2(int cislo, out int vysledek)
        {
            vysledek = cislo * 2; // num = num * 2;
        }

        //Metoda s referencí jako parametrem
        static void NasobDvema(ref int num)
        {
            num *= 2; // num = num * 2;
        }

        //Tuple - vracení dvou proměnných z metody
        //metoda vrací int a string[]
        static (int, string[]) NajdiJmeno(string[] data)
        {
            Console.WriteLine("Zadej mi jméno");
            string jmeno = Console.ReadLine();
            int index = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if(jmeno == data[i])
                {
                    data[i] = "Smazáno";
                    index = i;
                    break;
                }
            }
            //vracení int index a string[] data
            return (index, data);
        }
    }
}
