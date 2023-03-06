using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

class Program
{
    /*
        OOP (Object Oriented Programming, Nesne Yönelimli Programlama)

        Methods
        Class
        Namespace
        Nested Class
        Advanced Class
        Interface
        Inheritance
        Çok Biçimlilik 
        Struct
        Static
        Partial
        Virtual/Override
        Abstract
        Sealed
    */
    public static void Main(string[] args)
    {
        //Random sayi = new Random();
        //int no = sayi.Next(1, 50);
        //Console.WriteLine(no);

        //SayHi();
        //Yaz("Hayy!");
        //int result = Topla(10, 3);
        //Console.WriteLine(result);
        //Console.WriteLine(Topla(10, 3));

        //Bosluk();
        //Console.WriteLine("**************");
        //Bosluk();

        //Console.WriteLine(TipeBak(10));

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(Rastgele());
        //}

        //Console.WriteLine(EnBuyuk(548,965));
        //Console.WriteLine(EnBuyuk(548, 465, 154));
        //EnBuyuk(1, 2, 3);
        //EnBuyuk(data: new int[] { 1, 2, 3 });

        //Console.WriteLine(HepisiniTopla(12, 12, 34, 4365, 457, 23, 345, 234));

        KullaniciEkle(
            soyad: "afaf",
            ad: "adada");

        // Named Parameter
        Ayarla(
            setting01: "",
            setting05: "",
            setting02: "",
            setting04: "",
            setting03: "");

        // Optional Parameter
        KullaniciEkleOptional("", "");
        KullaniciEkleOptional("", "", true);

        //
        KullaniciEkleOptional2("", "", y: "");

        // 
        IsValid("cihan@deeplab.co");

        //
        Console.WriteLine(GetAccountName(3));
    }

    static bool IsValid(string email)
    {
        // RegEx (Regular Expression)
        bool isValid = false;
        if (email.Contains("@"))
        {
            isValid = true;
        }
        return isValid;
    }

    static string GetAccountName(int accountId)
    {
        string accountName = string.Empty;
        switch (accountId)
        {
            case 1:
                accountName = "Cihan";
                break;
            case 2:
                accountName = "Hakkı Bulut";
                break;
            case 3:
                accountName = "Murtaza Can";
                break;
            default:
                accountName = "Unknown";
                break;
        }
        return accountName;
    }

    static int Rastgele()
    {
        Random rnd = new Random();
        return rnd.Next(1000, int.MaxValue);
    }

    static int EnBuyuk(int a, int b)
    {
        if (a > b)
            return a;
        return b;
    }

    static int EnBuyuk(int a, int b, int c)
    {
        Console.WriteLine("int,int,int");
        return EnBuyuk(EnBuyuk(a, b), c);
    }

    static int EnBuyuk(params int[] data)
    {
        Console.WriteLine("params : " + data);
        return 0;
    }

    // İsimlendirilmiş Parametreler (Named Parameters)
    static void KullaniciEkle(string ad, string soyad)
    {
        Console.WriteLine("ad, soyad");
    }

    static void KullaniciEkleOptional(string ad, string soyad, bool aktifMi = false)
    {
        Console.WriteLine("ad, soyad, bool");
    }

    static void KullaniciEkleOptional2(string ad, string soyad, string x = "", string y = "")
    {
        Console.WriteLine("ad, soyad, bool");
    }

    static void Ayarla(string setting01, string setting02, string setting03, string setting04, string setting05)
    {
        Console.WriteLine("ad, soyad, bool");
    }

    //static int EnBuyuk(int[] data)
    //{
    //    Console.WriteLine("params : " + data);
    //    return 0;
    //}

    /// <summary>
    /// İstediğim kadar int parametre göndereyim, ve en büyüğü dönsün.
    /// Çözüm : Variadic Parameters (Değişken Sayıda Parametre)
    /// </summary>
    /// <returns></returns>
    static int HepisiniTopla(params int[] sayilar)
    {
        int toplam = 0;
        foreach (var sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam;
    }

    static void SayHi()
    {
        Console.WriteLine("Hi");
    }

    static void Yaz(string txt)
    {
        Console.WriteLine(txt);
    }

    static int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    static Type TipeBak(object obj)
    {
        return obj.GetType();
    }

    static void Bosluk()
    {
        Console.WriteLine(Environment.NewLine);
    }

    static void Bosluk(int bosSatirSayisi)
    {
        for (int i = 1; i <= bosSatirSayisi; i++)
        {
            Console.WriteLine();
        }
    }

    static void Bekle()
    {
        Console.ReadLine();
    }

    static void KullaniciEkle(string ad, string soyad, bool aktifMi = false)
    {

    }
}
