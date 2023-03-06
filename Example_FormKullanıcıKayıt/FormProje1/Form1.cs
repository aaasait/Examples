using System.Text;

namespace FormProje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_KayitOl.Click += btn_KayitOl_Click;
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                var result = GetData(txt_usename.Text, txt_email.Text, txt_pwd.Text, comboBox_sehir.Text, radioBtn_Erkek.Checked);

                string _msg = "işlem";
                if (result)
                {
                    lbl_sonuc.Text = _msg + " Başarılı ";
                }
                else
                {
                    lbl_sonuc.Text = _msg + " Başarılı ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private bool GetData(
            string kullanicİAd,
            string email,
            string sifre,
            string sehir,
            bool cinsiyet)
        {
            try
            {
                bool result = new bool();
                string _result = Save(kullanicİAd, email, sifre, sehir, cinsiyet);

                if (!string.IsNullOrEmpty(_result) && _result.Length >= 50)
                {
                    result = true;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string Save(
            string kullanicİAd,
            string email,
            string sifre,
            string sehir,
            bool cinsiyet)
        {
            try
            {
                StringBuilder strBuild = new StringBuilder();
                strBuild.Append("KULLANICI AD : " + kullanicİAd);
                strBuild.Append(Environment.NewLine);
                strBuild.Append("E-MAIL : " + email);
                strBuild.Append(Environment.NewLine);
                strBuild.Append("ŞIFRE : " + sifre);
                strBuild.Append(Environment.NewLine);
                strBuild.Append("ŞEHIR : " + sehir);
                strBuild.Append(Environment.NewLine);
                strBuild.Append("CINSIYET : " + (cinsiyet ? "Erkek" : "Kadın"));
                strBuild.Append(Environment.NewLine);
                return strBuild.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}