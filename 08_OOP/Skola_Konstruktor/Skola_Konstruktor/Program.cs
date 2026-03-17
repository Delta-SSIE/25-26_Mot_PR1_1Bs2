namespace Skola_Konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvoření objektu z třídy Student
            Student s01 = new Student("Pepík", 15);
            Console.WriteLine(s01.Introduction());
            Student s02 = new Student("Jenda", 24);
            Console.WriteLine(s02.Introduction());
            Student s03 = new Student("Tereza", 10);
            Console.WriteLine(s03.Introduction());
        }
    }
}
