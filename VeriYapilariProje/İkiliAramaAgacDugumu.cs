using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class İkiliAramaAgacDugumu
    {
        public Kisi veri;
        public CV cV;
        public İkiliAramaAgacDugumu sol;
        public İkiliAramaAgacDugumu sag;
        public İkiliAramaAgacDugumu()
        {
        }

        public İkiliAramaAgacDugumu(Kisi veri)
        {
            this.veri = veri;
            sol = null;
            sag = null;
            cV = veri.cV;

        }
    }
}
