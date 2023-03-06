using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSubCategory.Marka
{
    public class Sektorler
    {
        public int SektorId { get; set; }
        public string SektorName { get; set; }



        public Sektorler(int _SektorId, string _SektorName)
        {
            this.SektorId = _SektorId;
            this.SektorName = _SektorName;
        }
    }
}
