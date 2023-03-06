using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Web;

namespace project03console
{
    // Research Project

        // Projedeki bugların bulunması ve fix'lenmesi.
        // Kullanılan teknik ve özelliklerin araştırılması.
        // Projeyi modüler hale getirmek : Özellikleri parçalar halinde farklı metotlara dönüştürmek.
        // Projeye yeni scraping özelliklerinin eklenmesi(ayrı metotlar olarak) : Yeni sayfalar, sayfalardan farklı verilerin çıkarımlanması(extraction)
        // Projenin programsal hata olasılıklarının çıkarılması ve bunlara karşı güçlendirilmesi.
        // Projenin çıkarımladığı veriyi(data extraction) TXT olarak saklanması.
        // Projenin bir CLI olarak çalışmasının sağlanması.
            // Main(string[] args) -> args'ı terminal üzerinden kullanmak.
            // "crawl.exe target==abc.com" olarak çalıştırmak.

    // website : https://www.ciceksepeti.com/dizustu-bilgisayar-laptop
    // website : https://www.ciceksepeti.com/
    internal class Program
    {
          private static string product_card_query = "//div[@class='wrapper-product-main']";
        // private static string product_card_query = "product-list product-list--list-page";
        private const string BASE_URI = "https://www.ciceksepeti.com";
        static void Main(string[] args)
        {
            Console.Write("Website : ");
            // string url = Console.ReadLine();
            string url = "https://www.vatanbilgisayar.com/bilgisayar/";
             List <Product> product_list = new List<Product>();

            HtmlWeb web = new HtmlWeb();
            web.PreRequest += PreRequest;
            int pageNumber = 50;

            while (true)
            {
                try
                {
                    NameValueCollection nvc = new NameValueCollection();
                    nvc["page"] = pageNumber.ToString();
                    string preparedUri = url; //+ ToQueryString(nvc);
                    var doc = web.Load(preparedUri);

                    var products = doc.DocumentNode.SelectNodes(product_card_query);



                    foreach (var productDiv in products)
                    {
                        Product new_product = new Product();
                      //  string img = item.SelectSingleNode(".//img").GetAttributeValue("src", null).Trim();
                        var product_url_node = productDiv.SelectSingleNode(".//a[@class='products__item-link js-products__item-link']");
                        if (product_url_node != null)
                            new_product.ProductUri = BASE_URI + product_url_node.Attributes["href"].Value;

                        string product_image_node = productDiv.SelectSingleNode(".//div[@class=^product-list__image-safe^]//a[@class='product-list__image-safe-link sld']//div[@class='slider-img']//img[@class='lazyimg']").GetAttributeValue("src", null).Trim();

                        //owl-lazy


                        //string product_image_url = string.Empty;
                        //if (product_image_node != null)
                        //    new_product.ProductImageUri = product_image_node.Attributes["data-src"].Value;

                        var title_node = productDiv.SelectSingleNode(".//p[@class='products__item-title']");
                        if (title_node != null)
                            new_product.ProductTitle = title_node.InnerText;

                        var price_node = productDiv.SelectSingleNode(".//a[@class='products__item-link js-products__item-link']//div[@class='products__item-info']//div[@class='products__item-details']//div[@class='products__item-price js-no-tax']//div[@class='price price--now']");
                        if (price_node != null)
                            new_product.ProductPrice = price_node.Attributes["data-price"].Value;




                        product_list.Add(new Product(){
                            ProductImageUri= product_image_node,
                            ProductPrice= "",
                            ProductTitle="",
                            ProductUri=""

                        });
                    }

                    pageNumber++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    break;
                }
            }

            foreach (var product in product_list)
            {
                Console.WriteLine(product.ProductUri);
            }

            Console.ReadLine();
        }

        private static bool PreRequest(HttpWebRequest request)
        {
            request.AllowAutoRedirect = false;
            return true;
        }

        public static string ToQueryString(NameValueCollection nvc)
        {
            var array = (
                from key in nvc.AllKeys
                from value in nvc.GetValues(key)
                select string.Format(
                    "{0}={1}",
                    HttpUtility.UrlEncode(key),
                    HttpUtility.UrlEncode(value))
            ).ToArray();
            return "?" + string.Join("&", array);
        }
    }
}
