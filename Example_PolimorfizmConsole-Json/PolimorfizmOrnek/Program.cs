
using PolimorfizmOrnek;
using System.Net;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System;

class Program
{
    static void isd(bool b)
    {
        if (b == true)
            Console.WriteLine("Satılık");
        else
            Console.WriteLine("Kiralık");

    }

    static void Main(string[] args)
    {
        Product p = new Product();
        Calculate cl = new Calculate();
        //Automobile au = new Automobile(Brand.Audi);
        //Automobile au1 = new Automobile(Brand.Toyota);
        //Home hm = new Home(Room.ucartibir);
        //Home hm1 = new Home(Room.ikiartibir);


        while (true)
        {
            Console.WriteLine("********OTOMOBİL ve EMLAK Uygulamasına Hoşgeldiniz.........");
            Console.WriteLine("ISLEM LİSTESI\n" +
                "1) Ev Ekle\n" +
                "2) Ev Listele\n" +
                "3) Araba Ekle\n" +
                "4) Araba Listele\n" +
                "5) Ürün Ekle\n" +
                "6) Ürün Listele\n");
            Console.WriteLine("İşlem Yapmak İstiyor musunuz (e/h) : ");
            string islemOnay = Console.ReadLine();
            string islemOnaayTrim = islemOnay.Trim();
            string convertIslemOnay = islemOnaayTrim.ToLower();

            if (convertIslemOnay.Equals("e"))
            {
                Console.WriteLine("Lütfen numara girin(1/2/3/4/5/6) : ");
                int secenek = Convert.ToInt32(Console.ReadLine());

                switch (secenek)
                {

                    case 1:
                        HomeAdds();
                        break;
                    case 2:
                        HomeList();
                        break;
                    case 3:
                        AutoAdds();
                        break;
                    case 4:
                        AutoList();
                        break;
                    case 5:
                        UrunAdds();
                        break;
                    case 6:
                        UrunList();
                        break;
                    default:
                        Console.WriteLine("Anasayfaya Yönlendiriliyor..");
                        break;
                }
            }
            else if (convertIslemOnay.Equals("h"))
            {
                Console.WriteLine("Çıkış...");
                break;
            }
            else
            {
                Console.WriteLine("Çıkış...");
                break;
            }



        }


        /*

        Console.WriteLine("Year : ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Brand : ");
        string brands = Console.ReadLine();
        Brand brand = BrandControl(brands); // Öarka kontrolü

        Console.WriteLine("Km : ");
        int km = Convert.ToInt32(Console.ReadLine());

        // Ürüne değer Atama
        Product productx = new Product(id, name, description, price, location, boole);
        cl.ProductAddListed(productx);// Ürün Listeleme
        cl.FileWriter(productx); // Ürün Kayıt Ekleme

        Automobile autox = new Automobile(id, name, description, price, location, boole,year,brand,km);
        cl.AutoAddListed(autox);
        cl.FileWriter(autox);

        */

        //cl.AutoAddListed(au.Id=1,au.Name="full paket temiz",au.Description="bakiöi yeni",au.Price=150000.0,au.Location="Istanbul",au.IsSale=true,au.Year=2013,Brand.Toyota,au.Km=100525);
        //Automobile autoc = new Automobile(44, "original", "bakim", 999500.0, "Mersin", false, 2008, Brand.Toyota, 100525);
        //Automobile autox = new Automobile(44, "sifir", "bak", 777600.0, "Elazig", false, 2018, Brand.Audi, 100525);

        //cl.AutoAddListed(autoc); // Ekranda araba üretilen araba nesnesini listeler
        //cl.AutoAddListed(autox);

        //cl.FileWriter(autoc);
        //cl.FileWriter(autox);

        //Home homec = new Home(75, "Yeni bina", "aidatli", 1150500.0, "Denizli", false, Room.birartibir, 5);
        //Home homex = new Home(39, "komple bina", "kombili", 2150500.0, "Giresun", false, Room.ikiartibir, 35);

        //cl.HomeAddListed(homec);
        //cl.HomeAddListed(homex);

        //cl.FileWriter(homec);
        //cl.FileWriter(homex);

        //var serilizedObject= Newtonsoft.Json.JsonConvert.SerializeObject(autoc);
        // JSON FORMAT YAZMA
        //var serilizedObject = Newtonsoft.Json.JsonConvert.SerializeObject(autoc,Newtonsoft.Json.Formatting.Indented);


        /*
        cl.Listed(au1);
        Console.WriteLine("*****************************");
        Console.WriteLine(au.IsSale);
        Console.WriteLine("Toplam KOMİSYON HARİÇ : " + cl.TotalPrice());
        Console.WriteLine("Toplam KOMİSYON DAHİL : " + cl.TotalPriceWidthCommission());
        Console.WriteLine("Sipariş Toplamı : " + (cl.TotalPriceWidthCommission() - cl.TotalPrice()));
        Console.WriteLine("*****************************");
      
        Console.WriteLine("Toplam KOMİSYON HARİÇ : " + cl.TotalPrice());
        Console.WriteLine("Toplam KOMİSYON DAHİL : " + cl.TotalPriceWidthCommission());
        Console.WriteLine("Sipariş Toplamı : " + (cl.TotalPriceWidthCommission() - cl.TotalPrice()));

        Console.WriteLine("*****************************");

        Console.WriteLine("Toplam KOMİSYON HARİÇ : " + cl.TotalPrice());
        Console.WriteLine("Toplam KOMİSYON DAHİL : " + cl.TotalPriceWidthCommission());
        Console.WriteLine("Sipariş Toplamı : " + (cl.TotalPriceWidthCommission() - cl.TotalPrice()));
        */

        Console.ReadKey();
    }

