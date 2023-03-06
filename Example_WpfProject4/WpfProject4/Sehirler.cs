using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProject4
{
    public class Sehirler
    {
        public int SehirID { get; set; }
        public string SehirAd { get; set; }
        

        public Sehirler(int sehirID, string sehirAd)
        {
            SehirID = sehirID;
            SehirAd = sehirAd;
        }
    }
}
