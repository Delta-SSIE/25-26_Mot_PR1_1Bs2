namespace Logicke_operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool dospelost = true;
            bool penize = false;

            //Logický operator AND (a zároven)
            //Pravý ALT + C = & (AND = &&)
            //Musí platit obě strany, tzn. musí obojí být TRUE
            if (dospelost == true && penize == true)
            {
                Console.WriteLine("Může do baru!");
            } else
            {
                Console.WriteLine("Nemůže do baru!");
            }

            //Logický operátor OR (nebo)
            //Pravý ALT + W = | (OR = ||)
            //Stačí, aby jedna strana (nebo obě) byla/y TRUE
            if (dospelost == true || penize == true)
            {
                Console.WriteLine("Může do baru!");
            }
            else
            {
                Console.WriteLine("Nemůže do baru!");
            }

            //Logický operátor NOT (negace)
            //! (SHIFT + §)
            if (!(dospelost == true || penize == true))
            {
                Console.WriteLine("Může do baru!");
            }
            else
            {
                Console.WriteLine("Nemůže do baru!");
            }

            //Složené podmínky
            bool vstupenka = true;
            //Podmínka - do baru může ten, kdo má bud vstupenku, nebo má peníze a zároven mu je 18+
            if((vstupenka || penize) && dospelost)
            {
                Console.WriteLine("Může do baru");
            } else
            {
                Console.WriteLine("Nemůže do baru!");
            }
        }
    }
}
