using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormListe
{
    public partial class Form1 : Form
    {
        string _path = @"C:\Users\Z004PTKX\source\repos\rts.xml";
        public Form1()
        {
            InitializeComponent();

            
        }


        public int id;
        public string userName;
        public string password;
        public string eMail;
        public bool checkOnay;
        //public string country_name;
        public int country_id;

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 1;
                string username = txt_UserName.Text;
                string email = txt_Email.Text;
                string pwd = txt_Pwd.Text;
                bool onay;
                bool OnayResult = check_Onay.Checked;
                string country_id = combo_Country.GetItemText(combo_Country.SelectedValue);
                int c_id = Convert.ToInt32(country_id);

                if (check_Onay.Checked)
                {
                    onay = true;
                }
                else
                {
                    onay = false;
                }

                FileWriter flw = new FileWriter();
                flw.XMLSerilize(_path, id, username, email, pwd, c_id, onay);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

  

        private void Form1_Load(object sender, EventArgs e)
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

                combo_Country.DataSource = gt.Countries;
                combo_Country.ValueMember = "Id_Country";
                combo_Country.DisplayMember = "Name_Country";

                txt_UserName.Text = userName;
                txt_Email.Text = eMail;
                txt_Pwd.Text = password;
                if (checkOnay == true)
                {
                    check_Onay.Checked = true;
                }
                else
                {
                    check_Onay.Checked = false;
                }
                combo_Country.SelectedIndex = country_id;

                /*
                foreach (var item in gt.Countries)
                {
                    combo_Country.Items.Add(item.Name_Country);
                    combo_Country.Items.Add(item.Id_Country);
                    // combo_Country.Items.Add(item);
                    // combo_Country.DataSource = combo_Country.Items;
                    // combo_Country.DisplayMember = item.Name_Country.ToString();

                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void combo_Country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  

        private void btn_FormPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2= new Form2();   
            form2.ShowDialog(); 
        }
    }
}