    public static void UrunList()
    {
        Console.WriteLine("ID : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Description : ");
        string description = Console.ReadLine();
        Console.WriteLine("Price : ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Location : ");
        string location = Console.ReadLine();

        Console.WriteLine("Is Sale(True/False) : ");
        string isSale = Console.ReadLine();
        bool boole = BoolControl(isSale);// Bool konrol metodu
        Calculate cl = new Calculate();
        Product productx = new Product(id, name, description, price, location, boole);
        cl.ProductAddListed(productx);// Ürün Listeleme

    }

    public static void UrunAdds()
    {
        Console.WriteLine("ID : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Description : ");
        string description = Console.ReadLine();
        Console.WriteLine("Price : ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Location : ");
        string location = Console.ReadLine();

        Console.WriteLine("Is Sale(True/False) : ");
        string isSale = Console.ReadLine();
        bool boole = BoolControl(isSale);// Bool konrol metodu
        Calculate cl = new Calculate();
        Product productx = new Product(id, name, description, price, location, boole);
        cl.FileWriter(productx);// Ürün Dosyaya Yazdırma

    }

    public static void AutoList()
    {
        Console.WriteLine("ID : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Description : ");
        string description = Console.ReadLine();
        Console.WriteLine("Price : ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Location : ");
        string location = Console.ReadLine();

        Console.WriteLine("Is Sale(True/False) : ");
        string isSale = Console.ReadLine();
        bool boole = BoolControl(isSale);// Bool konrol metodu

        Console.WriteLine("Year : ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Brand : ");
        string brands = Console.ReadLine();
        Brand brand = BrandControl(brands); // Öarka kontrolü

        Console.WriteLine("Km : ");
        int km = Convert.ToInt32(Console.ReadLine());

        Calculate cl = new Calculate();
        Automobile autox = new Automobile(id, name, description, price, location, boole, year, brand, km);
        cl.AutoAddListed(autox);


    }
    public static void AutoAdds()
    {
        Console.WriteLine("ID : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Description : ");
        string description = Console.ReadLine();
        Console.WriteLine("Price : ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Location : ");
        string location = Console.ReadLine();

        Console.WriteLine("Is Sale(True/False) : ");
        string isSale = Console.ReadLine();
        bool boole = BoolControl(isSale);// Bool konrol metodu

        Console.WriteLine("Year : ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Brand : ");
        string brands = Console.ReadLine();
        Brand brand = BrandControl(brands); // Öarka kontrolü

        Console.WriteLine("Km : ");
        int km = Convert.ToInt32(Console.ReadLine());

        Calculate cl = new Calculate();
        Automobile autox = new Automobile(id, name, description, price, location, boole, year, brand, km);
        cl.FileWriter(autox);

    }

