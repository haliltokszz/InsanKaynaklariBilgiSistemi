using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class İlan
    {
        public int no;
        public string tanim;
        public string pozisyon;
        public List<string> yabanciDil = new List<string>();
        public Sirket sirket;
        public Heap heap;
        public İlan()
        {
            heap = new Heap();
            sirket = new Sirket();
        }

    }
}
