using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            this.Load += Form3_Load;

            cmbKategoriler.SelectedIndexChanged += CmbKategoriler_SelectedIndexChanged;
            cmbUrunler.SelectedIndexChanged += CmbUrunler_SelectedIndexChanged;
        }

        private void CmbKategoriler_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int selectedID = 0;
            if (cmbKategoriler.SelectedIndex > 0)
            {
                if (((ComboBox)sender).SelectedValue != null)
                {
                    selectedID = (int)((ComboBox)sender).SelectedValue;
                    GetProductsByCategoryID(selectedID);
                }
            }
        }

        private void CmbUrunler_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int selectedID = 0;
            if (cmbUrunler.SelectedIndex > 0)
            {
                selectedID = (int)((ComboBox)sender).SelectedValue;
                GetProductDetailByProductID(selectedID);
            }
        }

        private void Form3_Load(object? sender, EventArgs e)
        {
            GetCategories();
        }

        public void GetCategories()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(Database.Database.GetConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT CategoryID, CategoryName FROM Categories", conn);

            try
            {
                conn.Open();

                dt.Load(cmd.ExecuteReader());

                cmbKategoriler.DataSource = dt;
                cmbKategoriler.DisplayMember = "CategoryName";
                cmbKategoriler.ValueMember = "CategoryID";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void GetProductsByCategoryID(int catID)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(Database.Database.GetConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName FROM Products WHERE CategoryID = " + catID, conn);

            try
            {
                conn.Open();

                dt.Load(cmd.ExecuteReader());

                cmbUrunler.DataSource = dt;
                cmbUrunler.DisplayMember = "ProductName";
                cmbUrunler.ValueMember = "ProductID";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void GetProductDetailByProductID(int productID)
        {
            string query = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products WHERE CategoryID = @UrunID";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(Database.Database.GetConnectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UrunID", productID);

            try
            {
                conn.Open();

                dt.Load(cmd.ExecuteReader());

                lblUrunNo.Text = dt.Rows[0][0].ToString();  // Sorgudaki sütunların sırası değişirse hata verir.
                lblUrunAd.Text = dt.Rows[0]["ProductName"].ToString();
                lblBirimFiyat.Text = dt.Rows[0]["UnitPrice"].ToString();
                lblStokAdet.Text = dt.Rows[0]["UnitsInStock"].ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
