using System.Collections.Generic;

namespace VeriYapilariProje.Entities
{
    public class İlan
    {
        public int no;
        public string tanim;
        public string pozisyon;
        public List<string> yabanciDil = new List<string>();
        public Sirket sirket;
        public Heap.Heap heap;
        public İlan()
        {
            heap = new Heap.Heap();
            sirket = new Sirket();
        }

    }
}
