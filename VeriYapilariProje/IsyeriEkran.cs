using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VeriYapilariProje.BinaryTree;
using VeriYapilariProje.Entities;

namespace VeriYapilariProje
{
    public partial class IsyeriEkran : Form
    {
        Sirket arananSirket;
        İlan arananİlan;
        İlan listelenecekIlan;
        public IsyeriEkran()
        {
            InitializeComponent();
            lstElemanAday.View = View.Details;
            lstElemanAday.FullRowSelect = true;
            lstElemanAday.GridLines = true;
            lstElemanAday.Columns.Add("TC", 100);
            lstElemanAday.Columns.Add("Uygunluk Puanı", 80);
            lstElemanAday.Columns.Add("Ad", 80);
            lstElemanAday.Columns.Add("Soyad", 80);
            lstElemanAday.Columns.Add("Pozisyon", 120);
            lstElemanAday.Columns.Add("Deneyim", 80);
            lstElemanAday.Columns.Add("Yabancı Dil", 150);

            lstKullanicilar.View = View.Details;
            lstKullanicilar.FullRowSelect = true;
            lstKullanicilar.GridLines = true;
            lstKullanicilar.Columns.Add("Düzey", 50);
            lstKullanicilar.Columns.Add("TC", 120);
            lstKullanicilar.Columns.Add("Ad", 80);
            lstKullanicilar.Columns.Add("Soyad", 80);
            lstKullanicilar.Columns.Add("Pozisyon", 150);
            lstKullanicilar.Columns.Add("Deneyim", 80);
        }

        public Sirket SirketArama(string ad)
        {
            Sirket arananIsyeri = new Sirket();
            bool varMi = false;

            foreach(Sirket sirket in AnaEkran.sirketler)
            {
                if (sirket.Ad == ad)
                {
                    arananIsyeri = sirket;
                    varMi = true;
                }
                    
            }
            if (varMi == false)
            {
                MessageBox.Show("Şirket Bulunamadı");
                return null;
            }
            else
            {
                txtIsyeriAd.Text = arananIsyeri.Ad;
                txtIsyeriAdres.Text = arananIsyeri.Adres;
                txtIsyeriEposta.Text = arananIsyeri.Eposta;
                txtIsyeriTel.Text = arananIsyeri.Telefon;
                txtIsyeriFaks.Text = arananIsyeri.Faks;

            }
            return arananIsyeri;
        }

        public İlan IlanArama(int no)
        {
            İlan tempIlan = new İlan();

            tempIlan = AnaEkran.hashIlan.GetIlan(no);

            if (tempIlan == null)
            {
                MessageBox.Show("İlan Bulunamadı");
                return null;
            }
            else
            {
                txtIlanNo.Text = tempIlan.no.ToString();
                txtIlanPozisyon.Text = tempIlan.pozisyon;
                txtIlanIsyeriAd.Text = tempIlan.sirket.Ad;
                txtIlanTanim.Text= tempIlan.tanim;
                string yabanciDil = "";
                foreach(string dil in tempIlan.yabanciDil)
                {
                    yabanciDil += dil + " ";
                }
                txtIlanYabanciDil.Text = yabanciDil;

            }
            return tempIlan;
        }
        private void btnIsyeriEkle_Click(object sender, EventArgs e)
        {
            Sirket sirket = new Sirket();
            sirket.Ad = txtIsyeriAd.Text;
            sirket.Telefon = txtIsyeriTel.Text;
            sirket.Faks = txtIsyeriFaks.Text;
            sirket.Eposta = txtIsyeriEposta.Text;
            sirket.Adres = txtIsyeriAdres.Text;

            AnaEkran.sirketler.Add(sirket);
        }

        private void btnIsyeriAra_Click(object sender, EventArgs e)
        {
            arananSirket = SirketArama(txtIsyeriArama.Text);
        }

        private void btnIsyeriGuncelle_Click(object sender, EventArgs e)
        {
            if (arananSirket != null)
            {
                Sirket guncellenecekSirket = arananSirket;

                guncellenecekSirket.Ad = txtIsyeriAd.Text;
                guncellenecekSirket.Adres = txtIsyeriAdres.Text;
                guncellenecekSirket.Eposta = txtIsyeriEposta.Text;
                guncellenecekSirket.Faks = txtIsyeriFaks.Text;
                guncellenecekSirket.Telefon = txtIsyeriTel.Text;

                MessageBox.Show(guncellenecekSirket.Ad + " " + guncellenecekSirket.Telefon);
            }
            else
                MessageBox.Show("Güncellemek istediğiniz şirketi bulamadık");
        }

