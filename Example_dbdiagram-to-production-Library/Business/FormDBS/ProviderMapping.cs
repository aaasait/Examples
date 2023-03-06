using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDB
{
    public class ProviderMapping
    {
        public int id_p { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string GetNames() 
        {
            return Name;
        
        }

        public string GetDescriptions()
        {
            return Description;

        }
    }
}
