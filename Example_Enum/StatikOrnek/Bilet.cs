using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StatikOrnek
{
    public enum BiletName  // STATİK ENUM HATA VERİYOR This kullanımıda
    {
        KaziKazan = 1,
        SayisalLoto = 2

    }
    static class Bilet
    {
        static public int BiletID { get; set; }
        static public BiletName BBiletName { get; set; }
        static public string BiletName { get; set; }

        static public int BiletNumarasi { get; set; }
        static Bilet()
        {
            _sayi = new Random().Next(1000000, 10000000);
            
        }

        private static int _sayi;
      
        public static int GetNumara()
        {         
            return _sayi;
        }

   



    }
}
