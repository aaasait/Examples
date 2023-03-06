using WinFormsApp2.Database;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        ShipperDAL shipDL = new ShipperDAL();
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            btnInsert.Click += BtnInsert_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCompanyID.Text);

            bool result = shipDL.Delete(id);

            if (result)
            {
                MessageBox.Show("Delete İşlem başarılı.");
            }
            else
            {
                MessageBox.Show("Delete İşlem başarısız.");
            }
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCompanyID.Text);
            string compName = txtCompanyName.Text;
            string phone = txtPhone.Text;

            bool result = shipDL.Update(id, compName, phone);

            if (result)
            {
                MessageBox.Show("Update İşlem başarılı.");
            }
            else
            {
                MessageBox.Show("Update İşlem başarısız.");
            }
        }

        private void BtnInsert_Click(object? sender, EventArgs e)
        {
            string compName = txtCompanyName.Text;
            string phone = txtPhone.Text;

            bool result = shipDL.Add(compName, phone);

            if (result)
            {
                MessageBox.Show("Add İşlem başarılı.");
            }
            else
            {
                MessageBox.Show("Add İşlem başarısız.");
            }
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            
        }
    }
}