namespace Kruh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radky = 5;

            for (int i = 0; i < radky; i++)
            {
                for (int j = 0; j <= i; j++) //tady se musí upravit počet mezer, aby jich na začátku bylo hodně a postupně méně
                {
                    Console.Write(' ');
                }
                for (int k = 0; k <= i; k++) 
                {
                    Console.Write('#');
                }
                for (int l = 0; l <= i; l++) //tady se musí upravit počet mezer, aby jich na začátku bylo hodně a postupně méně
                {
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
