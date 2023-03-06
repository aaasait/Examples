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
    public partial class FormBasketItem : Form
    {
        public FormBasketItem()
        {
            InitializeComponent();
        }

        private void btnReturnMainPageBasketItem_Click(object sender, EventArgs e)
        {
            FormMainPage formMainPage = new FormMainPage();
            formMainPage.ShowDialog();
        }

        private void btnAddBasketBasketItem_Click(object sender, EventArgs e)
        {
            FormBasket formBasket= new FormBasket();
            formBasket.ShowDialog();
        }

        private void btnSaveBasketItem_Click(object sender, EventArgs e)
        {

        }
    }
}
