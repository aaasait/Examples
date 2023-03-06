using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSubCategory.Marka
{
    public class Markalar1
    {
        public int MarkaId { get; set; }
        public string MarkaName { get; set; }

        public int MarkaSektorId { get; set; }

        public Markalar1(int _MarkaId, string _MarkaName, int _MarkaSektorId)
        {
            this.MarkaId = _MarkaId;
            this.MarkaName = _MarkaName;
            MarkaSektorId = _MarkaSektorId;
        }
    }
}
