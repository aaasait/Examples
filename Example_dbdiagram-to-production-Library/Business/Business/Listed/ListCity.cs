using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.User;

namespace Business.Listed
{
    public class ListCity
    {

        public  List<City> cities = new List<City>();

        public void AddCity(City city)
        {
            cities.Add(city); 
        }

    }
}
