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

namespace FormDB
{
    public partial class FormProvider : Form
    {
        public FormProvider()
        {
            InitializeComponent();
        }

        
        // static kullan
        public static int id;
        public static string provider_name;
        public static string provider_description;
        public Provider provider;
        ProviderMapping pm=new ProviderMapping();
        ListProvider lp= new ListProvider();
        public void btnSaveProvider_Click(object sender, EventArgs e)
        {
            id = 1;
            provider_name = txtNameProvider.Text;
            provider_description = txtDescriptionProvider.Text;
            provider=new Provider(id, provider_name, provider_description);
            lp.AddProvider(provider);
            //pm.id_p= id;
            //pm.Name = provider_name;
            //pm.Description = provider_description;




        }

        private void btnReturnMainPageProvider_Click(object sender, EventArgs e)
        {
            FormMainPage formMainPage = new FormMainPage();
            formMainPage.ShowDialog();
        }

        public int GetID()
        {
            return id;
        }

        public string GetName()
        {
           return provider_name;
        }

        public string GetDescription()
        {            
            return provider_description;
        }
    }
}
