using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSubCategory.Sektor
{
    public class Markalar
    {
        public int MarkaId { get; set; }
        public string MarkaName { get; set; }

        public int MarkaSektorId { get; set; }

        public Markalar(int _MarkaId, string _MarkaName, int _MarkaSektorId)
        {
            this.MarkaId = _MarkaId;
            this.MarkaName = _MarkaName;
            MarkaSektorId = _MarkaSektorId;
        }
    }
 
}
