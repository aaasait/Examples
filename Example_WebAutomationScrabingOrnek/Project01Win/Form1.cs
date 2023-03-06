using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01Win
{
    public partial class Form1 : Form
    {
        
        HtmlWeb htmlWeb = new HtmlWeb();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pictureBox1.ImageLocation = Jobs[dataGridView1.CurrentCell.RowIndex].Image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        List<Job> Jobs = new List<Job>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Loading();
        
        }

     
        void Loading()
        {
            try
            {
                var doc = htmlWeb.Load("https://www.emploitic.com/offres--emploi");

                foreach (var item in doc.DocumentNode.SelectNodes("//div[@class='row-fluid job-details pointer']"))
                {
                    string title = item.SelectSingleNode(".//h2").InnerText.Trim();
                    string details = item.SelectSingleNode(".//a").GetAttributeValue("href", null).Trim();
                    string img = item.SelectSingleNode(".//img").GetAttributeValue("src", null).Trim();                
                    string location = item.SelectSingleNode(".//span[@class='spaced-right']").InnerText.Trim();
                    // string department = item.SelectSingleNode(".//h6").InnerText.Trim();


                    Jobs.Add(new Job
                    {
                        Title = title,
                        Details = details,
                        Image = img,
                        Location = location
                    });



                }

                foreach (var jb in Jobs)
                {
                    dataGridView1.Rows.Add(jb.Title, jb.Details, jb.Location, jb.Image);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
