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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace project01win
{
    // https://stackoverflow.com/questions/21455349/xpath-query-get-attribute-href-from-a-tag
    public partial class Form1 : Form
    {
        HtmlWeb htmlWeb = new HtmlWeb();
        public Form1()
        {
            InitializeComponent();

            btnGetData.Click += BtnGetData_Click;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtWebsite.Text = "https://haberler.com/son-dakika/";
        }

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                var doc = htmlWeb.Load(txtWebsite.Text);
                //MessageBox.Show(doc.Text);

                var newsList = new List<News>();

                HtmlNodeCollection hblColls = doc.DocumentNode.SelectNodes("//div[@class='hblnBox']");

                foreach (var hbl in hblColls)
                {
                    string newsTime = hbl.SelectSingleNode("//div[@class='hblnTime']").InnerText;
                    string newsImage = ""; // hbl.SelectSingleNode("//div[@class='hblnBox']/a[1]/@href").Attributes["src"].Value;
                                           // var x = hbl.SelectSingleNode("//div[@class='hblnBox']/a[1]/@href[1]").ChildNodes;
                    string newsTitle = hbl.SelectSingleNode("//div[@class='hblnBox']/a[1]/@title").InnerText;

                    string newsURI = hbl.SelectSingleNode("//div[@class='hblnImage']/img").Attributes["src"].Value;
                    //string newsURI = hbl.SelectSingleNode("//div[@class='hblnBox']/a[1]/img").Attributes["src"].Value;
                    //string newsURI = hbl.SelectSingleNode("//div[@class='hblnBox']/a[1]/@href").InnerHtml;

                    //string newsDesc = hbl.SelectSingleNode("//div[@class='hblnImage']/img").Attributes["alt"].Value;
                    string newsDesc = hbl.SelectSingleNode("//div[@class='hblnImage']/img").Attributes["alt"].Value;

                    /*
                        <div class="logo-area">
                            <img src="https://s.hbrcdn.com/mstatic/assets/img/haberler-logo.png" width="159" height="17" alt="Haberler">
                        </div>

                        <div class="hblnImage">
                            <img src="https://i.hbrcdn.com/haber/2023/02/22/hindistan-da-hapisteki-tecavuz-ve-cinayet-15652029_o.jpg" 
                                width="100%" height="194" alt="Hindistan">
                        </div>
                        <span class="hblnContent">Hindistan</span>
                    */

                    //
                    //var _htmlImageResearch = hbl.SelectSingleNode("//div[@class='hblnBox']/a[1]/@href[1]").ChildNodes;
                    //foreach (HtmlNode y in _htmlImageResearch)
                    //{
                    //    //MessageBox.Show(y.ChildNodes.ToString());
                    //    MessageBox.Show(y.ParentNode.ToString());
                    //}

                    //MessageBox.Show("URI " + newsURI);

                    newsList.Add(new News()
                    {
                        Time = newsTime,
                        PictureURL = newsImage,
                        Title = newsTitle,
                        URI = newsURI,
                        Description = newsDesc,
                    });

                    //lstData.Items.AddRange(newsList.ToArray());
                    //lstData.Items.Add(newsImage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("X!");
        }
    }
}
