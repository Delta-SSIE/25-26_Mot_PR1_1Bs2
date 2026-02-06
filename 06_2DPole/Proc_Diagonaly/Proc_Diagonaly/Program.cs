namespace Proc_Diagonaly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] pole = new string[21, 21];
            
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        pole[i, j] = "#";
                    } else if(j == pole.GetLength(1)-1-i)
                    {
                        pole[i, j] = "#";
                    } else
                    {
                        pole[i, j] = " ";
                    }
                    
                }
            }

            /*
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                pole[i, i] = "#";
            }
            */
            Vypis2Dpole(pole);
        }

        static void Vypis2Dpole(string[,] pole)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write(pole[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
