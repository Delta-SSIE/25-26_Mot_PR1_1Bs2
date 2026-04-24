namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> skola = new List<Student>();
            for (int i = 0; i < 1000; i++)
            {
                skola.Add(new Student());
            }
            skola[50].Introduction();
            // aby uzivatel zadal vek a vypsalo to jenom studenty v tom veku
            Console.WriteLine("zadej vek 14-19");
            int vek = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 1000; i++)
            {
                if (skola[i].Age == vek)
                {
                    skola[i].Introduction();
                }
            }
            // nasimulujeme si konec roku neboli vsichni ctvrtaci smazeme a ostatni tridy povysime o jedna
            Console.WriteLine("---------------------------------");
            VypisTridy(skola, Grade.A4);

            for (int i = 0; i < skola.Count; i++)
            {
                switch (skola[i].Grade)
                {
                    case Grade.A1:
                        skola[i].Grade = Grade.A2;
                        break;
                    case Grade.B1:
                        skola[i].Grade = Grade.B2;
                        break;
                    case Grade.A2:
                        skola[i].Grade = Grade.A3;
                        break;
                    case Grade.B2:
                        skola[i].Grade = Grade.B3;
                        break;
                    case Grade.A3:
                        skola[i].Grade = Grade.A4;
                        break;
                    case Grade.B3:
                        skola[i].Grade = Grade.B4;
                        break;
                    case Grade.A4:
                        skola.Remove(skola[i]);
                        i--;
                        break;
                    case Grade.B4:
                        skola.Remove(skola[i]);
                        i--;
                        break;

                }
            }
            Console.WriteLine("---------------------------------");
            VypisTridy(skola, Grade.A4);
            Console.WriteLine(skola.Count);

            //nabor prvaku do kapacity 1000
            int x = skola.Count;
            for (int i = 0; i < 1000 - x; i++)
            {
                Random rnd = new Random();
                if (rnd.Next(0,1) == 0)
                {
                    skola.Add(new Student(0));
                }
                else
                {
                    skola.Add(new Student(4));
                }
                
            }
            Console.WriteLine("---------------------------------");
            VypisTridy(skola, Grade.A1);
        }
        static void VypisTridy(List<Student> studenti, Grade grade)
        {
            for (int i = 0; i < studenti.Count; i++)
            {
                if (studenti[i].Grade == grade)
                {
                    studenti[i].Introduction();
                }
            }

        }

    }
}
