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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
             DataSet- DataSet bilgi tutmaz. 
            içinde data tablelar bulunur bilgileri data table da tutar


            SQLDataAdapter- otomatik olarak bağlantı açıp kapatır
            dataset ve data table doldururu
            Fill ile doldurulur


             */
            btnDataSet.Click += BtnDataSet_Click;
            btnDataTable.Click += BtnDataTable_Click;
           
        }

        private void BtnDataTable_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Shippers", Connection.GetConnectionString);
            DataTable DataTable = new DataTable();
            adapter.Fill(DataTable);
            dataGridView1.DataSource = DataTable;
        }

        private void BtnDataSet_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Employees", Connection.GetConnectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
