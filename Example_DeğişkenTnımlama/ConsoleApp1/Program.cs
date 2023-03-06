using System;

class Program
{
    static void Main(string[] args)
    {
        // TEST KODU VE AÇIKLMA SATIRI HER YAZILIM İÇİN
        // Açıklma satırı cümlesinin sonuna nokta koy

        /*   
         <summary>
         </summary>

       /// ile otomatik açılır <param name="args></param>

        
         */
        // Crtl K+C  K+U AÇIKLAMA SATURU AÇ KAPAT
        #region Burası önemli Arastır NOT KISALTMA
        Console.WriteLine("dd");
        #endregion if - else Region arastır
        int abc;
        int x = new int(); // başlangıç değeri kendisi verir(otomatik 0)
        int yas = 234455433;
        // int? yas1 = Result();Result null olabilir int? konur
        // Yorum satırı
        int s = 1, y = 4;
        double d1 = 1.2D;
        float f1 = 1.3F;
        decimal dec1 = 4.1M;
        char ch= 'A';
        char chs = (char)54;     
        string ad = "ad";
        Console.WriteLine(d1);
        Console.WriteLine(f1);
        Console.WriteLine(dec1);
        Console.WriteLine(x+s+y);
        Console.WriteLine(chs);

        Console.WriteLine(ad);
        Console.ReadKey();
    }
}