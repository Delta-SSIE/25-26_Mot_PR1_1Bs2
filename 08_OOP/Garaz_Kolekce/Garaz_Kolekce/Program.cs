namespace Garaz_Kolekce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Incializace objektu z třídy Auto
            Auto moje_auto = new Auto();

            //Nahraní hodnot do vlastností
            moje_auto.pocetKol = 4;
            moje_auto.SPZ = "XXX";

            //Incializace objektu s hodnotami na vlastnotech
            Auto sousedovo_auto = new Auto
            {
                SPZ = "YYY",
                pocetKol = 3
            };

            //Volání metody u objektů
            moje_auto.PredstavSe();
            sousedovo_auto.PredstavSe();

            //Volání metod s parametrem
            sousedovo_auto.OdeberKola(2);
            sousedovo_auto.PredstavSe();
            sousedovo_auto.OdeberKola(2);
            sousedovo_auto.PredstavSe();

            //Vlastnost jako pole
            moje_auto.pasazeri = ["Šimon", "Fanda", "Ondřej"];
            sousedovo_auto.pasazeri = ["Elena", "Tomáš"];

            //Vypsání hodnot z pole, které je vlastnost objektu
            Console.WriteLine(moje_auto.pasazeri[1]); //vypíše u objektu moje_auto, co je ve vlastnosti pasazeri (pole) na 1. indexu
            Console.WriteLine(moje_auto.VratPasazeri());
            Console.WriteLine(sousedovo_auto.VratPasazeri());

        }
    }
}
