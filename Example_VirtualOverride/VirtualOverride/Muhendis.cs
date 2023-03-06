using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    internal class Muhendis:Calisan
    {
        public string Tur { get; set; }
        public string Departman { get; set; }

        public override double MaasHesapla() // Sadece Virtual Metod Override Edilir
        {
            return 2.500;

        }

    }
}
