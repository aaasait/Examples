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
using System.Windows.Shapes;

namespace WpfProject4
{
    /// <summary>
    /// Interaction logic for ComboboxWin.xaml
    /// </summary>
    public partial class ComboboxWin : Window
    {
        public ComboboxWin()
        {
            InitializeComponent();
            this.Loaded += ComboboxWin_Loaded;
            cmbSehirler.SelectionChanged += CmbSehirler_SelectionChanged;
        }

        private void CmbSehirler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Sehirler sehir = (Sehirler)((ComboBox)sender).SelectedItem;
            MessageBox.Show(sehir.SehirAd + " " + sehir.SehirID);
        }

        private void ComboboxWin_Loaded(object sender, RoutedEventArgs e)
        {
            
                List<Sehirler> sehirler = new List<Sehirler>();
            sehirler.Add(new Sehirler(1, "Adana"));
            sehirler.Add(new Sehirler(6, "Ankara"));
            sehirler.Add(new Sehirler(26, "Erzurum"));

            cmbSehirler.ItemsSource= sehirler;
            cmbSehirler.DisplayMemberPath = "SehirAd";
            cmbSehirler.SelectedValuePath = "SehirId";
        }
    }
}
