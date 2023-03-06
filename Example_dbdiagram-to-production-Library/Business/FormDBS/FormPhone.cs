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
using Business.User;

namespace FormDB
{
    public partial class FormPhone : Form
    {
        public FormPhone()
        {
            InitializeComponent();
        }

        private void btnReturnMainPagePhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("index : "+ phoneNumber);
            FormMainPage formMainPage = new FormMainPage();
            formMainPage.ShowDialog();
        }

        public int id;
        public string phoneName;
        public string phoneNumber;
        public PhoneType phoneTypes;
        public int selectedIndex;
        private void btnSavePhone_Click(object sender, EventArgs e)
        {
            id = 1;
            phoneName=txtNamePhone.Text;
            phoneNumber=txtNumberPhone.Text;

            if (comboTypePhone.SelectedIndex==0)
            {
                phoneTypes = PhoneType.Home;
            }
            if (comboTypePhone.SelectedIndex == 1)
            {
                phoneTypes = PhoneType.Work;
            }
            selectedIndex = comboTypePhone.SelectedIndex;


            //Phone p = new Phone(id, phoneName, phoneNumber, phoneTypes);
        }

        public int GetID()
        {
            return id;
        }
        public string GetPhoneName()
        {
            return phoneName;   
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }
        public int GetSelectedIndex()
        {
            return selectedIndex;
        }
        public PhoneType GetPhoneTypes()
        {
            return phoneTypes;
        }

        private void FormPhone_Load(object sender, EventArgs e)
        {
           var phoneType = Enum.GetValues(typeof(PhoneType)).Cast<PhoneType>().Select(phoneValue => ((int)phoneValue)).ToList();
          
            int phoneNumber = 0;
            foreach (var item in phoneType)
            {
                phoneNumber += 1;
            }

            int[] dz = new int[phoneNumber];

            foreach (var i in phoneType)
            {
                dz[i]+= i;
            }

            MessageBox.Show(dz[0]+" " + dz[1]);
            if (dz[0] == 0)
            {
                comboTypePhone.Items.Add(PhoneType.Home);
            }
            if (dz[1] == 1)
            {
                comboTypePhone.Items.Add(PhoneType.Work);
            }
            comboTypePhone.SelectedIndex = 0;
           

           
        }
    }
}
