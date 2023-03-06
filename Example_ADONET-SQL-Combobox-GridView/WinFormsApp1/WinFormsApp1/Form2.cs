using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWConnStr"].ConnectionString);
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AWConnStr"].ConnectionString);
        public Form2()
        {
            InitializeComponent();

            // SqlConnection    :   SQL Server veritabanına bağlantı oluşturmayı sağlar.
            // ExecuteScalar    :   Yapılan işlem sonucunda tek bir kayıt döner.
            // ExecuteReader    :   Bir tablonun verisi alınır ve sadece ileri doğru okuma yapmayı sağlar.
            // ExecuteNonQuery  :   Veri için CRUD, nesne için CAD sorguları çalıştırmak için kullanılır.
            //                          INT değer döner.

            btnExecuteReader.Click += BtnExecuteReader_Click;
            btnExecuteScalar.Click += BtnExecuteScalar_Click;
            btnExecuteProcedure.Click += BtnExecuteProcedure_Click;
        }

        private void BtnExecuteProcedure_Click(object? sender, EventArgs e)
        {
            //ExecuteStoredProcedureGet();

            ExecuteStoredProcedure("Beşiktaş", 11.3M, 33.2M, DateTime.Now);
        }

        private void BtnExecuteScalar_Click(object? sender, EventArgs e)
        {
            ExecuteScalar();
        }

        private void BtnExecuteReader_Click(object? sender, EventArgs e)
        {
            //ExecuteReader(7);
            //ExecuteReaderNextResult();
        }

        // Text Queries

        void ExecuteReader(int deger)
        {
            string sql = "SELECT ProductID, ProductName FROM dbo.Products WHERE ProductID <= " + deger.ToString();   // NORTHWND DB
            //string sql = "SELECT ProductID, Name FROM Production.Product WHERE ProductID <= 7;";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                StringBuilder builder = new StringBuilder();
                while (reader.Read())
                {
                    builder.Append("***********");
                    builder.Append(Environment.NewLine);
                    builder.Append("Ürün No : ");
                    builder.Append(reader[0]);
                    builder.Append(Environment.NewLine);
                    builder.Append("Ürün Ad : ");
                    builder.Append(reader[1]);
                    builder.Append(Environment.NewLine);
                }
                conn.Close();

                txtResult.Text = builder.ToString();
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

        void ExecuteReaderNextResult()
        {
            string sql = "SELECT ProductID, ProductName FROM Products WHERE ProductID <= 5;SELECT CustomerID, CompanyName FROM Customers WHERE CustomerID LIKE 'A%'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                bool bResult = false;

                StringBuilder builder = new StringBuilder();
                do
                {
                    while (dr.Read())
                    {
                        builder.Append("***********");
                        builder.Append(Environment.NewLine);
                        builder.Append("Ürün No : ");
                        builder.Append(dr[0]);
                        builder.Append(Environment.NewLine);
                        builder.Append("Ürün Ad : ");
                        builder.Append(dr[1]);
                        builder.Append(Environment.NewLine);
                    }
                    bResult = dr.NextResult();
                } while (bResult);
                //conn.Close();
                txtResult.Text = builder.ToString();
            }
            catch (SqlException ex)
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

        void ExecuteScalar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(ProductID) FROM Products;";

                conn.Open();

                string s = cmd.ExecuteScalar().ToString();
                txtResult.Text = s + " " + "kayıt bulundu!";
                
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Stored Procedure

        void ExecuteStoredProcedure(string name, decimal costRate, 
                                    decimal availability, DateTime modifiedDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.CommandText = "pr_AddLocation";

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "Name";
                pName.Value = name;
                pName.SqlDbType = SqlDbType.NVarChar;

                SqlParameter pCostRate = new SqlParameter();
                pCostRate.ParameterName = "CostRate";
                pCostRate.Value = costRate;
                pCostRate.SqlDbType = SqlDbType.Decimal;

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
                int x = cmd.ExecuteNonQuery();
                txtResult.Text = x.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ExecuteStoredProcedureGet()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "pr_UrunleriGetir";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                StringBuilder builder = new StringBuilder();
                while (reader.Read()) 
                {
                    builder.Append("*****************");
                    builder.Append(Environment.NewLine);
                    builder.Append("Ürün ID : ");
                    builder.Append(reader.GetInt32(0));  // Select X, Y, Z from...
                    builder.Append("Ürün Ad : ");
                    builder.Append(reader[1]);
                    builder.Append(Environment.NewLine);
                }
                reader.Close();
                conn.Close();
                txtResult.Text = builder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
