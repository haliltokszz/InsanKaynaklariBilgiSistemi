using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriYapilariProje.Entities;

namespace VeriYapilariProje
{
    
    public partial class ElemanEkran : Form
    {

        Kisi aranan;
        public Kisi KisiArama(long tc)
        {
            Kisi arananKisi = new Kisi(); ;
            
            if (AnaEkran.ikili.Ara(tc) == null)
            {
                MessageBox.Show("Kişi Bulunamadı");
                return null;
            }
            else
            {
                arananKisi = AnaEkran.ikili.Ara(tc).veri;
                txtKisiAd.Text = arananKisi.Ad;
                txtKisiSoyad.Text = arananKisi.SoyAd;
                txtKisiTC.Text = arananKisi.TcKimlikNo.ToString();
                txtKisiTel.Text = arananKisi.Telefon.ToString();
                txtKisiEposta.Text = arananKisi.Eposta;
                txtKisiDy.Text = arananKisi.DogumYeri;
                txtKisiDg.Value = arananKisi.DogumTarihi;
                string yabanciDiller = "";
                foreach (string dil in arananKisi.YabanciDil)
                {
                    yabanciDiller += dil;
                }
                txtKisiYabanciDil.Text = yabanciDiller;
                txtKisiAdres.Text = arananKisi.Adres;
            }

            return arananKisi;
        }
        public ElemanEkran()
        {
            InitializeComponent();

            lstIsIlan.View = View.Details;
            lstIsIlan.FullRowSelect = true;
            lstIsIlan.GridLines = true;
            lstIsIlan.Columns.Add("No", 30);
            lstIsIlan.Columns.Add("Ad", 80);
            lstIsIlan.Columns.Add("Pozisyon", 120);
            lstIsIlan.Columns.Add("Yabancı Dil", 150);
            lstIsIlan.Columns.Add("Tanım", 100);
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi();
            kisi.Ad = txtKisiAd.Text;
            kisi.Adres = txtKisiAdres.Text;
            kisi.DogumTarihi = txtKisiDg.Value;
            kisi.DogumYeri = txtKisiDy.Text;
            kisi.SoyAd = txtKisiSoyad.Text;
            kisi.TcKimlikNo = long.Parse(txtKisiTC.Text);
            kisi.Telefon = txtKisiTel.Text;
            kisi.Eposta = txtKisiEposta.Text;
            string[] yabanciDil = txtKisiYabanciDil.Text.Split(' ');
            kisi.YabanciDil = yabanciDil.ToList();
            AnaEkran.ikili.Ekle(kisi);

        }

        private void btnCVekle_Click(object sender, EventArgs e)
        {
            if (AnaEkran.ikili.Ara(Convert.ToInt64(txtCVKisiArama.Text)) == null)
            {
                MessageBox.Show("Kişi Bulunamadı");
            }
            else
            {
                aranan = AnaEkran.ikili.Ara(Convert.ToInt64(txtCVKisiArama.Text)).veri;
                aranan.cV.baslangicYili =Convert.ToInt32(txtCVOkulBaslangicYili.Text);
                aranan.cV.bitisYili = Convert.ToInt32(txtCVOkulBitisYili.Text);
                aranan.cV.calisilanYil = Convert.ToInt32(txtCVIsyeriCalismaYili.Text);
                aranan.cV.isyeriAd = txtCVIsyeriAd.Text;
                aranan.cV.isyeriAdres = txtCVIsyeriAdres.Text;
                aranan.cV.notOrt = Convert.ToDouble(txtCVOkulNotOrtalama.Text);
                aranan.cV.okulAd = txtCVOkulAd.Text;
                aranan.cV.okulBolum = txtCVOkulBolum.Text;
                aranan.cV.isyeriPozisyon = txtCVIsyeriPozisyon.Text;
                aranan.cV.Ekle(aranan.cV);
            }
                
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            if (aranan != null)
            {
                Kisi guncellenecekKisi = aranan;

                guncellenecekKisi.Ad = txtKisiAd.Text;
                guncellenecekKisi.Adres = txtKisiAdres.Text;
                guncellenecekKisi.DogumTarihi = txtKisiDg.Value;
                guncellenecekKisi.DogumYeri = txtKisiDy.Text;
                guncellenecekKisi.SoyAd = txtKisiSoyad.Text;
                guncellenecekKisi.TcKimlikNo = long.Parse(txtKisiTC.Text);
                guncellenecekKisi.Telefon = txtKisiTel.Text;
                guncellenecekKisi.Eposta = txtKisiEposta.Text;
                string[] yabanciDil = txtKisiYabanciDil.Text.Split(' ');
                guncellenecekKisi.YabanciDil = yabanciDil.ToList();

                MessageBox.Show(guncellenecekKisi.Ad + guncellenecekKisi.SoyAd + " güncelleme başarılı");
            }
            else
                MessageBox.Show("Güncellemek istediğiniz kişi bulunamadı.");
                
        }

