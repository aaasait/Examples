using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnYellow.Click += BtnYellow_Click;
            btnBlue.Click += BtnBlue_Click;
            btnRed.Click += BtnRed_Click;
            btnBlack.Click += BtnBlack_Click;


            this.Load += Form1_Load;
        }

        private void BtnBlack_Click(object? sender, EventArgs e)
        {

            th4 = new Thread(threadTask4);
            th4.Start();

        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            rnd=new Random();
        }
        Random rnd;
        Thread th1;
        Thread th2;
        Thread th3;
        Thread th4;

        private void BtnRed_Click(object? sender, EventArgs e)
        {
            th2 = new Thread(threadTask2);
            th2.Start();
        }

        private void BtnBlue_Click(object? sender, EventArgs e)
        {
            th3 = new Thread(threadTask3);
            th3.Start();
        }

        private void BtnYellow_Click(object? sender, EventArgs e)
        {
            th1 = new Thread(threadTask1);
            th1.Start();
        }

        // Task of Thread
        // GDI pLus       Direct x
        public void threadTask1()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Yellow, 4),
                    new Rectangle(
                        rnd.Next(0, this.Width), 
                        rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);
            }
        }
        public void threadTask2()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4),
                    new Rectangle(
                        rnd.Next(0, this.Width),
                        rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);
            }
        }

        public void threadTask3()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4),
                    new Rectangle(
                        rnd.Next(0, this.Width),
                        rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);
            }
        }

        public void threadTask4()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawEllipse(new Pen(Brushes.Black, 4),
                    new Rectangle(
                        rnd.Next(0, this.Width),
                        rnd.Next(0, this.Height), 50, 50));
                Thread.Sleep(100);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
             // Invalidate(); // form boyutunda değiştiğinde devam ediyor
 
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Invalidate(); // direk devam eder doğru olan bu 
        }


    }
}