        private void btnIsyeriSil_Click(object sender, EventArgs e)
        {
            if (arananSirket != null)
            {
                Sirket silinecekSirket = arananSirket;
                AnaEkran.sirketler.Remove(silinecekSirket);
            }
            else
                MessageBox.Show("Silmek istediğiniz şirketi bulamadık");
        }

        private void btnIlanAra_Click(object sender, EventArgs e)
        {
            arananİlan=IlanArama(Convert.ToInt32(txtIlanArama.Text));
        }

        private void btnIlanEkle_Click(object sender, EventArgs e)
        {
            Sirket ilanIsyeri = SirketArama(txtIlanIsyeriAd.Text);
            if (ilanIsyeri == null)
                MessageBox.Show("İşyeri bulunamadı");
            else
            {
                İlan ilan = new İlan();
                ilan.no = Convert.ToInt32(txtIlanNo.Text);
                ilan.pozisyon = txtIlanPozisyon.Text;
                ilan.sirket = ilanIsyeri;
                ilan.tanim = txtIlanTanim.Text;
                string[] yabanciDil = txtIlanYabanciDil.Text.Split(' ');
                ilan.yabanciDil = yabanciDil.ToList();
                AnaEkran.hashIlan.AddIlan(ilan.no, ilan);
            }
        }

        private void btnIlanSil_Click(object sender, EventArgs e)
        {
            İlan silinenIlan = AnaEkran.hashIlan.RemoveIlan(Convert.ToInt32(txtIlanArama.Text));
            if (silinenIlan == null)
                MessageBox.Show("İlan bulunamadı");
            else
            {
                MessageBox.Show(silinenIlan.sirket.Ad + " şirketi tarafından oluşturulan " + silinenIlan.no + " numaralı ilan silindi");
            }
        }

