using FormSubCategory.Marka;
using FormSubCategory.Sektor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace FormSubCategory.Listeleme
{
    public class ListMarka
    {
        public List<Markalar> markaListesi = new List<Markalar>();
        public List<Markalar1> markaListesi1 = new List<Markalar1>();

        
        
      
        public void AddMarka(Markalar m)
        {
            markaListesi.Add(m);
        }
        public void AddMarka1(Markalar1 m)
        {
            markaListesi1.Add(m);
        }

        int sektorId;
        public int GetMarkaSectorId()
        {
            foreach (var get_sektorId in markaListesi)
            {
                sektorId = get_sektorId.MarkaSektorId;
            }
            return sektorId;
        }

        string marka;
        public string GetMarkaName()
        {
            foreach (var get_MarkaName in markaListesi)
            {
                marka = get_MarkaName.MarkaName;
            }
            return marka;
        }

        int markaId;
       
        public int GetMarkaId()
        {

            foreach (var get_MarkaId in markaListesi)
            {
                markaId = get_MarkaId.MarkaId;
            }
           
            return markaId;
        }



    }
}
