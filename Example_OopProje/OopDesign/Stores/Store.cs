using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopDesign;

namespace OopDesign.Stores
{
    public class Store : ICity, ICountry
    {
        
        public int store_code { get; set; }
        public string store_name { get; set; }

        public Address store_address { get; set; }
        public string telephone { get; set; }
        public int city_code { get; set; }
        public string city_name { get; set; }
        public double city_population { get; set; }
        public int country_code { get; set; }
        public string country_name { get; set; }
        public double country_population { get; set; }

        public Store() { }

        public Store(int store_code, string store_name, Address store_address, string telephone, int city_code, string city_name, double city_population, int country_code, string country_name, double country_population)
        {
            this.store_code = store_code;
            this.store_name = store_name;
            this.store_address = store_address;
            this.telephone = telephone;
            this.city_code = city_code;
            this.city_name = city_name;
            this.city_population = city_population;
            this.country_code = country_code;
            this.country_name = country_name;
            this.country_population = country_population;
        }


    }
}
