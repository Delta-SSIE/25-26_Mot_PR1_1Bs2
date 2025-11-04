namespace Soucet_Interval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej okraj intervalu");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhý okraj intervalu");
            int y = int.Parse(Console.ReadLine());

            int max = Math.Max(x, y); //uloží to do max větší z čísel x a y
            int min = Math.Min(x, y); //uloží to do min menší z čísel x a y

            int soucet = 0;

            while(min <= max)
            {
                soucet += min;
                min++;
            }
            Console.WriteLine($"Součet čísel v intervalu (včetně okrajů) je {soucet}");
        }
    }
}
