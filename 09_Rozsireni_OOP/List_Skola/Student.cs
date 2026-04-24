using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    
    public enum Grade
    {
        A1,A2,A3,A4,B1,B2,B3,B4
        
    }
    internal class Student
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public Grade Grade { get; set; }
        public void Introduction()
        {
            Console.WriteLine($"student's name is {this.Name}, age is {this.Age}, grade {this.Grade}");
        }
        
        public Student(int trida = -1)
        {
             Random rnd = new Random();
                string[] names = new string[]
            {
                "Jakub", "Jan", "Tomáš", "Matěj", "Filip", "Adam", "Petr", "Lukáš", "Vojtěch", "Šimon",
                "Eliška", "Tereza", "Adéla", "Anna", "Natálie", "Ema", "Karolína", "Viktorie", "Kristýna", "Lucie",
                "Martin", "Ondřej", "David", "Dominik", "Marek", "Daniel", "Štěpán", "Jiří", "Michal", "Patrik",
                "Barbora", "Veronika", "Nela", "Klára", "Anežka", "Julie", "Zuzana", "Sofie", "Marie", "Hana",
                "Antonín", "Kryštof", "Vít", "Mikuláš", "Tobiáš", "Matyáš", "Václav", "Jáchym", "Linda", "Elena"
            };
            this.Name = names[rnd.Next(0,names.Length)];
            this.Age = rnd.Next(14, 20);
            if(trida == -1)
            {
                this.Grade = (Grade)rnd.Next(0,8);
            }
            else
            {
                this.Grade = (Grade)trida;
            }
           


        }


    }
}
