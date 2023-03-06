using FormSubCategory.Marka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSubCategory.Listeleme
{
    public class ListSektor
    {
        public List<Sektorler> sektorListesi= new List<Sektorler>();

        public void AddSektor(Sektorler s)
        {
            sektorListesi.Add(s);
        }
    }
}
