using AbstractSiniflar;
using System;

class Program
{
    static void Main(string[] args)
    {
        Isci isci = new Isci();
        isci.Ad = "ali";
        isci.Soyad = "koç";


        Console.WriteLine(isci.GetFullName());

        Muhendis mh = new Muhendis();
        mh.Ad = "roketatar";       
        mh.Soyad = "sabri";

        Console.WriteLine(mh.GetFullName());

        // ABSTRACT SINIFTAN NESNE ÖRNEĞİ ÜRETİLMEZ AMAC MİRAS ALARAK ÜRETMEK
        //Calisan c = new Calisan();
        //c.Ad = "ad";



    }
}