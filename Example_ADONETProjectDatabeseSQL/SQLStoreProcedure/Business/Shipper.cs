using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLStoreProcedure.Business
{
    public class Shipper
    {

        public int ShippedID { get; set; }

        public string CompanyName { get; set; }

        public string Phone { get; set; }

        public Shipper() { }
        public Shipper(int shippedID, string companyName, string phone)
        {
            ShippedID = shippedID;
            CompanyName = companyName;
            Phone = phone;
        }
    }
}
