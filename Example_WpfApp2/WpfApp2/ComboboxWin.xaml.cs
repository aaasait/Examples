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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for ComboboxWin.xaml
    /// </summary>
    public partial class ComboboxWin : Window
    {
        User[] Users = new User[]
        {
            new User("Mehmet","Turkey","Waiting"),
            new User("Louder","France","Complete"),
            new User("Merkel","Germany","Waiting"),
            new User("Almad","Spain","Complete"),
            new User("Rouf","Nederland","Waiting"),
            new User("Chai","China","Complete"),
            new User("Yasin","Turkey","Waiting"),
            new User("Messi","France","Complete"),
            new User("Swetter","Germany","Waiting"),
            new User("Terasse","Spain","Complete"),
            new User("Micheal","Nederland","Waiting"),
            new User("Choxi","China","Complete")

        };
        public ComboboxWin()
        {
            InitializeComponent();

            MyList.ItemsSource = Users;

            // FilterBy.ItemsSource = new string[] { "Name", "Country", "Status" }; 

            FilterBy.ItemsSource = typeof(User).GetProperties().Select((o) => o.Name);

            MyList.Items.Filter = nameFilter;
        }

        public Predicate<object> GetFilter()
        {
            switch(FilterBy.SelectedItem as string)
            {
                case "Name":
                    return nameFilter;
                case "Country":
                    return countryFilter;
                case "Status":
                    return StatusFilter;
            }
            return nameFilter;
        }


        private bool nameFilter(object obj)
        {
            var filterObj = obj as User;
            return filterObj.Name.Contains(FilterTextBOX.Text,StringComparison.OrdinalIgnoreCase);
        }
        private bool countryFilter(object obj)
        {
            var filterObj = obj as User;
            return filterObj.Country.Contains(FilterTextBOX.Text, StringComparison.OrdinalIgnoreCase);
        }
        private bool StatusFilter(object obj)
        {
            var filterObj = obj as User;
            return filterObj.Status.Contains(FilterTextBOX.Text, StringComparison.OrdinalIgnoreCase);
        }

        private void FilterBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FilterTextBOX.Text == null)
            {
                MyList.Items.Filter = null;
            }
            else
            {
                MyList.Items.Filter = GetFilter();
            }
        }

        private void FilterTextBOX_TextChanged(object sender, TextChangedEventArgs e)
        {
            MyList.Items.Filter = GetFilter();
        }
    }
}
