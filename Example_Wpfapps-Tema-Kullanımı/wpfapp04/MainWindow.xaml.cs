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

namespace wpfapp04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            List<Kullanici> Kullanicilar = new List<Kullanici>();
            Kullanicilar.Add(new Kullanici(1, "Cihan", "Özhan", "cihan.ozhan@hotmail.com", false, true, "/heyvan1.jpg"));
            Kullanicilar.Add(new Kullanici(2, "Kemalettin", "Aydoğdu", "info@kemalettin.com", true, true, "heyvan2.jpg"));
            Kullanicilar.Add(new Kullanici(3, "Murtaza", "Geceli", "murtaza@geceli.com", true, false, "heyvan3.jpg"));
            Kullanicilar.Add(new Kullanici(4, "İbrahim", "Ballıses", "ibo@ballises.com", true, true, "heyvan4.jpg"));
            Kullanicilar.Add(new Kullanici(5, "Cimşir", "Cemşid", "cimsir@cemsid.com", false, true, "heyvan5.jpg"));
            Kullanicilar.Add(new Kullanici(6, "Cemşid", "Durdu", "cemsid@durdu.com", false, true, "Koala.jpg"));

            lst.ItemsSource = Kullanicilar;
            cmb.ItemsSource = Kullanicilar;
            dg.ItemsSource = Kullanicilar;
        }
    }
}
