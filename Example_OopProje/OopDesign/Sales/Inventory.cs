using OopDesign.Times;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDesign.Sales
{
    public class Inventory
    {
        public int inventory_id { get; set; }

        public string inventory_name { get; set; }

       public Inventory(int _inventory_id,string _inventory_name)
       {
         this.inventory_id = _inventory_id;
         this.inventory_name = _inventory_name;
        
       }

    }
}
