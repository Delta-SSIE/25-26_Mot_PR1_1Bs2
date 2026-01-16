namespace Proc_PocetCelychCisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] cisla = { 1, 5.2, 10.3, 5, 12.5, 13, 8 }; //4 celá čísla
            double[] cislaA = { 5.1, 6.5, 3.2, 5 }; //1 celé číslo

            Console.WriteLine($" V poli cisla je celkově {CelaCisla(cisla)} celých čísel.");
            Console.WriteLine($" V poli cislaA je celkově {CelaCisla(cislaA)} celých čísel.");

            //Volání metody
            Console.WriteLine(CelaCisla(cisla)); //když metoda vrací hodnotu
            int pocetC = CelaCisla(cisla); //když metoda vrací hodnotu
            CelaCisla2(cisla); //když metoda NEvrací hodnotu

            int[] cela_cisla = PoleCelychCisel(cisla);
            int[] cela_cislaA = PoleCelychCisel(cislaA);

            VypisPole(cela_cisla);
            VypisPole(cela_cislaA);
        }

        static void VypisPole(int[] array)
        {
            foreach (int cislo in array)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();
        }

        static int[] PoleCelychCisel(double[] pole)
        {
            int[] pole_celych = new int[0];
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] % 1 == 0)
                {
                    Array.Resize(ref pole_celych, pole_celych.Length + 1);
                    pole_celych[pole_celych.Length - 1] = (int) pole[i];
                }
            }

            return pole_celych;
        }

        static void CelaCisla2(double[] numbers)
        {
            int pocet_celych = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 == 0)
                {
                    pocet_celych++;
                }
            }

            Console.WriteLine(pocet_celych);
        }

        static int CelaCisla(double[] numbers)
        {
            int pocet_celych = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 == 0)
                {
                    pocet_celych++;
                }
            }

            return pocet_celych;
        }

    }
}
