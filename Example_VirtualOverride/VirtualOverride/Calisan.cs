using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    internal class Calisan
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }

        /*
        public double MaasHesapla()
        {
            return 1200;
        }
        */
        public virtual double MaasHesapla()
        {
            return 1.500;

        }
    }
}
