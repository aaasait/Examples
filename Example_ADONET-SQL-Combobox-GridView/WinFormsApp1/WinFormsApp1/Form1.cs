using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();

            btnOpenConn.Click += BtnOpenConn_Click;
            btnCloseConn.Click += BtnCloseConn_Click;

            var _str = "Server=.;Database=AdventureWorks;Uid=sa;Pwd=1234567";
            //var _str = "Server=.;Database=AdventureWorks;User Id=sa;Password=1234567";
            //var _str = "Data Source=.;Initial Catalog=AdventureWorks;Integrated Security=SSPI";
            conn.ConnectionString = _str;
        }

        private void BtnOpenConn_Click(object? sender, EventArgs e)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                    lblMessage.Text = "Open!";
                }
                else
                {
                    lblMessage.Text = "Not Open!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCloseConn_Click(object? sender, EventArgs e)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                    lblMessage.Text = "Not Open!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}