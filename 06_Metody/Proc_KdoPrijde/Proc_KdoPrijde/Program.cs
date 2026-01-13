namespace Proc_KdoPrijde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Přijde také {jmeno}
            PrijdeI("Pepa");
            PrijdeI("Karel");
            PrijdeI("Eliška");

            Console.WriteLine(PrijdeII("Ivan"));
            Console.WriteLine(PrijdeII("Ludmila"));
            Console.WriteLine(PrijdeII("Ulrich"));

        }

        static string PrijdeII(string jmeno)
        {
            return $"Přijde také {jmeno}";
        }

        static void PrijdeI(string jmeno)
        {
            Console.WriteLine($"Přijde také {jmeno}");
        }
    }
}
