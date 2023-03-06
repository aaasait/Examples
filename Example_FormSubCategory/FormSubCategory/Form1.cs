using FormSubCategory.Listeleme;
using FormSubCategory.Marka;
using FormSubCategory.Sektor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSubCategory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListMarka marka = new ListMarka();
        ListMarka marka1 = new ListMarka();
        private void Form1_Load(object sender, EventArgs e)
        {

            ComboboxSektorAdd(); // Sektör ekleme methodu


        }

        public void ComboboxSektorAdd()
        {
            Sektorler sektorDefault = new Sektorler(0, "--Sektör Seçiniz--");
            Sektorler sektorOtomotiv = new Sektorler(1, "Otomotiv");
            Sektorler sektorBanka = new Sektorler(2, "Banka");
            

            ListSektor sektor = new ListSektor();
            sektor.AddSektor(sektorDefault);
            sektor.AddSektor(sektorOtomotiv);
            sektor.AddSektor(sektorBanka);


            comboSektor.DataSource = sektor.sektorListesi;
            comboSektor.ValueMember = "SektorId";
            comboSektor.DisplayMember = "SektorName";
        }

        public void ComboboxMarkaAdd()
        {
            Markalar markaDefault = new Markalar(0, "--Marka Seçiniz--", 0);
            Markalar marka1 = new Markalar(1, "Tofaş", 1);
            Markalar marka2 = new Markalar(2, "Doğuş Otomotiv", 1);
            Markalar marka3 = new Markalar(3, "Vakıf Bank", 2);
            Markalar marka4 = new Markalar(4, "Akbank", 2);

            // ListMarka marka = new ListMarka();


            marka.AddMarka(markaDefault);
            marka.AddMarka(marka1);
            marka.AddMarka(marka2);
            marka.AddMarka(marka3);
            marka.AddMarka(marka4);

            comboMarka.DataSource = marka.markaListesi;
            comboMarka.ValueMember = "MarkaId";
            comboMarka.DisplayMember = "MarkaName";


        }

       

        private void comboSektor_SelectedIndexChanged(object sender, EventArgs e)
        {

               
            if (comboSektor.SelectedIndex == 2)
            {
               
                Markalar markaDefault = new Markalar(0, "--Marka Seçiniz--", 0);
                Markalar marka3 = new Markalar(3, "Vakıf Bank", 2);
                Markalar marka4 = new Markalar(4, "Akbank", 2);
                marka.AddMarka(markaDefault);
                marka.AddMarka(marka3);
                marka.AddMarka(marka4);
                comboMarka.DataSource = marka.markaListesi;
                comboMarka.ValueMember = "MarkaId";
                comboMarka.DisplayMember = "MarkaName";
            }
            else if(comboSektor.SelectedIndex == 1)
            {
               
                Markalar1 markaDefault = new Markalar1(0, "--Marka Seçiniz--", 0);
                Markalar1 marka1 = new Markalar1(1, "Tofaş", 1);
                Markalar1 marka2 = new Markalar1(2, "Doğuş Otomotiv", 1);
                marka.AddMarka1(markaDefault);
                marka.AddMarka1(marka1);
                marka.AddMarka1(marka2);
                comboMarka.DataSource = marka.markaListesi1;
                comboMarka.ValueMember = "MarkaId";
                comboMarka.DisplayMember = "MarkaName";
            }
           
        }
    }
}
