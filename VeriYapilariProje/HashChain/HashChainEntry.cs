namespace VeriYapilariProje.HashChain
{
    public class HashChainEntry
    {
        private int anahtar;

        private object deger;

        private HashChainEntry next;

        public object Deger
        {
            get { return deger; }
            set { deger = value; }
        }
        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }


        public HashChainEntry Next
        {
            get { return next; }
            set { next = value; }
        }


        public HashChainEntry(int anahtar, object deger)
        {
            this.anahtar = anahtar;
            this.deger = deger;
            this.next = null;
        }

    }
}
