using System;

public class Program
{
    static void Main(string[] args)
    {
        // Dizi Tanımlama

        //int[] dizi = new int[25];
        //bool[] dizi1 = new bool[10];

        //int[] dizi2;
        //dizi2 = new int[20];

        // Diziye Değer Atama

        //int[] strDizi = new int[3];
        //strDizi[0] = 5;     // değer atama
        //strDizi[1] = 7;
        //strDizi[2] = 10;
        //Console.WriteLine("Değer : " + strDizi[2]);     // Değer okuma

        // String Dizi Oluşturma

        //string[] sDizi = new string[5];
        //sDizi[0] = "C";
        //sDizi[1] = "i";
        //sDizi[2] = "h";
        //sDizi[3] = "a";
        //sDizi[4] = "n";

        //Console.WriteLine(sDizi);
        //foreach (var s in sDizi)
        //{
        //    Console.Write(s);
        //}

        // Dizi Oluştururken Değer Atamak

        //float[] fDizi = new float[3];
        //float[] fDizi = { 2.3F, 5.6F };
        //string[] fString = { "ali", "ata", "bak" };
        //string[] fString2 = new string[] { "ali", "ata", "bak" };
        //int[] iDizi = new int[] { 3, 2, 4, 55, 654 };
        //int[] iDizi2 = { 3, 2, 4, 55, 654 };

        //for (int i = 0; i < fString.Length; i++)
        //{
        //    Console.Write(fString[i] + " ");
        //}

        //string website = "cihanozhan.com";
        //for (int i = 0; i < website.Length; i++)
        //{
        //    Console.WriteLine(website[i]);
        //}

        //
        //int[] d1, d2, d3;
        //int[] d1, d2 = new int[3], d3;
        //d2[0] = 2;
        //d1[0] = 2;      // hata!

        #region Örnek

        //string[] sehirler = new string[3];
        //sehirler[0] = "İstanbul";
        //sehirler[1] = "Ankara";
        //sehirler[2] = "Adana";
        ////Console.WriteLine(sehirler[2]);

        //
        //for (int i = 0; i < sehirler.Length; i++)
        //{
        //    //Console.WriteLine(sehirler[0]);
        //    for (int j = 0; j < sehirler[i].Length; j++)
        //    {
        //        Console.WriteLine(sehirler[i][j]);
        //    }
        //    Console.WriteLine(" ");
        //}

        //
        //for (int i = 0; i < sehirler.Length; i++)
        //{
        //    if (sehirler[i] == "Ankara")
        //    {
        //        Console.WriteLine(sehirler[i] + " ili içerisinde dönülüyor...");
        //        for (int j = 0; j < sehirler[i].Length; j++)
        //        {
        //            if (j == 3)
        //            {
        //                Console.WriteLine("Aranan kan bulundu : " + sehirler[i][j]);
        //            }
        //        }
        //    }
        //}

        #endregion

        // Dinamik Dizi

        //Console.Write("Eleman Sayısı : ");
        //int sayi = Convert.ToInt32(Console.ReadLine());
        //int[] dizi = new int[sayi];
        //// Kullanıcıya veri tipini de seçtir. Sonra kaç elemanlı bir dizi istediğini sor.

        //for (int i = 0; i < dizi.Length; i++)
        //{
        //    Console.Write(dizi[i]);
        //}

        #region Örnek

        // Bir dizi oluşturun ve dizinin her indeksine bir önceki indeksin ikiyle çarpımını yazın.

        //int[] values = new int[3];
        //values[0] = 5;
        //values[1] = values[0] * 2;
        //values[2] = values[1] * 2;
        //Console.WriteLine(values[2]);

        //   ALGORİTMA DİZİNİN ELEMANI BİR  SONRAKİNİN 2 KATI 
        int[] values = new int[3];
        values[0] = 5;
        for (int i = 1; i < values.Length; i++)
        {
            values[i] = values[i - 1] * 2;
        }
        Console.WriteLine(values[2]);
        Console.ReadKey();

        //int[] values = new int[3];
        //values[0] = 5;
        //for (int i = 0; i < values.Length-1; i++)
        //{
        //    values[i + 1] = values[i] * 2;
        //}
        //Console.WriteLine(values[2]);

        #endregion

        #region Dizi Özellikleri ve Metotları

        // Length: Bu metot, dizideki toplam eleman sayısını döndürür.

        //string[] isimler = new string[40];
        //Console.WriteLine(isimler.Length);

        // Clear: Bu metot, içine parametreler alarak, dizinin belirtilen alanındaki değerleri temizler. 
        // İlk parametre, dizinin kendisidir. 
        // İkinci parametre, silme işleminin dizinin hangi indeks’inden başlayarak gerçekleştirileceğidir. 
        // Üçüncü parametre toplamda kaç eleman silineceğinin belirtildiği alandır. 
        // İkinci ve üçüncü parametreler tamsayı(int) olarak atanmalıdır.

        //int[] dizi = { 50, 63, 64, 75 };
        ////1. elemandan itibaren (63) siler
        //Array.Clear(dizi, 1, 2);
        //// Dizideki tüm elemanları siler
        //Array.Clear(dizi, 0, dizi.Length);

        // Reverse: Bu metot, dizi elemanlarının sıralamasını indeks sırasına göre tersine çevirir.

        //string[] harfler = { "A", "B", "C" };
        //Array.Reverse(harfler);
        //Console.WriteLine(harfler[2]);

        // Sort: Bu metot, dizi elemanlarını dizinin tipine bağlı olarak sıralar.
        // Dizi metinsel ise alfabetik olarak, numerik ise rakamların büyüklüğüne göre sıralama yapılır.

        //string[] harfler = { "C", "B", "A" };
        //Array.Sort(harfler);
        //Console.WriteLine(harfler[2]);

        // IndexOf : Bu metot, dizi içindeki bir elemanın indeksini döndürür.

        //decimal[] sonuclar = { 78, 99, 100, 12 };
        //decimal maksimum = 100;
        //Console.WriteLine(Array.IndexOf(sonuclar, maksimum).ToString());
        // Gördüğünüz gibi 100 değerini tutan maksimum değişkeni, sonuclar dizisinin 2. indisinde (3. sırada) olduğu için Array.IndexOf()’un sonucu konsola 2 olarak döndü

        #endregion

        /*
         SONSUZ DÖNGÜ ---   SONSUZ DÖNGÜ 
         
        int result = 1;
        for (; ; )
        {
            Console.WriteLine(result);
            result++;
        }

        */
    }
}