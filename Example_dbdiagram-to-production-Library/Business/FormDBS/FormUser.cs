using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Business.Listed;
using Business.User;

namespace FormDB
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void btnAddAddressUser_Click(object sender, EventArgs e)
        {
            FormAddressUser formAddressUser = new FormAddressUser();
            formAddressUser.ShowDialog();
        }

        private void btnAddPhoneUser_Click(object sender, EventArgs e)
        {
            FormPhone formPhone = new FormPhone();
            formPhone.ShowDialog();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            City city1 = new City(1, "Adana", true);
            City city2 = new City(2, "Adıyaman", false);
            City city3 = new City(34, "Istanbul", true);
            City city4 = new City(23, "Elazığ", true);
            City city5 = new City(6, "Ankara", true);
            City city6 = new City(35, "Izmir", true);
            City city7 = new City(25, "Erzurum", false);
            City city8 = new City(68, "Aksaray", false);

            ListCity listCity = new ListCity();
            listCity.AddCity(city1);
            listCity.AddCity(city2);
            listCity.AddCity(city3);
            listCity.AddCity(city4);
            listCity.AddCity(city5);
            listCity.AddCity(city6);
            listCity.AddCity(city7);
            listCity.AddCity(city8);

            comboCityUser.DataSource = listCity.cities;
            comboCityUser.ValueMember = "ID";
            comboCityUser.DisplayMember = "Name";

            
            Country country1 = new Country(1, "Turkey", true);
            Country country2 = new Country(2, "America", false);
            Country country3 = new Country(34, "Germany", true);

            ListCountry listCountry = new ListCountry();
            listCountry.AddCountry(country1);
            listCountry.AddCountry(country2);
            listCountry.AddCountry(country3);

            comboCountryUser.DataSource = listCountry.countries;
            comboCountryUser.ValueMember = "ID";
            comboCountryUser.DisplayMember = "Name";


        }

        private void btnCreditCardUser_Click(object sender, EventArgs e)
        {
            FormUserCreditCard formUserCreditCard = new FormUserCreditCard();
            formUserCreditCard.ShowDialog();
        }
    }
}
