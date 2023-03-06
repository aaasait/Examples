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
    public partial class FormAddressUser : Form
    {
        public FormAddressUser()
        {
            InitializeComponent();
        }

        private void btnSaveAddress_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnMainPageAddress_Click(object sender, EventArgs e)
        {
            FormMainPage formMainPage = new FormMainPage();
            formMainPage.ShowDialog();
        }

        private void btnAddPhoneAddress_Click(object sender, EventArgs e)
        {
            FormPhone formPhone = new FormPhone();
            formPhone.ShowDialog();
        }
    }
}
