using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapouzdreni
{
    internal class Predmet
    {
        //Soukromá vlastnost - nelze nastavit mimo třídu
        private int price;
        private double weight;
        private double wood; //z kolika procent je ta skřín dřevěnná, budeme ukládat tedy 0–100%

        //Veřejná položka – short-hand (zkrácený zápis)
        public string Name { get; set; } //soukromá položka není vidět, ale dodržuje se princip zapouzdření
        public int ID { get; private set; }
        //nastavit hodnotu mohu pouze ve třídě, ale zobrazit mohu kdekoliv

        //Konstruktor
        public Predmet()
        {
            this.ID = 100;
        }

        //Veřejnou položka pro nastavení hodnoty soukromé vlastnosti
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value; //value je hodnota, kterou se zadává při přepisu Price
                //V Mainu to může vypadat: objekt.Price = 4 (value je pak 4)
            }
        }

        //Veřejná položka s podmínkou v setteru
        public double Weight
        {
            get
            {
                return weight;
            }
            //Aby se nestalo, že se uloží nesmyslná váha, tak má setter podmínku
            //Váha musí být kladná (neboli 0+)
            set
            {
                if(value >= 0)
                {
                    weight = value;
                }
            }
        }

        //Veřejná položka
        public double Wood
        {
            get
            {
                return wood;
            }
            set
            {
                //hodnoty v rozmezí 0–100, pokud přestřelí uloží se nejvyšší, nebo nejnižší možná
                if(value < 0)
                {
                    wood = 0;
                } else if(value > 100)
                {
                    wood = 100;
                } else
                {
                    wood = value;
                }
            }
        }
        
        /* Nastavení soukromé položky podle samostatně vytvořených metod
        public int GetPrice()
        {
            return price;
        }
        public void SetPrice(int newPrice)
        {
            this.price = newPrice;
        }
        */
    }
}
