namespace Proc_trojuhelniky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radky = 15;

            //trojuhelnik b
            for (int i = 0; i < radky; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //trojuhelnik p
            for (int i = 0; i < radky; i++)
            {
                for (int j = 0; j < radky-i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //trojuhelnik q
            for (int i = 0; i < radky; i++)
            {
                for (int n = 0; n < i; n++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < radky-i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //trojuhelnik d
           for (int i = 0; i < radky; i++)
            {
                for (int n = 0; n < radky - i -1; n++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
