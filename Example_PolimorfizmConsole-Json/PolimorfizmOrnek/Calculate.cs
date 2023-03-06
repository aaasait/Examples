using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolimorfizmOrnek;
using System.Net;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace PolimorfizmOrnek
{
    class Calculate
    {
        private List<Product> products { get; set; } = new List<Product>();
        private List<Automobile> autos { get; set; } = new List<Automobile>();
        private List<Home> homes { get; set; } = new List<Home>();

        public void Add(Product product) // polimorfizm kullanıldığı yer !!!!
        {
            if (product != null)
            {
                products.Add(product);
            }
        }
        public void ProductAddListed(Product product) 
        {
            try
            {
                if (product != null)
                {
                    products.Add(product);
                    foreach (var i in products)
                    {
                        Console.WriteLine(i.Id + " " + i.Name +
                           " " + i.Description + " " + i.Price + " " +
                           i.Location + " " + i.IsSale);
                    }
                }
                else
                {
                    Console.WriteLine("Null değer girilmez..");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Automobile Ekleme ve listeleme
        public void AutoAddListed(Automobile auto)
        {
            try
            {
                if (auto != null && auto.Year > 1900 && auto.Year < 2024 && auto.Km > 0)
                {
                    autos.Add(auto);
                    foreach (var i in autos)
                    {
                        Console.WriteLine(i.Id + " " + i.Name +
                            " " + i.Description + " " + i.Price + " " +
                            i.Location + " " + i.IsSale + " " + i.Year +
                            " " + i.Brand + " " + i.Km);
                    }

                }
                else
                {
                    Console.WriteLine("Yıl ve Km değerleri yanlış girdiniz..");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void HomeAddListed(Home home)
        {
            try
            {
                // evin kat kontrolü
                if (home != null && home.FoundFloor < 100 && home.FoundFloor > -10)
                {
                    homes.Add(home);
                    foreach (var i in homes)
                    {
                        Console.WriteLine(i.Id + " " + i.Name +
                            " " + i.Description + " " + i.Price + " " +
                            i.Location + " " + i.IsSale + " " + i.RoomCount.ToString() +
                            " " + i.FoundFloor);
                    }

                }
                else
                {
                    Console.WriteLine("Kat Sayısı 100 den büyük ve -10 dan küçük olamaz..");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public double TotalPrice()
        {
            try
            {
                double totalPrice = 0;
                foreach (Product product in products)
                {
                    totalPrice += product.Price;

                }
                return totalPrice;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public double TotalPriceWidthCommission()
        {
            try
            {
                double totalPrice = 0;
                foreach (Product product in products)
                {
                    totalPrice += product.Commission();

                }
                return totalPrice;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> GetProducts()
        {
            try
            {
                return products;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void FileWriter(Product p)
        {try
            {
                if (p != null)
                {
                    string path = null;
                    path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string filePath = Path.Combine(path, "savefile.txt");
                    var jsonstring = JsonConvert.SerializeObject(p);
                    FileStream fs = new FileStream(filePath, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(jsonstring);
                    sw.Close();
                    Console.WriteLine("Ürün Kayıt EKLENDİ...");
                }
                else
                {
                    Console.WriteLine("EKLEME HATASI : Ürün Boş değer verilemez...");
                }
            }
            catch (Exception) { throw; }
        }
        public void FileWriter(Automobile a)
        {try
            {
                if (a != null && a.Year > 1900 && a.Year < 2024 && a.Km > 0)
                {
                    string path = null;
                    path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string filePath = Path.Combine(path, "savefile.txt");
                    var jsonstring = JsonConvert.SerializeObject(a);
                    FileStream fs = new FileStream(filePath, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(jsonstring);
                    sw.Close();
                    Console.WriteLine("Otomobil Kayıt EKLENDİ...");
                }
                else
                {
                    Console.WriteLine("EKLEME HATASI : Yıl ve Km değerleri yanlış girdiniz..");
                }
            }
            catch (Exception) { throw; }
        }
        public void FileWriter(Home h)
        {try
            {
                if (h != null && h.FoundFloor < 100 && h.FoundFloor > -10)
                {
                    string path = null;
                    path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string filePath = Path.Combine(path, "savefile.txt");
                    var jsonstring = JsonConvert.SerializeObject(h);
                    FileStream fs = new FileStream(filePath, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(jsonstring);
                    sw.Close();
                    Console.WriteLine("Ev Kayıt EKLENDİ...");
                }
                else
                {
                    Console.WriteLine("EKLEME HATASI : Kat Sayısı 100 den büyük ve -10 dan küçük olamaz..");
                }
            }
            catch (Exception) { throw; }
        }
 

    }
}

