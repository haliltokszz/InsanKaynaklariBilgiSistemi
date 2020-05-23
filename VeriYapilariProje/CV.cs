using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class CV
    {
        private int deneyim=0;

        public string isyeriAd;
        public string isyeriAdres;
        public string isyeriPozisyon;
        public int calisilanYil;

        public string okulAd;
        public string okulBolum;
        public int baslangicYili;
        public int bitisYili;
        public double notOrt;

        public CV next;
        private CV first;
        public int Deneyim { get { return deneyim; } }
        public CV Head { get { return first; } }
        public CV()
        {
            this.next = null;
        }

        public void Ekle(CV bilgi)
        {
            if (first == null)
            {
                first = bilgi;
                deneyim += bilgi.calisilanYil;
                first.next = null;
            }
            else
            {
                CV temp = first;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = bilgi;
                deneyim += bilgi.calisilanYil;
                temp.next.next = null;
            }
        }
        
        public bool PozisyonArama(string pozisyon)
        {
            if (first == null)
                return false;
            else
            {
                CV temp = first;
                while (temp.next != null)
                {
                    if (temp.isyeriPozisyon == pozisyon)
                        return true;
                    else
                        temp = temp.next;
                }
                if (temp.isyeriPozisyon == pozisyon)
                    return true;
                return false;
            }
        }

    }
}