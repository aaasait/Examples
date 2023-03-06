using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDesign.Stores
{
    public interface ICity
    {
        public int city_code { get; set; }
        public string city_name { get; set; }
        public double city_population { get; set; }
    }
}
