namespace Proc_Obraceny_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Ahoj, jak se máš?";
            string obraceny_text = "";

            for (int i = text.Length-1; i >= 0; i--)
            {
                obraceny_text += text[i];
            }

            Console.WriteLine(obraceny_text);
        }
    }
}
