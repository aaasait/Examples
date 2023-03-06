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
            /*

            // ++  ve  --

            int x = 1;
            Console.WriteLine(x++); // 1
            Console.WriteLine(++x); //3

            int xx = 1;
            xx = xx + 1;
            xx += 1;
            x++;
            Console.WriteLine(x); // 4
            Console.ReadKey();

            ----------------------------------------------------------

           
             
               == Operatörü    : Eşittir anlamındadır.
               != Operatörü    : Eşit değil (farklı) anlamındadır.
               > Operatörü     : Büyüktür anlamındadır.Bu operatör string işlemlere uygulanmaz.
               < Operatörü     : Küçüktür anlamındadır.Bu operatör string işlemlere uygulanmaz.
               >= Operatörü    : Büyük veya eşit anlamındadır. Bu operatör string işlemlere uygulanmaz.
               <= Operatörü    : Küçük veya eşit anlamındadır.Bu operatör string işlemlere uygulanmaz.
             
            
             veya) operatörleri aritmetik, karşılaştırma ve bitsel operatörlere göre düşük önceliklidir fakat kendi aralarındaki öncelik sıralaması &&(ve), ||(veya) şeklindedir.
                !(değil) operatörü      aritmetik operatörlerden (++)arttırma ve (--)eksiltme operatörleri ile eşit önceliklidir.
           
             &&(ve), !( değil), ||(veya) 

            --------------------------------------------------------------



             */

            // Üçlü Operatör

            //operand1 ? operand2 : operand2

            string mesaj = string.Empty;
            bool aktifMi = true;
            mesaj = aktifMi ? "Evet" : "Hayır";
            //mesaj = aktifMi ? function1() : function2();
            Console.WriteLine("Aktif mi : " + mesaj);

            // Bitsel operatörler

            /*
                Bitsel operatörler &(bitsel ve), ~(bitsel değil), |(bitsel veya), ^(bitsel özel veya) operatörleridir. 
                Sayıların kendileri yerine bitlerini kullanan operatörlerdir.

                &(ve) işlemi karşılıklı basamaklardan her ikisi de 1 ise ilgili basamağında 1 tutar, diğer durumlarda 0 tutar.
                ~(değil) operatörü operandının her basamağını tersleştirip tutar.
                |(veya) işlemi karşılıklı basamaklarından herhangi birisi 1 ise ilgili basamağında 1 tutar, diğer durumlarda 0 tutar.
                ^(özel veya) işlemi karşılıklı basamakları farklıysa ilgili basamağında 1 tutar, diğer durumlarda 0 tutar.
                Bitsel operatörler aritmetik operatörler ve karşılaştırma operatörlerinden düşük önceliklidir fakat bu operatörler aynı satırda olduklarında aralarındaki öncelik sıralaması &(bitsel ve), ^ (bitsel özel veya), |(bitsel veya) şeklindedir.
             */

            /*
                () tür dönüştürme operatörü:    Tür değiştirmek için kullanılan bir operatördür.   (değiştirilecek tür) değişken_yada_sabit
                [] operatörü:                   Dizilerde elemanın dizinini belirtmek için kullanılır.
                + ve – operatörü:               Bir değişkenin pozitif veya negatif olmasını sağlar. Ayrıca + operatörü iki string(katar)’i birleştirmekte de kullanılır. Kullanımı şu şekildedir;
                typeof operatörü:               Herhangi bir değişken türünün CTS (Common Type System - Ortak Tip Sistemi) karşılığını type(tip) olarak tutar.
                sizeof operatörü:               Temel türlerin ve yapıların bellekte ne kadar alan kapladıklarını verir. "sizeof" operatörü sınıflar için kullanılamaz ancak tanımlanacak yapılar için kullanılabilir.
                new operatörü:                  Yeni bir nesne oluşturmak için kullanılan operatörlerdir.
             */




        }
    }
}