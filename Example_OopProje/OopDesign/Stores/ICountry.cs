using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDesign.Stores
{
    public interface ICountry
    {
        public int country_code { get; set; }
        public string country_name { get; set; }
        public double country_population { get; set; }

    }
}
