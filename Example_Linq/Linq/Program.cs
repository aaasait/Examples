using Linq;
using System;
using System.Collections.Generic;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        #region Data
        List<Ogrenci> Ogrenciler = new List<Ogrenci>() {
        new Ogrenci{Id=1,Ad="Omer",Soyad="Can",DogumTarih=new DateTime(1997,6,11)},
        new Ogrenci{Id=2,Ad="Bahtiyar",Soyad="Şahin",DogumTarih=new DateTime(199,7,1)},
        new Ogrenci{Id=3,Ad="Kerin",Soyad="Cemtek",DogumTarih=new DateTime(1959,8,21)},
        new Ogrenci{Id=4,Ad="Nurettin",Soyad="Narin",DogumTarih=new DateTime(1986,7,18)},
        new Ogrenci{Id=5,Ad="Seyfi",Soyad="Kartepe",DogumTarih=new DateTime(1995,3,15)},
        new Ogrenci{Id=6,Ad="Mithat",Soyad="Uzun",DogumTarih=new DateTime(1977,11,21)},
        new Ogrenci{Id=7,Ad="Bekir",Soyad="Gezmez",DogumTarih=new DateTime(1989,5,11)},
        new Ogrenci{Id=8,Ad="Alperen",Soyad="Tokcuoglu",DogumTarih=new DateTime(1992,5,10)},
        new Ogrenci{Id=9,Ad="Elif",Soyad="Sezer",DogumTarih=new DateTime(1980,6,11)},
        new Ogrenci{Id=10,Ad="Murtaza",Soyad="Ateş",DogumTarih=new DateTime(1999,4,12)}
        };

        #endregion

        // id 4 ten büyük olanlar
        #region SQL

        // select * from where id>4
        #endregion

        #region C#
        List<Ogrenci> ogrList = new List<Ogrenci>(); 
        foreach (var ogr in Ogrenciler)
        {
            if (ogr.Id > 4)
            {
               ogrList.Add(ogr);

            }
        }

        foreach (var item in ogrList)
        {
            Console.WriteLine(item.Ad+" "+item.Soyad);
        }

        #endregion

        Console.WriteLine("---------------------");
        #region Linq

        var q =from x in Ogrenciler
               where x.Id > 4
               select x;
        foreach (var item in q)
        {
            Console.WriteLine(item.Ad);
        }

        #endregion

        Console.WriteLine("*************************");

        #region Lambda Expression

        var ql=Ogrenciler.Where(x=> x.Id > 4);
        foreach (var item in ql)
        {
            Console.WriteLine(item.Ad);
        }
        #endregion

        // IQueryable - IEnumerable   Kendin oluşturmaya çalış <where> gibi 


        #region Adının ilk harfi m olan M olan öğrenciler

        // var qx=Ogrenciler.Where(x => x.Ad[0] == 'M');
        // var qx = Ogrenciler.Where(ogr => ogr.Ad.StartsWith("M"));
        //  var qx = Ogrenciler.Where(ogr => ogr.Ad.Substring(0,1).ToUpper()=="M");
        //foreach (var item in qx)
        //{
        //    Console.WriteLine(item.Ad+" "+item.Soyad);
        //}
        //Console.WriteLine("------------------------");
        //List<Ogrenci> ogrListe = new List<Ogrenci>();

        //for (int i = 0; i < Ogrenciler.Count; i++)
        //{
        //    if(Ogrenciler[i].Ad[0] == 'M')
        //    {
        //        ogrListe.Add(Ogrenciler[i]);
        //    }
        //}
        //foreach (var item in ogrListe)
        //{
        //    Console.WriteLine(item.Ad+" "+item.Soyad);
        //}


        #endregion


        #region Adının son harfi t olan ogrenciler

        //var qd = Ogrenciler.Where(ogr=>ogr.Soyad.EndsWith("t"));
        //var qd = Ogrenciler.Where(x => x.Soyad[x.Soyad.Length-1]=='t');
        //var qd = Ogrenciler.Where(x => x.Soyad.Substring(x.Soyad.Length-1,1).ToLower()=="t");

        #endregion

        Console.WriteLine("======================");

        #region YAŞI 27 DEN KÜCÜK ÖĞRENCİLER
        //DateTime dtnow= DateTime.Now;
        //var qs = Ogrenciler.Where(x => (dtnow.Year - x.DogumTarih.Year) < 27);
        //var qs = Ogrenciler.Where(x => ((dtnow - x.DogumTarih).TotalDays / 365) < 36);


        //foreach (var item in qs)
        //{
        //    Console.WriteLine(item.Ad+" "+item.Soyad);
        //}

        #endregion

        #region Pazartesi günü doğan öğrenciler
        //DateTime dtnow = DateTime.Now;
        //var qs = Ogrenciler.Where(x => (x.DogumTarih.DayOfWeek==DayOfWeek.Monday));

        // hem adı a ile başlasın hemde pazartesi doğmuş olan

        //var qs = Ogrenciler.Where(x => (x.DogumTarih.DayOfWeek == DayOfWeek.Monday) && x.Ad.StartsWith("A"));


        //foreach (var item in qs)
        //{
        //    Console.WriteLine(item.Ad + " " + item.Soyad);
        //}

        #endregion

        #region ID si 4 ten küçük olanlar Takma ad ve birleştirme

        // Console.WriteLine("=*-*-*-*-*-*-*-*-*-*-*-");


        //var qs1 = Ogrenciler.Select(x =>
        //                              new
        //                              {
        //                                  No = x.Id,
        //                                  AdSoyad=x.Ad+" "+x.Soyad
        //                              }); ;

        //foreach (var item in qs1)
        //{
        //    Console.WriteLine(item.AdSoyad);
        //}

        // lınq  select
        // Anonim Nesneler (Anonumous Object)
        #endregion

        #region ID->No / Ad ve Soyad->AdSoyad (Birleştirme ve Atame) Yeni sınıf oluşturuldu OgrDemo IEnumerable kullanılarak  ve Liste oluşturularak

        Console.WriteLine("=*-*-*-*-*-*-*-*-*-*-*-");

        //List<OgrDemo> list = Ogrenciler.Select(x => new OgrDemo(x.Id,x.Ad + " " + x.Soyad)).ToList();
        //List<OgrDemo> list = Ogrenciler.Select(x => new OgrDemo(x.Id, x.Ad + " " + x.Soyad)).ToList<OgrDemo>();
        IEnumerable<OgrDemo> lst = Ogrenciler.Select(x => new OgrDemo(x.Id, x.Ad + "  " + x.Soyad));
        foreach (var item in lst)
        {
            Console.WriteLine(item.AdSoyad);
        }

        #endregion
    }
}

public class OgrDemo
{
    public int No { get; set; }

    public string AdSoyad { get; set; }

    public OgrDemo() { }

    public OgrDemo(int no, string adSoyad)
    {
        No = no;
        AdSoyad = adSoyad;
    }
}