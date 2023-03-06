using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormListe
{
    public class Country
    {

        public int Id_Country { get; set; }
        public string Name_Country { get; set; }

      

        public Country(int id_Country, string name_Country)
        {
            this.Id_Country = id_Country;
            this.Name_Country = name_Country;

        }



    }
}
