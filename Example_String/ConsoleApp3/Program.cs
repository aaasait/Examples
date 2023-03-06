using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // STRİNG MANUPULATİON - STRİNG BUİLDER DA KULLANILABİLİR
        /*
         * 
        string ad, soyad, mail, fb_profil, sonuc, ayirac = "----";
        ad = "sait";
        soyad = "koc";
        mail = "aks@göail.com";
        fb_profil = "fb.koc";

        // Mtin birleştirme(String Concat)
        sonuc = ayirac + "\n" +
            "AD : " + ad + "\n" +
            "SOYAD : " + soyad + "\n" +
            "MAİL : " + mail + "\n" +
            "FACEBOOK : " + fb_profil + "\n" +
            ayirac;

        -----------------------------------------------------

        // String builder 100 kat daha hızlı

        string ad = "sait";
        string soyad = "koc";
        StringBuilder builder = new StringBuilder();
        builder.Append("Ad : " + ad);
        builder.Append(Environment.NewLine);
        builder.Append("Soyad : " + soyad);
        builder.Append(Environment.NewLine);
        Console.WriteLine(builder.ToString());
        Console.ReadKey();

        ------------------------------------------------------

        string sonuc;
        string ayirac = "-----";
        Console.WriteLine("Ad : ");
        string ad= Console.ReadLine();
        Console.WriteLine("soyad : ");
        string soyad = Console.ReadLine();
        Console.WriteLine("mail : ");
        string mail = Console.ReadLine();
        Console.WriteLine("fb_profil : ");
        string fb_profil = Console.ReadLine();

        sonuc = ayirac + "\n" +
            "AD : " + ad + "\n" +
            "SOYAD : " + soyad + "\n" +
            "MAİL : " + mail + "\n" +
            "FACEBOOK : " + fb_profil + "\n" +
            ayirac;
        Console.WriteLine(sonuc);

        */


        string Empty=string.Empty; // boi değer
        string Empty1 = "";
        string Empty2 = null;

        // Nullable types
        int? num = null;
        decimal? num1 = null;
        bool? num2 = null;
        // var anahtar kelimesi değişken kullanılıyorsa değişkene değer atanır
        // isteniyor ve değeri belli ise aşağıdaki gibi
        var isim = (string)null;

        
        
    }


}