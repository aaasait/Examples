using System;

class Program
{

    static void Main(string[] args)
    {
        
        // Delegate Kullanımı
        Hesap hesap = toplama;
        var x1 = hesap(3, 4);
        Console.WriteLine(x1);

        hesap = carpma;
        var x2 = hesap(5, 6);
        Console.WriteLine(x2);

        Console.WriteLine("----------------");

        Hesap hesap1 = new Hesap(cikarma);
        var x3=hesap1.Invoke(4,3);
        Console.WriteLine(x3);


        Console.ReadKey();
    }
    delegate int Hesap(int x, int y);// metot imzası
    static int toplama(int a, int b)
    {
        return a + b;
    }
    static int carpma(int a, int b)
    {
        return a * b;
    }
    static int bolme(int a, int b)
    {
        return a / b;
    }
    static int cikarma(int a, int b)
    {
        return a - b;
    }
}