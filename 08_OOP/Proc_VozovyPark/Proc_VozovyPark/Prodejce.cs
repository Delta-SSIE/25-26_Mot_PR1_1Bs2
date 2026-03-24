using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc_VozovyPark
{
    internal class Prodejce
    {
        public string Jmeno { get; set; }
        public int[] IndexyAut { get; set; }

        public Prodejce(string jmeno)
        {
            this.Jmeno = jmeno;
            this.IndexyAut = new int[0];
        }

        public void VypisAuta(Vozidlo[] auta)
        {
            for (int i = 0; i < auta.Length; i++)
            {
                for (int j = 0; j < IndexyAut.Length; j++)
                {
                    if (IndexyAut[j] == i)
                    {
                        auta[i].VypisInfo();
                    }
                }
            }
        }
    }
}
