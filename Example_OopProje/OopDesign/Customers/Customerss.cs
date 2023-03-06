using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDesign.Customers
{
    public  class Customerss
    {
        List<Customer> customers= new List<Customer>();

        public void AddCustomer(Customer cs)
        {
            customers.Add(cs);
        }

        public void ListCustomer(Customer cs)
        {
            foreach (var c in customers)
            {
                Console.WriteLine("Customer Profile Name: "+ c.customer_profile.name+
                     " Surname : "+c.customer_surname+ " Address : "+c.customer_address.address1);
            }
        }

        public void ListCustomer()
        {
            foreach (var c in customers)
            {
                Console.WriteLine("Customer Profile Name: " + c.customer_profile.name +
                     " Surname : " + c.customer_surname + " Address : "+c.customer_address.address2);
            }
        }
    }
}
