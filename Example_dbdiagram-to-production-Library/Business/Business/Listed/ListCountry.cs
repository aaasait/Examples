using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.User;

namespace Business.Listed
{
    public class ListCountry
    {
       public  List<Country> countries= new List<Country>();  
        
        public void AddCountry(Country country)
        {
            countries.Add(country);
        }
    }
}
