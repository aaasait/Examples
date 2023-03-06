using System;

class Program
{
    static void Main(string[] args)
    {


        //Action

        // Geriye değer döndürmeyen metotlar için kullsnılır
        //     Delegate nin geriye değer dönmeyen versiyonudur

        Action<int, string> action = new Action<int, string>(KullaniciBilgi);
        action(10, "Sait Koç");

        // Func  (Frameworkten gelir.)

        // Geriye değer dönebilen bir delegate versiyonudur.

        Func<DateTime, double> func = new Func<DateTime, double>(GetUserAgeAtTime);
        var bDate = new DateTime(1998, 01, 01);
        double DateDiff=func(bDate);
        Console.WriteLine(DateDiff+" Gündür Yaşıyor ");

    }

    static void KullaniciBilgi(int k_id,string adSoyad)
    {
        Console.WriteLine("Kullanıcı Id : "+k_id);
        Console.WriteLine("Kullanıcı Ad-Soyad : " + adSoyad);
    }
    static double GetUserAgeAtTime(DateTime birthDay)
    {

        return (DateTime.Now - birthDay).TotalDays;
    }
}