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
    public partial class FormMainPage : Form
    {
        public FormMainPage()
        {
            InitializeComponent();
        }

        private void btnMainPageProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct= new FormProduct();
            formProduct.ShowDialog();
        }

        private void btnMainPageUser_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.ShowDialog();
        }

        private void btnMainPagePayment_Click(object sender, EventArgs e)
        {
            FormPayment formPayment = new FormPayment();
            formPayment.ShowDialog();
        }

        private void btnMainPageOrder_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            formOrder.ShowDialog();
        }

        private void btnMainPageBasket_Click(object sender, EventArgs e)
        {
            FormBasket formBasket = new FormBasket();
            formBasket.ShowDialog();
        }

        private void btnMainPageOrderItem_Click(object sender, EventArgs e)
        {
            FormOrderItem formOrderItem= new FormOrderItem();
            formOrderItem.ShowDialog();
        }

        private void btnMainPageCreditCard_Click(object sender, EventArgs e)
        {
            FormUserCreditCard  formUserCreditCard=new FormUserCreditCard();
            formUserCreditCard.ShowDialog();
        }
    }
}
