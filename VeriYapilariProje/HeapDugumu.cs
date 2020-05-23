using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class HeapDugumu
    {
        public Kisi kisi;
        private double deger;

        public double Deger
        {
            get { return deger; }
        }

        public HeapDugumu(Kisi kisi)
        {
            this.kisi = kisi;
            Random rastgele = new Random();
            deger = rastgele.NextDouble() * 10;
        }
    }
}
