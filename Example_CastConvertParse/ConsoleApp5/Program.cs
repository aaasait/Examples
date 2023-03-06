using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // tür dönüşümü: biliçli ve biliçsiz
        // Type Casting
        // Convert Ssınıfı ile dönüşüm
        // Convert işlemi (Cast, Convert, Parse)

        //Büyükten küçüğe

        /*
         
        double d = 12.3;
        Console.WriteLine(d);
        int i =Convert.ToInt32(d);
        Console.WriteLine(i);
        Console.ReadKey();

        // Küçükten nüyüğe

        int i1 = 123456789;
        double d1 = 123456789.1;
        d1 = i1;

        float f = 100.15f;
        int i2 = (int)f;
        int i3 = Convert.ToInt32(f);
        byte ay = Convert.ToByte(Console.ReadLine());
        // readline dan dönen string değeri byte çevirir


        */
        string strNumber = "10";
        string strNumber1 = "10C";
        string strNumber2 = "10,2";
        int i=int.Parse(strNumber); 
        string str=i.GetType().ToString();
        Console.WriteLine(str+"---"+i);
        Console.ReadKey();
        // Reflection (metod listesi dinamik özelllik )
        // gettype nesne tipini verir(Nesnelere erişir. Reflection)
        //------------------------------------
        // int.TryParse()

        //REF - OUT farkı
        int result; //=0
        string strNUMBER = "10K";
        bool oldumu=int.TryParse(strNUMBER, out result);

        Console.WriteLine("sonuc" + result);
        Console.WriteLine("oldumu" + oldumu);
        Console.ReadKey();
    }


}