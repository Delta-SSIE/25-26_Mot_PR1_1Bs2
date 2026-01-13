namespace Uvod_Metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pozdrav(); //volání metody
            //Metoda se vykoná v rámci svého zavolání

            string jmeno = "Honza";
            //Volání metody s jedním parametrem, zadaním jednoho argumentu
            PozdravJmeno("Kuba"); //"Kuba" je argument pro parametr name
            PozdravJmeno(jmeno); //hodnota proměnné jmeno se pošle jako argument pro parametr name

            //Console.WriteLine(jmeno);

            int soucet = Soucet(1, 5);
            Console.WriteLine(soucet);
            soucet = Soucet(100, 52);
            soucet += Soucet(5, 10);
            Console.WriteLine(soucet);

            //Praktické použití
            int x = BezpecneNacteni();
            int y = BezpecneNacteni();
            Console.WriteLine(x + y);

        }

        static int BezpecneNacteni()
        {
            Console.WriteLine("Zadej mi celé číslo.");
            int num = 0;
            while(!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Zadeji mi opravdu číslo!!!");
            }
            return num;
        }


        //Metoda Soucet
        //Metoda má 2 parametry - int x a int y
        //místo void se píše datový typ, který budeme z metody vracet
        static int Soucet(int x, int y)
        {
            int sum = x + y;
            return sum; //vrátí zpět do Mainu hodnotu proměnné sum
            //return x+y;
        }


        //Metoda PozdravJmeno
        //má 1 parametr, uvedený v závorce za jménem
        static void PozdravJmeno(string name)
        {
            //name existuje, protože to je parametr metody. Mohu ho volat jako proměnnou.
            Console.WriteLine($"Hello {name}");
            /* když změníme name nebude to mít vliv na proměnné v Mainu
            name = "Pepík";
            Console.WriteLine($"Hello {name}");
            */
        }

        //Metoda Pozdrav
        //je statická, protože existuje v rámci instance dané třídy
        //je void (prázdná), protože nevrací žádnou hodnotu
        //nemá žádný parametry, proto má za jménem prázdné závorky
        static void Pozdrav()
        {
            //Součást metody
            Console.WriteLine("Hello, World!");
            //Console.WriteLine($"Hello {jmeno}"); jmeno neexistuje v kontextu metody Pozdrav
        }
    }
}
