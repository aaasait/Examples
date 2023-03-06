using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormListe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
     

        private void btn_Writer_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 fr1 = new Form1();
                fr1.id = 1;
                fr1.userName = txt_UserNameW.Text;
                fr1.eMail = txt_EmailW.Text;
                fr1.password = txt_PwdW.Text;

                if (check_OnayW.Checked)
                {
                    fr1.checkOnay = true;
                }
                else
                {
                    fr1.checkOnay = false;
                }
                fr1.country_id = combo_CountryW.SelectedIndex;

                fr1.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            try
            {
                Country c1 = new Country(1, "Türkiye");
                Country c2 = new Country(2, "Almanya");
                Country c3 = new Country(3, "Hollanda");
                Country c4 = new Country(4, "Avusturya");
                GetCountry gt = new GetCountry();
                gt.AddCountry(c1);
                gt.AddCountry(c2);
                gt.AddCountry(c3);
                gt.AddCountry(c4);

                combo_CountryW.DataSource = gt.Countries;
                combo_CountryW.ValueMember = "Id_Country";
                combo_CountryW.DisplayMember = "Name_Country";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
