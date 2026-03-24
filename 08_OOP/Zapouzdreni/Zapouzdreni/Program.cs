namespace Zapouzdreni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predmet skrin = new Predmet();
            skrin.Price = 10;
            Console.WriteLine(skrin.Price);

            skrin.Weight = -50;
            Console.WriteLine(skrin.Weight);
            skrin.Weight = 50;
            Console.WriteLine(skrin.Weight);

            skrin.Wood = 50;
            Console.WriteLine(skrin.Wood);
            skrin.Wood += 50;
            Console.WriteLine(skrin.Wood);
            skrin.Wood += 50;
            Console.WriteLine(skrin.Wood);
            skrin.Wood -= 50;
            Console.WriteLine(skrin.Wood);
            skrin.Wood -= 50;
            Console.WriteLine(skrin.Wood);
            skrin.Wood -= 50;
            Console.WriteLine(skrin.Wood);

            skrin.Name = "Skříň";
            Console.WriteLine(skrin.Name);

            Console.WriteLine(skrin.ID);
            skrin.ID = 500;
        }
    }
}
