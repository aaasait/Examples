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

namespace wpfapp01
{
    /// <summary>
    /// Interaction logic for RepeatButtonWin.xaml
    /// </summary>
    public partial class RepeatButtonWin : Window
    {
        public RepeatButtonWin()
        {
            InitializeComponent();

            rpt.Click += Rpt_Click;
        }

        private void Rpt_Click(object sender, RoutedEventArgs e)
        {
            lst.Items.Add("Tıklama tekrarı!");
        }
    }
}
