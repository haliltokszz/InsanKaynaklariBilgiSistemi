using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class Kisi
    {
        private long tcNo;

        public long TcKimlikNo
        {
            get { return tcNo; }
            set { tcNo = value; }
        }

        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public List<string> YabanciDil = new List<string>();
        public CV cV = new CV();
        
    }

    
}
