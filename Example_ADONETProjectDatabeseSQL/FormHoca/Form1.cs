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
using System.Configuration;

namespace FormHoca
{
    public partial class Form1 : Form
    {

        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWConnStr"].ConnectionString);
        SqlConnection conn = new SqlConnection();
        
        public Form1()
        {
            
            InitializeComponent();
            var str = "Server=EVT03307NB\\MSSQLSERVER2022;Initial Catalog=AdventureWorks2019; Uid=sa; Password=AbdullahSaitKoc68";

           // var str = "Server=EVT03307NB\\MSSQLSERVER2022;Initial Catalog=NORTHWND; Uid=sa; Password=AbdullahSaitKoc68";
            //var str = "Data Source=EVT03307NB\\MSSQLSERVER2022;Initial Catalog=AdventureWorks2019; Integrated Security=SSPI";
             conn.ConnectionString = str;

            btnExecuteReader.Click += BtnExecuteReader_Click;
            btnExecuteScalar.Click += BtnExecuteScalar_Click;
            btnExecuteProcedure.Click += BtnExecuteProcedure_Click;
        }

        private void BtnExecuteProcedure_Click(object sender, EventArgs e)
        {
            //  ExecudeStoreProcedureGet();

            ExecudeStoreProcedure("Pendik", 2, 23.5M, DateTime.Now);
        }

        private void BtnExecuteScalar_Click(object sender, EventArgs e)
        {
            ExecuteScalarRun();
        }

        private void BtnExecuteReader_Click(object sender, EventArgs e)
        {
            // ExecuteReaderRun(7);
            ExecuteReaderRunMARS();
        }

    
        public void ExecuteReaderRun(int deger)
        {
             string sql="SELECT ProductID, ProductName FROM dbo.Products WHERE ProductID<="+deger;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                conn.Open();

                SqlDataReader reader= cmd.ExecuteReader();

                StringBuilder stringBuilder= new StringBuilder();
                while (reader.Read())
                {
                
                    stringBuilder.Append("********************");
                    stringBuilder.Append(Environment.NewLine);
                    stringBuilder.Append("URUN NO :");
                    stringBuilder.Append(reader[0]);
                    stringBuilder.Append(Environment.NewLine);
                    stringBuilder.Append("URUN ADI :");
                    stringBuilder.Append(reader[1]);
                    stringBuilder.Append(Environment.NewLine);
                }

                conn.Close();
                txtContent.Text = stringBuilder.ToString();

            }
            catch (Exception ex)
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

        public void ExecuteReaderRunMARS()
        {
            // İKİ SORGU AYNI ANDA GÖSTERME ŞEKLİ MARS YÖNTEMİ DEĞİŞKEN TİPİ AYNI OLMALIDIR
             string sql1 = "SELECT ProductID, ProductName FROM dbo.Products WHERE ProductID<=5; SELECT CustomerID,CompanyName FROM dbo.Customers WHERE CustomerID LIKE 'A%'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql1,conn);               
                cmd.CommandType = CommandType.Text;
             
                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                bool bContent = false;

                StringBuilder stringBuilder = new StringBuilder();
                do
                {
                    while (dr.Read())
                    {

                        stringBuilder.Append("********************");
                        stringBuilder.Append(Environment.NewLine);
                        stringBuilder.Append("URUN NO :");
                        stringBuilder.Append(dr[0]);
                        stringBuilder.Append(Environment.NewLine);
                        stringBuilder.Append("URUN ADI :");
                        stringBuilder.Append(dr[1]);
                        stringBuilder.Append(Environment.NewLine);
                    }
                    bContent=dr.NextResult();
                } while (bContent);

                //conn.Close();
                txtContent.Text = stringBuilder.ToString();

            }
            catch (Exception ex)
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

        public void ExecuteScalarRun() // Tek değer döndürür
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection= conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(ProductID) from dbo.Products;";

                conn.Open();

                string s = cmd.ExecuteScalar().ToString();
                txtContent.Text = s+" "+" Kayıt Bulundu.";

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

        public void ExecudeStoreProcedure(string  name,decimal costRate,decimal availability,DateTime modifiedDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_AddLocations";
               
               
                SqlParameter pName= new SqlParameter();
                pName.ParameterName = "Name";
                pName.Value = name;
                pName.SqlDbType= SqlDbType.NVarChar;

                SqlParameter pCostRate = new SqlParameter();
                pCostRate.ParameterName = "CostRate";
                pCostRate.Value = costRate;
                pCostRate.SqlDbType = SqlDbType.SmallMoney;

                SqlParameter pAvailability = new SqlParameter();
                pAvailability.ParameterName = "Availability";
                pAvailability.Value = availability;
                pAvailability.SqlDbType = SqlDbType.Decimal;

                SqlParameter pModifiedDate = new SqlParameter();
                pModifiedDate.ParameterName = "ModifiedDate";
                pModifiedDate.Value = modifiedDate;
                pModifiedDate.SqlDbType = SqlDbType.DateTime;

                cmd.Parameters.Add(pName);
                cmd.Parameters.Add(pCostRate);
                cmd.Parameters.Add(pAvailability);
                cmd.Parameters.Add(pModifiedDate); 

                cmd.Connection.Open();
                int X=cmd.ExecuteNonQuery();
                txtContent.Text=X.ToString();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();   
            }
        }

        public void ExecudeStoreProcedureGet()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "pr_GetProducts";
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                StringBuilder  builder = new StringBuilder();
                while (reader.Read())
                {

                    builder.Append("********************");
                    builder.Append(Environment.NewLine);
                    builder.Append("URUN NO :");
                    builder.Append(reader.GetInt32(0));
                    builder.Append(Environment.NewLine);
                    builder.Append("URUN ADI :");
                    builder.Append(reader[1]);
                    builder.Append(Environment.NewLine);
                }
                reader.Close();
                conn.Close();

                txtContent.Text = builder.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
