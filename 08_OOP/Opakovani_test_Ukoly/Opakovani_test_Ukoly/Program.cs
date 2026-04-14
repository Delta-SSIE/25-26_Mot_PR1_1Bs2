namespace Opakovani_test_Ukoly
{
    public enum KategoriePrace
    {
    VyvojSoftware,
    Marketing,
    Ucetnictvi,
    Grafika

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] pracovnici = new Worker[10];
            for (int i = 0; i < pracovnici.Length; i++)
            {
                pracovnici[i] = new Worker();
            }
            Task[] ukoly = new Task[50];
            int pocetZadanychUkolu = 0;

            Console.WriteLine("zadej odbornost");
            int odbornost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("zadej pocet hodin");
            int pocetHodin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("zadej rozpocet");
            int rozpocet = Convert.ToInt32(Console.ReadLine());

            ukoly[pocetZadanychUkolu] = new Task(pocetZadanychUkolu, (KategoriePrace)odbornost, pocetHodin, rozpocet);
            pocetZadanychUkolu++;
        }
    }
}
