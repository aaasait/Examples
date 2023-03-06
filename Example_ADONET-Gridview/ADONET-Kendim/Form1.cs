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

namespace ADONET_Kendim
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        
        public Form1()
        {
            InitializeComponent();

            

            btnSave.Click += BtnSave_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnCountUser.Click += BtnCountUser_Click;
            this.Load += Form1_Load;

            var str = "Server=EVT03307NB\\MSSQLSERVER2022;Initial Catalog=Users; Uid=sa; Password=AbdullahSaitKoc68";
            conn.ConnectionString = str;

        }

        private void BtnCountUser_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(UserID) from dbo.Userx;";

                conn.Open();

                string s = cmd.ExecuteScalar().ToString();
                MessageBox.Show(s+" Finded Data Count !");

                conn.Close();

            }
            catch (SqlException ex) // sql komutu olduğu için hata sql olur
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            griddoldur("select * FROM Userx");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboCityGet();
            griddoldur("select * FROM Userx");

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

              
            try
            {
              
                int genterKind = 0;

                // bool genders = false;
                if (radiobtnMan.Checked == true)
                {
                    genterKind = 1;

                }
                if (radiobtnWomen.Checked == true)
                {
                    genterKind = 0;

                }
                int a = Convert.ToInt32(comboCity.SelectedIndex);
                a += 1;
                conn.Open();
                SqlCommand komutx = new SqlCommand("insert into dbo.Userx(UserName,UserEmail,UserPassword,UserBirthDay,UserCity,UserGender,UserJob) values (@UserName,@UserEmail,@UserPassword,@UserBirthDay,@UserCity,@UserGender,@UserJob)", conn);
                komutx.Parameters.AddWithValue("@UserName", txtUserName.Text);
                komutx.Parameters.AddWithValue("@UserEmail", txtEmail.Text);
                komutx.Parameters.AddWithValue("@UserPassword", txtPassword.Text);
                komutx.Parameters.AddWithValue("@UserBirthDay", datetimeBirthDay.Value);
                komutx.Parameters.AddWithValue("@UserCity", a);
                komutx.Parameters.AddWithValue("@UserGender", genterKind);
                komutx.Parameters.AddWithValue("@UserJob", txtJob.Text);
                MessageBox.Show(a.ToString());
                komutx.ExecuteNonQuery();

                conn.Close();

                griddoldur("select * FROM Userx");
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Save is Successfully");
        }
        public void comboCityGet()
        {
           

            conn.Open();

            SqlCommand cityGet = new SqlCommand("select CityID,CityName from City", conn);
            SqlDataReader cityDr = cityGet.ExecuteReader();
            while (cityDr.Read())
            {

                comboCity.Items.Add(cityDr[1]);
            }


            conn.Close();
        }
        public void griddoldur(string veriler)
        {
           

            SqlDataAdapter da = new SqlDataAdapter(veriler, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        public void Clear()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtJob.Text = "";
            comboCity.Text= "---Select---";
            radiobtnMan.Checked = false;
            radiobtnWomen.Checked = false;

        }
    }
}
