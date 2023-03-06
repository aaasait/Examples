using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // KOD SNİPPET VİSUAL STUDİO (KENDİNİ TAMAMLIYOR - Twkrar eden)
        // TAB-TAB TUŞUANA BASARAK 
        // Bu dilin adı visual c# dır.
        // Console dan main çalıştırma

        /*
        
        #region NOT
        int abc = 0; // kullanım
        double abc2 = new double(); // double sınıfından dolayı(Arada kullan)
        bool abc1=default(bool);
        System.Int32 xxx = 0;
        // Console.WriteLine(ad);
        Console.ReadKey();
        #endregion NOT

        -------------------------------------------------------------

        #region DAİRE ALANI HESAPLAMA
        double radius;
        double area;
        radius = 10.0;
        area = radius * radius * 3.1416;
        Console.WriteLine("alan : " + area); // uzun

        double radius1 = 10.0, area1 = radius1 * radius1 * 3.1416;
        Console.WriteLine("alan1 : " + area1); // Tek satır
        Console.ReadKey();
        #endregion DAİRE ALANI HESAPLAMA

        -------------------------------------------------------------

        decimal amount;
        decimal rate_of_return;
        int years;
        rate_of_return = 0.07M;
        amount = 1000.0M;
        years= 10;
        Console.WriteLine("Original İnvestment $ : "+amount);
        Console.WriteLine("Rate of Return : " + rate_of_return);
        Console.WriteLine("Uver : " + years + " years ");

        Console.ReadKey();

        ------------------------------------------------------------

        decimal price;
        decimal discount;
        decimal discount_price;

        price = 19.95M;
        discount = 0.15M;
        discount_price= price - (discount * price);
        Console.WriteLine("Discounted Price :" + discount_price);

        Console.ReadKey();

        */

        decimal price = 19.95M;
        decimal  discount = 0.15M;
        decimal discount2 = -1.15M;
        decimal result = IndirimHesapla(price, discount);
        decimal result2 = IndirimHesapla2(price, discount2);
        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.ReadKey();
    }

    static decimal IndirimHesapla(decimal price,decimal discount)
    {
        return price - (discount * price);
    }

    static decimal IndirimHesapla2(decimal price, decimal discount)
    {
        if (price>0 && discount>0)
        {
            return price - (discount * price);
        }
        return 0; // null kullanmayın
        // statik metot içinde staik metot kullanılmaz
    }
}