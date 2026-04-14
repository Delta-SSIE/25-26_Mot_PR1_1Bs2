using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani_test_Ukoly
{
    internal class Task
    {
        public int ID { get; set; }
        public KategoriePrace PozadovanaOdbornost { get; set; }
        private double pocetHodin;
        public double PocetHodin
        {
            get
            {
                return (pocetHodin);
            }
            set
            {
                if (value <= 0)
                {
                    pocetHodin = 1;
                }
                else
                {
                    pocetHodin = value;
                }
            }
        }
        private double rozpocetZakazky;
        public double RozpocetZakazky
        {
            get
            {
                return rozpocetZakazky;
            }
            set
            {
                if (value < 0)
                {
                    rozpocetZakazky = 0;
                }
                else
                {
                    rozpocetZakazky = value;
                }
            }
        }

        public Task(int id, KategoriePrace odbornost, double pocetHodin, double rozpocetZakazky)
        {
            this.ID = id;
            this.PozadovanaOdbornost = odbornost;
            this.PocetHodin = pocetHodin;
            this.RozpocetZakazky = rozpocetZakazky;
        }


    }
}
