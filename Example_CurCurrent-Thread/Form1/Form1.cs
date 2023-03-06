using System.Drawing.Imaging;
using System.Net;

namespace Form1
{
    public partial class Form1 : Form
    {
        static string x = "https://upload.wikimedia.org/wikipedia/en/7/74/Murtaza_Bhutto.png";

        public Form1()
        {
            InitializeComponent();
        }

        private static  void DowloadImageAsync()
        {
            // SIEMENS DE BUNLAR VAR ÖĞREN
            // byte stream dizileri Network programlama temelleri c$

            WebClient client = new WebClient();
            byte[] imageData = client.DownloadData(x);
            var img = Image.FromStream(new MemoryStream(imageData));
            img.Save("murtaza-bey.jpg",ImageFormat.Jpeg);

        }

        private static async void DowloadImage()
        {
            
            // byte stream dizileri Network programlama temelleri c$

            WebClient client = new WebClient();
            byte[] imageData = client.DownloadData(x);
            var img = Image.FromStream(new MemoryStream(imageData));
            img.Save("murtaza-bey.jpg", ImageFormat.Jpeg);

        }

        private static async void DoIyAsync()
        {
            string result = await DoItAsync();
            Console.WriteLine(result);
        }

        public static async string DoItAsync()
        {
            string static m = "m";
            return m;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //WebClient client = new WebClient();
            //byte[] imageData = client.DownloadData(x);
            //pictureBox1.Image = Image.FromStream(new MemoryStream(imageData));

           // DowloadImage(); // resim indirildi  /bin/debug/


        }
    }
}