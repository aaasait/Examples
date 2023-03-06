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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void btnReturnMainPageProduct_Click(object sender, EventArgs e)
        {
            FormMainPage formMainPage = new FormMainPage();
            formMainPage.ShowDialog();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnAddInventoryProduct_Click(object sender, EventArgs e)
        {
            FormProductInventory productInventory= new FormProductInventory();
            productInventory.ShowDialog();
        }

        private void btnAddCategoryProduct_Click(object sender, EventArgs e)
        {
            FormProductCategory productCategory= new FormProductCategory();
            productCategory.ShowDialog();
        }

        private void btnAddDiscountProduct_Click(object sender, EventArgs e)
        {
            FormProductDiscount productDiscount=new FormProductDiscount();
            productDiscount.ShowDialog();
        }
    }
}
