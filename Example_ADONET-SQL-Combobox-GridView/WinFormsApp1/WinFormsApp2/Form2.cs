using WinFormsApp2.Database;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.Load += Form2_Load;
            btnGetAllShippers.Click += BtnGetAllShippers_Click;
        }

        private void BtnGetAllShippers_Click(object? sender, EventArgs e)
        {
            fillData();
        }

        private void Form2_Load(object? sender, EventArgs e)
        {
            fillData();
        }

        void fillData()
        {
            ShipperDAL shipperDAL = new ShipperDAL();
            dgShippersData.DataSource = shipperDAL.GetShippers();
        }
    }
}
