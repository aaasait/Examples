using OpenQA.Selenium;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SeleniumWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRun.Click += BtnRun_Click;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            try
            {
                IWebDriver driver = new ChromeDriver();
                driver.Url = "https://www.google.com";

                var searchBox = driver.FindElement(By.Name("q"));

                Thread.Sleep(TimeSpan.FromSeconds(5));

                if (searchBox != null)
                {
                    searchBox.SendKeys("Cihan Özhan");
                    searchBox.SendKeys(OpenQA.Selenium.Keys.Enter);
                }

                Thread.Sleep(TimeSpan.FromSeconds(5));

                driver.Quit();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