    public static void HomeList()
    {
        Console.WriteLine("ID : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Description : ");
        string description = Console.ReadLine();
        Console.WriteLine("Price : ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Location : ");
        string location = Console.ReadLine();

        Console.WriteLine("Is Sale(True/False) : ");
        string isSale = Console.ReadLine();
        bool boole = BoolControl(isSale);// Bool konrol metodu

        
        Console.WriteLine("Room : ");
        string rooms = Console.ReadLine();
        Room room = RoomControl(rooms); // ODA kontrolü

        Console.WriteLine("Found Floor : ");
        int foundFloor = Convert.ToInt32(Console.ReadLine());

        Calculate cls = new Calculate();
        Home homex = new Home(id, name, description, price, location, boole, room, foundFloor);
        cls.HomeAddListed(homex);


    }
    public static void HomeAdds()
    {
        Console.WriteLine("ID : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Description : ");
        string description = Console.ReadLine();
        Console.WriteLine("Price : ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Location : ");
        string location = Console.ReadLine();

        Console.WriteLine("Is Sale(True/False) : ");
        string isSale = Console.ReadLine();
        bool boole = BoolControl(isSale);// Bool konrol metodu


        Console.WriteLine("Room : ");
        string rooms = Console.ReadLine();
        Room room = RoomControl(rooms); // ODA kontrolü

        Console.WriteLine("Found Floor : ");
        int foundFloor = Convert.ToInt32(Console.ReadLine());

        Calculate cls = new Calculate();
        Home homex = new Home(id, name, description, price, location, boole, room, foundFloor);
        cls.FileWriter(homex);


    }
    public static Room RoomControl(string h)
    {
        Room rms = new Room();
        Home hm = new Home();
        string trimH = h.Trim();
        string convertH = trimH.ToLower();

        if (convertH.Equals("bir")) // 1
        {
            rms = Room.bir;
        }
        else if (convertH.Equals("iki")) // 2 
        {
            rms = Room.iki;
        }
        else if (convertH.Equals("üç")) // 3
        {
            rms = Room.üç;
        }
        else if (convertH.Equals("dört")) // 4
        {
            rms = Room.dört;
        }
        else
        {
            Console.WriteLine("Hatali Oda Girişi....");
        }
        return rms;

    }


    public static bool BoolControl(string s)
    {
        string trimIsSale = s.Trim();
        string convertIsSale = trimIsSale.ToLower();
        bool b = false;
        if (convertIsSale.Equals("true"))
        {
            b = true;
        }
        else if (convertIsSale.Equals("true"))
        {
            b = false;
        }
        return b;

    }

    public static Brand BrandControl(string s)
    {
        Brand brs = new Brand();
        Automobile a= new Automobile();
        string trimA=s.Trim();
        string convertA=trimA.ToLower();
        
        if (convertA.Equals("toyota")) // 1
        {
            brs = Brand.Toyota;
        }
        else if (convertA.Equals("audi")) // 2 
        {
            brs = Brand.Audi;
        }
        else if(convertA.Equals("renault")) // 3
        {
            brs = Brand.Renault;
        }
        else if (convertA.Equals("volkswagen")) // 4
        {
            brs = Brand.Volkswagen;
        }
        else if(convertA.Equals("honda")) //5
        {
            brs = Brand.Honda;
        }
        else if (convertA.Equals("Cadillac")) // 6
        {
            brs = Brand.Cadillac;
        }
        else if(convertA.Equals("ford")) // 7
        {
            brs = Brand.Ford;
        }
        else if (convertA.Equals("buick")) // 8
        {
            brs = Brand.Buick;
        }

        else if(convertA.Equals("tesla"))  // 9
        {
            brs = Brand.Tesla;
        }
        else if (convertA.Equals("mercedes")) // 10
        {
            brs = Brand.Mercedes;
        }
        else
        {
            throw new Exception("HATALI MARKA");
        }
        return brs;

    }



}