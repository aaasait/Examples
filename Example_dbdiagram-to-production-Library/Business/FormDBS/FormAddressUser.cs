using Business.Listed;
using Business.Payment;
using Business.User;
using FormDBS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Base;
using Business.Listed;
using Business.Payment;
using System.Net.Http.Headers;


namespace FormDB
{
    public partial class FormAddressUser : Form
    {
        public FormAddressUser()
        {
            InitializeComponent();
        }

        
        private void btnSaveAddress_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReturnMainPageAddress_Click(object sender, EventArgs e)
        {
            FormMainPage formMainPage = new FormMainPage();
            formMainPage.ShowDialog();
        }

        private void btnAddPhoneAddress_Click(object sender, EventArgs e)
        {
            FormPhone formPhone = new FormPhone();
            formPhone.ShowDialog();
        }
        public PhoneType ph = PhoneType.Home;
        private void FormAddressUser_Load(object sender, EventArgs e)
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

            comboCityAddress.DataSource = listCity.cities;
            comboCityAddress.ValueMember = "ID";
            comboCityAddress.DisplayMember = "Name";


            Country country1 = new Country(1, "Turkey", true);
            Country country2 = new Country(2, "America", false);
            Country country3 = new Country(34, "Germany", true);

            ListCountry listCountry = new ListCountry();
            listCountry.AddCountry(country1);
            listCountry.AddCountry(country2);
            listCountry.AddCountry(country3);

            comboCountryAddress.DataSource = listCountry.countries;
            comboCountryAddress.ValueMember = "ID";
            comboCountryAddress.DisplayMember = "Name";

            //******

            ListPhone lsp = new ListPhone();
            FormPhone pr = new FormPhone();
            int id = pr.GetID();
            string phoneName = pr.GetPhoneName();

            int index = pr.GetSelectedIndex();
            string phoneNumber = pr.GetPhoneNumber();
            PhoneType comboPhoneType = pr.GetPhoneTypes();

            //if (comboPhoneType == PhoneType.Work)
            //{
            //    ph = PhoneType.Home;

            //}
            //if (comboPhoneType == PhoneType.Home)
            //{
            //    ph = PhoneType.Work;

            //}
            if (index == 0)
            {
                ph = PhoneType.Home;
            
            }
            if (index == 1)
            {
                ph = PhoneType.Work;
            }
            Phone p = new Phone(id, phoneName, phoneNumber);

            lsp.AddPhone(p);


            comboPhoneAddress.DataSource = lsp.phones;
            comboPhoneAddress.ValueMember = "ID";
            comboPhoneAddress.DisplayMember = "PhoneNumber";

            if (index == 0)
            {
                ph = PhoneType.Home;
                MessageBox.Show("Test  :" +p.Name);
            }



        }
    }
}
