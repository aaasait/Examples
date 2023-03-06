using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopDesign.Stores;
using OopDesign;

namespace OopDesign.Customers
{
    public class Customer:Profile
    {

        List<Address> addresses= new List<Address>();
        public void AddAddress(Address address)
        {
            addresses.Add(address);
        }
        public Customer() 
        {
            this.customer_profile = new Profile();
        }
        public Customer(int customer_id, string customer_name, string customer_surname, Address customer_address, string customer_phone, bool customer_active)
        {
            this.customer_id = customer_id;
            this.customer_profile = new Profile(id, customer_name,customer_phone);
            this.customer_name = customer_name;
            this.customer_surname = customer_surname;
            this.customer_address = customer_address;
            this.customer_phone = customer_phone;
            this.customer_active = customer_active;
        }

        public int customer_id { get; set; }

        public Profile customer_profile { get; set; }
        public string customer_name { get; set; }
        public string customer_surname { get; set; }

        public Address customer_address { get; set; }
        public string customer_phone { get; set; }
        public bool customer_active { get; set; }

        public override void GetContact()
        {
         


                Console.WriteLine("Name : " + customer_name + " Surname : " + customer_surname + " Phone : " + customer_phone);
            
        }
    }
}
