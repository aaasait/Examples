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

        Bosluk();
        Console.WriteLine("**************");
        Bosluk();

        Console.WriteLine(TipeBak(10));
        Console.WriteLine(TipeBak("Merhaba"));
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
