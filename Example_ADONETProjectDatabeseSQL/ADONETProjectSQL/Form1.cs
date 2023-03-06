using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ADONETProjectSQL
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();

            btnCloseCon.Click += BtnCloseCon_Click; ;
            btnOpenCon.Click += BtnOpenCon_Click; ;


            //var str = "Server=.;Initial Catalog=AdventureWorks; User Id=sa; Password=12345";
            var str = "Server=EVT03307NB\\MSSQLSERVER2022;Initial Catalog=AdventureWorks2019; Uid=sa; Password=AbdullahSaitKoc68";
            //var str = "Data Source=EVT03307NB\\MSSQLSERVER2022;Initial Catalog=AdventureWorks2019; Integrated Security=SSPI";
            conn.ConnectionString= str;
        }

        private void BtnOpenCon_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State!=System.Data.ConnectionState.Open)
                {
                    conn.Open();
                    lblConn.Text = "OPEN";
                }
                else
                {
                    lblConn.Text = "not OPEN";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCloseCon_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                    lblConn.Text = "not OPEN";
                }
      
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
