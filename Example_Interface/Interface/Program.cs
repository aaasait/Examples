using Interface;

class Program
{
    // INterface
    public static void Main(string[] args)
    {
        Kullanici k=new Kullanici();
        var data=k.Getir(122);
        Console.WriteLine(data.Ad+" "+data.Soyad);

        var data2 = k.KullanicilarİGetir();
        foreach (var kul in data2)
        {
            Console.WriteLine(kul.Ad + " " + kul.Soyad);
        }
        Console.ReadKey();

        /*
          using (SqlConnection conn = new SqlConnection())  //Kullanici Sayfasında Dispose metodu kullandık
        {
            conn.open(); // Genelde database bağlantısı için açılır Kendimiz açarız.
        } 


        using (Kullanici kt=new Kullanici())  //Kullanici Sayfasında Dispose metodu kullandık
        {
            dosya.open(); // Genelde database bağlantısı açılır
        }

        */


        /*
        BİR SINIF IDisposable varsa
         * using ifadesi kullanılır otomatik kaynak kapatır performans veri 
         *  void.Dispose();
        using (resource)
        {

        }
        */
    }
}