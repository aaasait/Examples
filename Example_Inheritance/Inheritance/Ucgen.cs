using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Ucgen : ikiBoyut
    {
        public string Stil { get; set; }

        public void Goster()
        {
            Console.WriteLine("Stil : "+Stil);
        }

        public void SihirYap()
        {
            Console.WriteLine("BackspaceSiler ");
        }

        public double AlanHesapla() // iki boyuttan inherit edildi
        {
            return (Genislik * Yukseklik) / 2;
        }
    }
}
