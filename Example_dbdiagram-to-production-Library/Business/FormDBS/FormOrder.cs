using FormDBS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDB
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void btnReturnMainPageOrder_Click(object sender, EventArgs e)
        {
            FormMainPage formMainPage = new FormMainPage();
            formMainPage.ShowDialog();
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPaymentOrder_Click(object sender, EventArgs e)
        {
            FormPayment formPayment=new FormPayment();
            formPayment.ShowDialog();
        }
    }
}
