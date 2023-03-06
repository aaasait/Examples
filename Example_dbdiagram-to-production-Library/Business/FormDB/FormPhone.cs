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
    public partial class FormPhone : Form
    {
        public FormPhone()
        {
            InitializeComponent();
        }

        private void btnReturnMainPagePhone_Click(object sender, EventArgs e)
        {
            FormMainPage formMainPage = new FormMainPage();
            formMainPage.ShowDialog();
        }

        private void btnSavePhone_Click(object sender, EventArgs e)
        {

        }
    }
}
