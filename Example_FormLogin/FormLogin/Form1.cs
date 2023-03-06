namespace FormLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string username="user";
        public string sifre = "user";

        private void button_giris_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_username.Text == username && textBox_pwd.Text == sifre)
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata : "+ex.Message);
            }
            
        }
    }
}