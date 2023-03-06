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
    public partial class FormUserCreditCard : Form
    {
        public FormUserCreditCard()
        {
            InitializeComponent();
        }

        private void btnSaveCreditCard_Click(object sender, EventArgs e)
        {
            string numberCreditCard= txtNumberCreditCard.Text;
            string u_id=txtUserIDCreditCard.Text;
            string comboCardType = txtPaymentTypeCreditCard.Text;
            string provider= comboProviderCreditCard.GetItemText(comboProviderCreditCard.SelectedValue);
            int provider_convert = Convert.ToInt32(provider);
            DateTime dateTime = dateTimeExpiryCreditCard.Value;
            MessageBox.Show("Tarih : "+dateTime.Date);

        }

        private void btnReturnMainPageCreditCard_Click(object sender, EventArgs e)
        {
            FormMainPage formMainPage = new FormMainPage();
            formMainPage.ShowDialog();
        }

        private void btnAddProviderCreditCard_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.ShowDialog();
        }

        private void FormUserCreditCard_Load(object sender, EventArgs e)
        {

        }
    }
}
