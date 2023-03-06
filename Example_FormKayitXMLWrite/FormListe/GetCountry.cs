using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormListe
{
    public class GetCountry
    {

        public List<Country> Countries= new List<Country>();

        
  

        public void AddCountry(Country c)
        {
            Countries.Add(c);
            //foreach (var i in Countries)
            //{
            //    Console.WriteLine(i.Id_Country+" "+i.Name_Country);
            //}
        }

        public string GetValue(Country c) 
        { 
            return c.Name_Country;
        
        }
    }
}
