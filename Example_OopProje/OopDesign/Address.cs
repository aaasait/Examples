using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDesign
{
    public class Address
    {
        public int address_id { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public Address() { }
        public Address(int address_id, string address1, string address2)
        {
            this.address_id = address_id;
            this.address1 = address1;
            this.address2 = address2;
        }
    }
}
