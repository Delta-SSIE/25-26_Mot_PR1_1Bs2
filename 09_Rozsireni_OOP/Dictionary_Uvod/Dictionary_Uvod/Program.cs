namespace Dictionary_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Určuji jaký datový typ je klíč a jaký je hodnota
            Dictionary<string, string> CeskoAnglickySlovnik = new Dictionary<string, string>();

            CeskoAnglickySlovnik.Add("Auto", "Car");

            Console.WriteLine(CeskoAnglickySlovnik["Auto"]);

            Dictionary<string, int> TelefoniSeznam = new Dictionary<string, int>();
            TelefoniSeznam.Add("Pepa Omáčka", 483111222);
            TelefoniSeznam.Add("Jindřich Smutný", 483951357);

            Console.WriteLine(TelefoniSeznam["Pepa Omáčka"]);

            //Iterace Dicationary
            foreach(string klic in TelefoniSeznam.Keys)
            {
                Console.WriteLine(klic +": "+ TelefoniSeznam[klic]);
            }
            foreach (int hodnota in TelefoniSeznam.Values)
            {
                Console.WriteLine(hodnota);
            }
            foreach(KeyValuePair<string,int> zaznam in TelefoniSeznam)
            {
                Console.WriteLine(zaznam.Key +": "+zaznam.Value);
            }

            //Remove
            TelefoniSeznam.Remove("Pepa Omáčka"); //Vymaže položku z slovníku na klíči "Pepa Omáčka"

            //Contains
            //ContainsKey/Value vrací true/false pokud daný klíč/hodnota je v slovníku
            Console.WriteLine(TelefoniSeznam.ContainsKey("Pepa Omáčka"));
            Console.WriteLine(TelefoniSeznam.ContainsValue(483951357));
        }
    }
}
