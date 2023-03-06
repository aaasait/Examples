using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfProject4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ad = "", soyad = "", kullaniciAd = "", email = "", sifre = "", acikAdres = "";
        bool aktif = false, sozlesme = false;
        Ulke ulke = null;
        Sehirler sehir = null;
        public MainWindow()
        {
            InitializeComponent();

            btnKaydet.Click += BtnKaydet_Click;
            this.Loaded += MainWindow_Loaded;


        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            cmbUlkeler.ItemsSource = UlkelerGetir();
            cmbUlkeler.DisplayMemberPath = "UlkeAd";
            cmbUlkeler.SelectedValuePath = "UlkeId";

            cmbSehirler.ItemsSource = SehirlerGetir();
            cmbSehirler.DisplayMemberPath = "SehirAd";
            cmbSehirler.SelectedValuePath = "SehirID";

        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {

            GetDataFromUser();
           
            Adres adres=new Adres();
            adres.Ulke= ulke;
            adres.Sehir= sehir;
            adres.AcikAdres= acikAdres;

            Kullanici kullanici= new Kullanici();
            kullanici.Ad = ad;
            kullanici.Soyad= soyad;
            kullanici.Email= email;
            kullanici.Sifre= sifre;
            kullanici.KullaniciAd = kullaniciAd;
            kullanici.Adres = adres;
            kullanici.Aktif= aktif;
            kullanici.SozlesmeOnay = sozlesme;

            if (kullanici.Adres != null)
            {
                if (kullanici.Adres.Sehir!=null)
                {
                    MessageBox.Show(kullanici.Adres.Sehir.SehirAd);
                }
            }
        }

        public void GetDataFromUser()
        {
             ad = txtAd.Text;
             soyad=txtSoyad.Text;
             kullaniciAd=txtKullaniciAd.Text;
             email=txtEmail.Text;
             sifre=txtSifre.Password; // passwordBox
             aktif= (bool)chckAktif.IsChecked ? true:false;
             sozlesme = (bool)chckSozlesme.IsChecked ? true : false;

            // adres bilgilerini al
            ulke = null;
            sehir= null;
            if(cmbUlkeler.SelectedItem!= null)
            {
                ulke = (Ulke)cmbUlkeler.SelectedItem;
            }
            if (cmbSehirler.SelectedItem != null)
            {
                sehir = (Sehirler)cmbSehirler.SelectedItem;
            }

             acikAdres=txtAcikAdres.Text;
        }

        List<Ulke> UlkelerGetir()
        {
            List<Ulke> ulkeler = new List<Ulke>();
            ulkeler.Add(new Ulke(1, "Türkiye"));
            ulkeler.Add(new Ulke(2, "Azerbeycan"));
            ulkeler.Add(new Ulke(3, "Türkmenistan"));
            return ulkeler;
        }
        List<Sehirler> SehirlerGetir()
        {
            List<Sehirler> sehirler = new List<Sehirler>();
            sehirler.Add(new Sehirler(1, "Istanbul"));
            sehirler.Add(new Sehirler(2, "Ankara"));
            sehirler.Add(new Sehirler(3, "Antalya"));
            return sehirler;

        }

    }
}
