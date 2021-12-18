using VeriYapilariProje.Entities;

namespace VeriYapilariProje.BinaryTree
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
