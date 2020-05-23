using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariProje
{
    public partial class AnaEkran : Form
    {
        public static HashChain hashIlan = new HashChain();
        public static İkiliAramaAgaci ikili = new İkiliAramaAgaci();
        public static List<Sirket> sirketler = new List<Sirket>();
        Kisi kisi1 = new Kisi();
        Kisi kisi2 = new Kisi();
        İlan ilan1 = new İlan();
        İlan ilan2 = new İlan();
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnIsyeriForm_Click(object sender, EventArgs e)
        {
            IsyeriEkran isyeriEkran = new IsyeriEkran();
            isyeriEkran.Show();
        }

        private void btnKisiForm_Click(object sender, EventArgs e)
        {
            ElemanEkran elemanEkran = new ElemanEkran();
            elemanEkran.Show();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            
            kisi1.Ad = "Halil";
            kisi1.SoyAd = "Toksöz";
            kisi1.TcKimlikNo = 11111111111;
            kisi1.Telefon = "5555555555";
            kisi1.YabanciDil.Add("İngilizce");
            kisi1.DogumTarihi = new DateTime(2000, 08, 17);
            kisi1.DogumYeri = "İzmir";

            kisi1.cV.isyeriAd = "Google";
            kisi1.cV.isyeriPozisyon = "Görüntü İşleme Departmanı";
            kisi1.cV.calisilanYil = 2;
            kisi1.cV.okulAd = "İzmir Bakırçay Üniversitesi";
            kisi1.cV.okulBolum = "Bilgisayar Mühendisliği";
            kisi1.cV.notOrt = 3.2;
            kisi1.cV.Ekle(kisi1.cV);

            ikili.Ekle(kisi1);

            
            kisi2.Ad = "Mustafa";
            kisi2.SoyAd = "Tatarhan";
            kisi2.TcKimlikNo = 11111111112;
            kisi2.Telefon = "5555555556";
            kisi2.YabanciDil.Add("İngilizce");
            kisi2.YabanciDil.Add("Almanca");
            kisi2.DogumTarihi= new DateTime(1997, 02, 13);
            kisi2.DogumYeri = "Sakarya";

            kisi2.cV.isyeriAd = "Microsoft";
            kisi2.cV.isyeriPozisyon = "Windows Yazılım Departmanı";
            kisi2.cV.calisilanYil = 1;
            kisi2.cV.okulAd = "İzmir Bakırçay Üniversitesi";
            kisi2.cV.okulBolum = "Bilgisayar Mühendisliği";
            kisi2.cV.notOrt = 3.2;
            kisi2.cV.Ekle(kisi2.cV);

            ikili.Ekle(kisi2);

            Sirket sirket1 = new Sirket();
            sirket1.Ad = "Microsoft";
            sirket1.Telefon = "1111111111";
            sirket1.Adres = "Silikon Vadisi";
            sirket1.Eposta = "microsoft@outlook.com";
            sirketler.Add(sirket1);

            Sirket sirket2 = new Sirket();
            sirket2.Ad = "Google";
            sirket2.Telefon = "2222222222";
            sirket2.Adres = "Silikon Vadisi";
            sirket2.Eposta = "google@gmail.com";
            sirketler.Add(sirket2);

            ilan1.no = 1;
            ilan1.pozisyon = "Windows Yazılım Departmanı";
            ilan1.yabanciDil.Add("İngilizce");
            ilan1.yabanciDil.Add("Almanca");
            ilan1.sirket = sirket1;
            hashIlan.AddIlan(ilan1.no, ilan1);

            
            ilan2.no = 2;
            ilan2.pozisyon = "Görüntü İşleme Departmanı";
            ilan2.yabanciDil.Add("İngilizce");
            ilan2.sirket = sirket2;
            hashIlan.AddIlan(ilan2.no, ilan2);
        }
    }
}
