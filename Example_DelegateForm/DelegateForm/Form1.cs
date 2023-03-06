using System;
using System.Windows.Forms;

namespace DelegateForm
{
    public partial class Form1 : Form
    {
        delegate int Del(int x);

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            // this.DoubleClick += Form1_DoubleClick;
            //this.Click += Form1_Click;

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;

            // DİNAMİK BİR NESNE ÜRETMEK 
            Button BTN=new Button();
            BTN.Text= "3";
            BTN.Name = "BTN_OK!";
            BTN.Width = 100;
            BTN.Height = 100;
            BTN.Left = BTN.Width+10;

            TextBox tx = new TextBox();
            tx.Text = "3";
            tx.Width = 150;
            tx.Height = 70;
            tx.Left=tx.Width+10;

            Label lbl=new Label();  
            lbl.Width= 100;
            lbl.Height= 100;


            int sy;

            BTN.Click += delegate (object sender, EventArgs e)
            {
               // Her Toolbox Ayrı özellik ve olay olduğundan (sender as textbox) çalışmaz
                string st = (sender as Button).Text;
                sy = Convert.ToInt32(st);
                sy *= sy;
                lbl.Text = Convert.ToString(sy);
                String msg = (sender as Button).Text;
                MessageBox.Show(msg);
            };
 
            this.Controls.Add( BTN );
            this.Controls.Add(lbl);
            this.Controls.Add(tx);

            
            // Lambda Expressions kullanımı 
            Del myDelegate = x => x * x;
            MessageBox.Show(myDelegate(5).ToString());

            this.Click += (s, e) => { MessageBox.Show("X" + ((MouseEventArgs)e).Location.ToString()); };  
        }
        
        int Hesap(int x)
        {
            return x * x;
        }     
        private void Form1_Click(object sender, EventArgs e)
        {
            // fORMDA TIKLANILAN YERİN KONUMU X ve Y
           var result =((MouseEventArgs)e).Location.ToString();
            MessageBox.Show(result);
        }




        // Button Ekranda Double click fonksiyonu çağırarak yeteneği kazandırdık
        private void Button1_Click(object sender, EventArgs e)
        {
            //DoubleClick += Form1_DoubleClick;
        }
        // Button Ekranda Double click fonksiyonu çağırarak yeteneği geri aldık

        private void Button2_Click(object sender, EventArgs e)
        {
            //DoubleClick -= Form1_DoubleClick;
        }


        void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Message Loaded");
        }
        void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Çift Tıklandı");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}