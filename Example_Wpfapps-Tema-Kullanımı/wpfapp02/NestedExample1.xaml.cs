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

namespace wpfapp02
{
    /// <summary>
    /// Interaction logic for NestedExample1.xaml
    /// </summary>
    public partial class NestedExample1 : Window
    {
        public NestedExample1()
        {
            InitializeComponent();

            this.Loaded += NestedExample1_Loaded;
        }

        private void NestedExample1_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
