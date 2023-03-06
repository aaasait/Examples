using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // pi sayısı sabit tanımlama
        // PLACE HOLDER KULLANIMI
        // Console.WriteLine("daire alanı= {0}",alan);
        const double pi = 3.14149;

        double alan, cevre, yarıcap;
        string yariCapGir;
        Console.WriteLine("daire yarıçapı gir :");
        yariCapGir = Console.ReadLine();
        yarıcap=Convert.ToDouble(yariCapGir);
        cevre = 2 * pi * yarıcap;
        alan = pi * Math.Pow(yarıcap, 2);
        Console.WriteLine("daire alanı= {0}",alan);
        Console.WriteLine("daire cevre= {0}",cevre);
        Console.ReadKey();

    }


}