        private void btnKisiAra_Click(object sender, EventArgs e)
        {
            aranan = KisiArama(Convert.ToInt64(txtKisiArama.Text));
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            if (aranan != null)
            {
                Kisi silinecekKisi = aranan;
                AnaEkran.ikili.Sil(silinecekKisi);
            }
            else
                MessageBox.Show("Silmek istediğiniz kişi bulunamadı.");
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        public void Temizle()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                    c.Text = "";
            }
        }

        private void btnBasvur_Click(object sender, EventArgs e)
        {
            
            İlan ilan;
            Kisi basvuranKisi = AnaEkran.ikili.Ara(Convert.ToInt64(txtIlanKisiArama.Text)).veri;
            if (basvuranKisi != null)
            {
                foreach (ListViewItem satir in lstIsIlan.SelectedItems)
                {
                    ilan = AnaEkran.hashIlan.GetIlan(Convert.ToInt32(satir.SubItems[0].Text));
                    if (ilan.heap.Insert(basvuranKisi) == false)
                        MessageBox.Show("Bu ilana daha önceden başvuru yapmışsınız.");
                    else
                    {
                        ilan.heap.Insert(basvuranKisi);
                        MessageBox.Show(basvuranKisi.Ad + " " + basvuranKisi.SoyAd + " kişisinin "+ilan.sirket.Ad +" şirketine başvurusu onaylanmıştır.");
                    }
                        
                }
            }
            else
                MessageBox.Show("Başvuracak kişi bulunamadı");
            

        }

        private void rdbtnIsyeriAd_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnIsyeriAd.Checked)
            {
                lblIsyeriAd.Visible = true;
                txtIlanIsyeriAd.Visible = true;
            }
            else
            {
                lblIsyeriAd.Visible = false;
                txtIlanIsyeriAd.Visible = false;
            }
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstIsIlan.Items.Clear();
            if(AnaEkran.ikili.Ara(Convert.ToInt64(txtIlanKisiArama.Text)) != null)
            {
                Kisi basvuranKisi = AnaEkran.ikili.Ara(Convert.ToInt64(txtIlanKisiArama.Text)).veri;
                if (rdbtnPozisyon.Checked == true)
                {
                    foreach(İlan ilan in AnaEkran.hashIlan.GetAll())
                    {
                        if(basvuranKisi.cV.PozisyonArama(ilan.pozisyon)==true)
                        {
                            lstIsIlan.View = View.Details;
                            lstIsIlan.FullRowSelect = true;
                            string yabanciDil = "";
                            foreach (string dil in ilan.yabanciDil)
                            {
                                yabanciDil += dil + " ";
                            }
                            string[] bilgiler = { ilan.no.ToString(), ilan.sirket.Ad, ilan.pozisyon, yabanciDil, ilan.tanim };
                            lstIsIlan.Items.Add(new ListViewItem(bilgiler));
                        }
                    }
                }
                else if (rdbtnIsyeriAd.Checked == true)
                {
                    if (txtIlanIsyeriAd.Text != null)
                    {
                        foreach (İlan ilan in AnaEkran.hashIlan.GetAll())
                        {
                            if (ilan.sirket.Ad == txtIlanIsyeriAd.Text)
                            {
                                lstIsIlan.View = View.Details;
                                lstIsIlan.FullRowSelect = true;
                                string yabanciDil = "";
                                foreach (string dil in ilan.yabanciDil)
                                {
                                    yabanciDil += dil + " ";
                                }
                                string[] bilgiler = {ilan.no.ToString(), ilan.sirket.Ad, ilan.pozisyon, yabanciDil, ilan.tanim };
                                lstIsIlan.Items.Add(new ListViewItem(bilgiler));
                            }
                        }
                    }
                }
            }
        }

        private void btnCVTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                    c.Text = "";
            }
        }
    }
}
