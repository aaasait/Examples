using SQLStoreProcedure.Business;
using SQLStoreProcedure.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLStoreProcedure
{
    public partial class Form1 : Form
    {
        ShipperDAL ShipperDL= new ShipperDAL();
        public Form1()
        {
            InitializeComponent();

            btnEkle.Click += BtnEkle_Click;
            btnSil.Click += BtnSil_Click;
            btnGuncelle.Click += BtnGuncelle_Click;
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string id = txtSirketNo.Text;
            int ids = Convert.ToInt32(id);
            string compName = txtSirketAdi.Text;
            string phone = txtSirketTelefon.Text;

            bool result = ShipperDL.Update(ids, compName, phone);

            if (result)
            {
                MessageBox.Show("Başarılı Güncelleme");
            }
            else
            {
                MessageBox.Show("Başarısız... Güncelleme");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            string id=txtSirketNo.Text;

            int ids=Convert.ToInt32(id);
            bool result = ShipperDL.Delete(ids);

            if (result)
            {
                MessageBox.Show("Başarılı Silme");
            }
            else
            {
                MessageBox.Show("Başarısız... Silme");
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
           string compName=txtSirketAdi.Text;
            string phone=txtSirketTelefon.Text;

            bool result = ShipperDL.Add(compName,phone);

            if (result)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız...");
            }
        }
    }
}
