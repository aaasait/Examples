using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProject4
{
    public class Ulke
    {
        public int UlkeId { get; set; }
        public string UlkeAd { get; set; }

        public Ulke(int ulkeId, string ulkeAd)
        {
            UlkeId = ulkeId;
            UlkeAd = ulkeAd;
        }
    }
}
