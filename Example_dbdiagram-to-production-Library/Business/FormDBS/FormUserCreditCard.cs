using Business.Listed;
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
using Business.Listed;
using Business.Payment;
using System.Net.Http.Headers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            comboProviderCreditCard.SelectedValue = 0;
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

        ProviderMapping pm = new ProviderMapping(); 
        private void FormUserCreditCard_Load(object sender, EventArgs e)
        {
             
         
            ListProvider lsp= new ListProvider();
            
            FormProvider pr= new FormProvider();

            int id = pr.GetID();
            string name = pr.GetName();
            string descrip = pr.GetDescription();

            //int id = pm.id_p;
            //string name = pm.Name;
            //string descrip = pm.Description;

            //int id = 1;
            //string name = pm.GetNames();
            //string descrip = pm.GetDescriptions();

            //int[] id1 = new int[2];
            //string[] s_name= new string[2];
            //string[] s_description = new string[2];
            //foreach (var i in lsp.GetListProvider())
            //{
            //    id1[0] += i.ID;
            //    s_name[0] += i.Name;
            //    s_description[0] = i.Description;
            //}

            //foreach (var item in lsp.GetListProvider())
            //{
            //    MessageBox.Show(item.Name);
            //}
            //Provider p = new Provider(id1[0], s_name[0], s_description[0]);

            //lsp.AddProvider(p);

            comboProviderCreditCard.DataSource = lsp.GetListProvider();
            comboProviderCreditCard.ValueMember = "ID";
            comboProviderCreditCard.DisplayMember = "Name";



        }
    }
}