        private void btnIlanTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                    c.Text = "";
            }
        }

        private void btnIsyeriTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                    c.Text = "";
            }
        }

        private void btnIlanGuncelle_Click(object sender, EventArgs e)
        {
            if (arananİlan != null)
            {
                MessageBox.Show("İlan numarası ve şirketi güncellenemez");
                arananİlan.pozisyon = txtIlanPozisyon.Text;
                arananİlan.tanim = txtIlanTanim.Text;
                string[] yabanciDil = txtIlanYabanciDil.Text.Split(' ');
                arananİlan.yabanciDil = yabanciDil.ToList();
            }
            else
                MessageBox.Show("Güncellemek istediğiniz ilan bulunamadı");
        }

        private void btnAdayListele_Click(object sender, EventArgs e)
        {
            lstElemanAday.Items.Clear();
            if (txtAdayIlanNo != null)
            {
                listelenecekIlan = AnaEkran.hashIlan.GetIlan(Convert.ToInt32(txtAdayIlanNo.Text));
                List<Kisi> listelenecekAdaylar = listelenecekIlan.heap.AdaylariListele();
                bool listelenecekMi = false;
                foreach (Kisi kisi in listelenecekAdaylar)
                {
                    listelenecekMi = false;
                    if (chckDeneyim.Checked == false && chckYabanciDil.Checked == false)
                    {
                        listelenecekMi = true;

                    }
                    else if (chckDeneyim.Checked == true && chckYabanciDil.Checked==false)
                    {
                        if (kisi.cV.Deneyim >= 2)
                        {
                            listelenecekMi = true;
                        }
                    }
                    else if (chckYabanciDil.Checked == true && chckDeneyim.Checked == false)
                    {
                        int sayac = 0;
                        foreach (string istenenDil in listelenecekIlan.yabanciDil)
                        {
                            foreach (string bilinenDil in kisi.YabanciDil)
                            {
                                if (istenenDil == bilinenDil)
                                {
                                    sayac++;
                                }
                            }
                        }
                        if (sayac == listelenecekIlan.yabanciDil.Count)
                            listelenecekMi = true;
                    }else if(chckDeneyim.Checked==true && chckYabanciDil.Checked == true)
                    {
                        int sayac = 0;
                        foreach (string istenenDil in listelenecekIlan.yabanciDil)
                        {
                            foreach (string bilinenDil in kisi.YabanciDil)
                            {
                                if (istenenDil == bilinenDil)
                                {
                                    sayac++;
                                }
                            }
                        }
                        if (sayac == listelenecekIlan.yabanciDil.Count && kisi.cV.Deneyim >= 2)
                            listelenecekMi = true;
                    }

                    if (listelenecekMi == true)
                    {
                        string yabanciDil = "";
                        foreach (string dil in kisi.YabanciDil)
                        {
                            yabanciDil += dil + " ";
                        }
                        string[] bilgiler = { kisi.TcKimlikNo.ToString(), listelenecekIlan.heap.UygunlukPuani(kisi).ToString(), kisi.Ad, kisi.SoyAd, kisi.cV.isyeriPozisyon, kisi.cV.Deneyim.ToString(), yabanciDil };
                        lstElemanAday.Items.Add(new ListViewItem(bilgiler));
                    }
                    
                }
                if(lstElemanAday.Items.Count!=0)
                    lblIseAlinacak.Text ="İşe alınacak aday: " +lstElemanAday.Items[0].SubItems[2].Text.ToString();
            }
            else
                MessageBox.Show("Lütfen ilan numarası girin");
            
        }

        private void btnIseAl_Click(object sender, EventArgs e)
        {
            Kisi iseAlinan;
            if (chckDeneyim.Checked == false && chckYabanciDil.Checked == false)
                iseAlinan = listelenecekIlan.heap.RemoveMax().kisi;
            else
            {
                iseAlinan = AnaEkran.ikili.Ara(Convert.ToInt64(lstElemanAday.Items[0].SubItems[0].Text)).veri;
            }
            MessageBox.Show(iseAlinan.Ad + " " + iseAlinan.SoyAd +" İşe Alınmıştır");
        }

        private void radioInorder_CheckedChanged(object sender, EventArgs e)
        {
            lstKullanicilar.Items.Clear();
            AnaEkran.ikili.InOrder();
            List<İkiliAramaAgacDugumu> kullanicilar = AnaEkran.ikili.DugumleriYazdir();
            for(int i =0; i<kullanicilar.Count; i++)
            {
                string[] bilgiler = { i.ToString() , kullanicilar[i].veri.TcKimlikNo.ToString(), kullanicilar[i].veri.Ad, kullanicilar[i].veri.SoyAd, kullanicilar[i].cV.isyeriPozisyon, kullanicilar[i].cV.Deneyim.ToString() };
                lstKullanicilar.Items.Add(new ListViewItem(bilgiler));
            }
            lblAgacDerinligi.Text = "Ağaç Derinliği: " + AnaEkran.ikili.YaprakSayisi().ToString();
            lblElemanSayisi.Text = "Eleman Sayısı: "+ kullanicilar.Count;
        }

        private void radioPostorder_CheckedChanged(object sender, EventArgs e)
        {
            lstKullanicilar.Items.Clear();
            AnaEkran.ikili.PostOrder();
            List<İkiliAramaAgacDugumu> kullanicilar = AnaEkran.ikili.DugumleriYazdir();
            for (int i = 0; i < kullanicilar.Count; i++)
            {
                string[] bilgiler = { i.ToString() , kullanicilar[i].veri.TcKimlikNo.ToString(), kullanicilar[i].veri.Ad, kullanicilar[i].veri.SoyAd, kullanicilar[i].cV.isyeriPozisyon, kullanicilar[i].cV.Deneyim.ToString() };
                var satir = new ListViewItem(bilgiler);
                lstKullanicilar.Items.Add(satir);
            }
            lblAgacDerinligi.Text = "Ağaç Derinliği: " + AnaEkran.ikili.YaprakSayisi().ToString();
            lblElemanSayisi.Text = "Eleman Sayısı: " + kullanicilar.Count;
        }

        private void radioPreorder_CheckedChanged(object sender, EventArgs e)
        {
            lstKullanicilar.Items.Clear();
            AnaEkran.ikili.PreOrder();
            List<İkiliAramaAgacDugumu> kullanicilar = AnaEkran.ikili.DugumleriYazdir();
            for (int i = 0; i < kullanicilar.Count; i++)
            {
                string[] bilgiler = { i.ToString(), kullanicilar[i].veri.TcKimlikNo.ToString(), kullanicilar[i].veri.Ad, kullanicilar[i].veri.SoyAd, kullanicilar[i].cV.isyeriPozisyon, kullanicilar[i].cV.Deneyim.ToString() };
                lstKullanicilar.Items.Add(new ListViewItem(bilgiler));
            }
            lblAgacDerinligi.Text = "Ağaç Derinliği: " + AnaEkran.ikili.YaprakSayisi().ToString();
            lblElemanSayisi.Text = "Eleman Sayısı: " + kullanicilar.Count;
        }
    }
}
