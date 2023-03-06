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
    public partial class FormBasket : Form
    {
        public FormBasket()
        {
            InitializeComponent();
        }

        private void btnReturnMainPageBasket_Click(object sender, EventArgs e)
        {
            FormMainPage formMainPage = new FormMainPage();
            formMainPage.ShowDialog();
        }

        private void btnSaveBasket_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBasketItemBasket_Click(object sender, EventArgs e)
        {
            FormBasketItem formBasketItem=new FormBasketItem();
            formBasketItem.ShowDialog();
        }
    }
}
