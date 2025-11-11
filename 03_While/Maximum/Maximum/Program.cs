namespace Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //proměnná do které budu ukládat číslo zadané uživatelem
            int cislo = 0;
            //proměnná pro zapsaní nalezeného maxima
            int max = 0;

            do
            {
                Console.WriteLine("Zadej mi číslo");
                cislo = int.Parse(Console.ReadLine());
                //Pokud je nově načtené číslo větší než nalezené maximum, pak se hodnota maxima změní na zadané číslo
                if(cislo > max)
                {
                    max = cislo;
                }

            } while (cislo > 0);
            //Cyklus se opakuje dokud je v proměnné cislo uložená hodnota vyšší než 0

            Console.WriteLine($"Nejvyšší zadané číslo je {max}");
        }
    }
}
