using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // VAR KULLANIMI değişkenin tipi sonradan değişmez objede değişir
        // TYPE İNFERENCE

        var isim = "sait".GetType();
        var busayi = 21212;
        var busayi1 = 21212.4M; // F ,M ,D EKLERİNİ KULLAN
        var bubirNesne1 = new Program();
        var bubirNesne2 = new List<string>();

        Console.WriteLine(busayi.GetType());
        Console.ReadKey();

        // OBJECT(Sonradan türü değiştirilebilir güvensizdir(UNSAFE))  - UNBOXING / BOXING

        // REF Aktarılırken ilk değer verilir(ZORUNLU).
        // OUT Aktarılırken ilk değer verilir.
        // ENUM
        // GELİŞMİŞ ENUM
        
    }


}