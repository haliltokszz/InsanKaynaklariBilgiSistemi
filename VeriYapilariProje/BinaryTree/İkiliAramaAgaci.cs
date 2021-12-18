using System.Collections.Generic;
using VeriYapilariProje.Entities;

namespace VeriYapilariProje.BinaryTree
{
    public class İkiliAramaAgaci
    {
        private İkiliAramaAgacDugumu kok;
        private List<İkiliAramaAgacDugumu> dugumler = new List<İkiliAramaAgacDugumu>();
        public İkiliAramaAgaci()
        {         
        }
        public İkiliAramaAgaci(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi (İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;

        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;

        }
        public List<İkiliAramaAgacDugumu> DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumler.Clear();
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler.Clear();
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAramaAgacDugumu dugum)
        {
            dugumler.Add(dugum);
        }
        public void PostOrder()
        {
            dugumler.Clear();
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public void Ekle(Kisi deger)
        {
            //Yeni eklenecek düğümün parent'ı
            İkiliAramaAgacDugumu tempParent = new İkiliAramaAgacDugumu();
            //Kökten başla ve ilerle
            İkiliAramaAgacDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (deger.TcKimlikNo == tempSearch.veri.TcKimlikNo)
                    return;
                else if (deger.TcKimlikNo < tempSearch.veri.TcKimlikNo)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(deger);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;
            else if (deger.TcKimlikNo < tempParent.veri.TcKimlikNo)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        }
        public İkiliAramaAgacDugumu Ara(long anahtar)
        {
            return AraInt(kok, anahtar);
        }
        private İkiliAramaAgacDugumu AraInt(İkiliAramaAgacDugumu dugum, long anahtar)
        {
            if (dugum.veri == null || dugum == null)
                return null;
            else if (dugum.veri.TcKimlikNo == anahtar)
                return dugum;
            else if (dugum.veri.TcKimlikNo > anahtar)
                return (AraInt(dugum.sol, anahtar));
            else
                return (AraInt(dugum.sag, anahtar));
        }
        
        public İkiliAramaAgacDugumu MinDeger()
        {
            İkiliAramaAgacDugumu tempSol = kok;
            while (tempSol.sol != null)
                tempSol = tempSol.sol;
            return tempSol;
        }

        public İkiliAramaAgacDugumu MinDegerArama(İkiliAramaAgacDugumu dugum)
        {
            while (dugum.sol != null)
                dugum = dugum.sol;
            return dugum;
        }

        public İkiliAramaAgacDugumu MaksDeger()
        {
            İkiliAramaAgacDugumu tempSag = kok;
            while (tempSag.sag != null)
                tempSag = tempSag.sag;
            return tempSag;
        }
        
        private İkiliAramaAgacDugumu Successor(İkiliAramaAgacDugumu silDugum)
        {
            İkiliAramaAgacDugumu temp= MinDegerArama(silDugum);
            return temp;
        }
        
        public bool Sil(Kisi deger)
        {
            İkiliAramaAgacDugumu current = kok;
            İkiliAramaAgacDugumu parent = kok;
            bool issol = true;
            //DÜĞÜMÜ BUL
            while (current.veri.TcKimlikNo != deger.TcKimlikNo)
            {
                parent = current;
                if (deger.TcKimlikNo < current.veri.TcKimlikNo)
                {
                    issol = true;
                    current = current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sag;
                }
                if (current == null)
                    return false;
            }
            //DURUM 1: YAPRAK DÜĞÜM
            if (current.sol == null && current.sag == null)
            {
                current.veri = null;
                if (issol == true)
                {
                    parent.sol = null;
                }
                else
                {
                    parent.sag = null;
                }
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sag == null)
            {
                if (issol == true)
                {
                    parent.sol = current.sol;
                }
                else
                {
                    parent.sag = current.sol;
                }
                current.sol = null;
            }
            else if (current.sol == null)
            {
                if (issol == true)
                {
                    parent.sol = current.sag;
                }
                else
                {
                    parent.sag = current.sag;
                }
                current.sag = null;
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                İkiliAramaAgacDugumu successor = Successor(current.sag);
                if (issol == true)
                {
                    if (current.veri.TcKimlikNo == kok.veri.TcKimlikNo)
                    {
                        parent.veri = successor.veri;
                        successor.veri = null;
                        this.kok = parent;
                    }
                    else
                    {
                        parent.sol = successor;
                        successor.sol = current.sol;
                    }
                    
                }
                else
                {
                    if (current.sol != null)
                    {
                        successor = Successor(current);
                        parent.sag = successor;
                    }
                    
                    successor.sag = current.sag;
                }
            }
            current = null;
            return true;
        } 

    }
}
