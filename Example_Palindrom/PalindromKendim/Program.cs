using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        // PALİNDROM  - 
        /*
         1- kullanıcıdan veri al
         2- veriyi karaktere böl ve dönüştür
         3- kontrol et
         4- sonuç yazdır
         */

        Console.WriteLine("Lütfen kelime giriniz : ");
        string str = Console.ReadLine();
        Console.WriteLine("Girilen kelime : " + str);
        string terskelime = "";

        Console.WriteLine("************************");

        for (int i = str.Length - 1; i >= 0; i--)
        {
            terskelime += str[i];
        }
        Console.WriteLine(terskelime);
        if (terskelime == str)
        {
            Console.WriteLine(str + " Kelimesi PALİNDROM");
        }
        else
        {
            Console.WriteLine(str + " Kelimesi PALİNDROM değillllll");
        }



    }


}
