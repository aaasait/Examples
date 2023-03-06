using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisConnection
{
    public partial class Form2 : Form
    {
        SqlDataAdapter adapter = null;
        DataTable dt=null;
        SqlCommandBuilder cmdBuilder= null; 
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
             adapter = new SqlDataAdapter("Select * from Shippers", Connection.GetConnectionString);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        // DİREK TABLO ÜZERİNDE GRİDVİEW DE DEĞİŞİKLİK YAPMA
        private void btnDegisiklikUygula_Click(object sender, EventArgs e)
        {
            cmdBuilder= new SqlCommandBuilder(adapter);
            adapter.Update(dt);
        }
    }
}
