using System;
using VeriYapilariProje.Entities;

namespace VeriYapilariProje.Heap
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
