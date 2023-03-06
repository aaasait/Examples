using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Akış Kontrolü : if ve switch (switch case)

            // 1

            //if (true)
            //    Console.WriteLine("adada");

            // 2

            //bool isValid = true;
            //if (isValid)
            //    Console.WriteLine("Doğru");
            //else
            //    Console.WriteLine("Yanlış"); 
            //    Console.WriteLine("Yanlış mı");     // ?

            // 3

            //bool isValid = true;
            //if (isValid)
            //    Console.WriteLine("Doğru");
            //else
            //{
            //    Console.WriteLine("Yanlış");
            //    Console.WriteLine("Yanlış mı");
            //}
            // ÇIKTI Doğru - Yanlış mı  ->> İKİ TANE OLDUĞUNDA ALTTAKİNİ YAZAR TEK SATIRDA
            // 4

            //int x = 1, y = 3;
            //if (x > y)
            //{

            //}
            //else
            //{

            //}

            // 5

            //int x = 1, y = 3;
            //if (x <= y)
            //{

            //}
            //else if (x == y)
            //{

            //}
            //else if (x >= y)
            //{

            //}
            //else
            //{

            //}

            // 6

            //if (true)
            //{
            //    if (true)
            //    {
            //        if (true)
            //        {

            //        }
            //    }
            //}
            //else
            //{

            //}

            // 7

            //int sayi1 = 8, sayi2 = 9, sonuc = 0;
            //if (sayi1 < sayi2)
            //{
            //    sayi1++;
            //    //sonuc = sayi1++;
            //    Console.WriteLine("Küçüktür.");
            //}
            //else if (sayi1 == sayi2)
            //{
            //    Console.WriteLine("Eşittir.");
            //}
            //else
            //{
            //    sonuc = sayi1 + sayi2;
            //    Console.WriteLine("Büyüktür.");
            //}
            //Console.WriteLine("Sonuç : " + sonuc);

            // 8

            byte ay = Convert.ToByte(Console.ReadLine());

            if (ay == 1)
                Console.WriteLine("Ocak");
            else if (ay == 2)
                Console.WriteLine("Şubat");
            else if (ay == 3)
                Console.WriteLine("Mart");
            else if (ay == 4)
                Console.WriteLine("Nisan");
            else if (ay == 5)
                Console.WriteLine("Mayıs");
            else if (ay == 6)
                Console.WriteLine("Haziran");
            else if (ay == 7)
                Console.WriteLine("Temmuz");
            else if (ay == 8)
                Console.WriteLine("Ağustos");
            else if (ay == 9)
                Console.WriteLine("Eylül");
            else if (ay == 10)
                Console.WriteLine("Ekim");
            else if (ay == 11)
                Console.WriteLine("Kasım");
            else if (ay == 12)
                Console.WriteLine("Aralık");
            else
                Console.WriteLine("1-12 arası sayı girmelisiniz");

            Console.ReadKey();
        }
    }
}