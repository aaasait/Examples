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
    public partial class FormProductInventory : Form
    {
        public FormProductInventory()
        {
            InitializeComponent();
        }

        private void btnSaveDiscount_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnMainPageDiscount_Click(object sender, EventArgs e)
        {
            FormMainPage formMainPage = new FormMainPage();
            formMainPage.ShowDialog();
        }
    }
}
