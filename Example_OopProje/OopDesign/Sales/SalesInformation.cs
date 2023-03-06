using OopDesign.Products;
using OopDesign.Stores;
using OopDesign.Times;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OopDesign.Sales
{
    public class SalesInformation
    {
       

        // add sales 
        List<Sales> sales = new List<Sales>();
        public void AddSales(Sales sale)
        {
           sales.Add(sale);
        }

       


        double sumPrice = 0;
        public void GetSumPrice()
        {         
            foreach (var sum in sales)
            {
                sumPrice += sum.price_sales;
            }

            Console.WriteLine("Total Price "+sumPrice);
        }

        double newPrice = 0;
        public void GetPriceAfter()
        {
            foreach (var sum in sales)
            {
                newPrice += sum.price_sales;
            }

            Console.WriteLine("Total Price " + newPrice);
        }

        public void RemoveSales(int no)
        {

            sales.RemoveAt(no);

            // sales.Remove(new Sales() { ticket_number = no });
            Console.WriteLine("silindi");

        }

        public void GetCount()
        {
            Console.WriteLine("Total Sales Count : "+sales.Count);
        }

        public void ListSales(Sales sale)
        {
            foreach (var s in sales)
            {
                Console.WriteLine("Ticket Number : "+s.ticket_number+
                    " Quantity : "+s.qty_sales+" Price : "+s.price_sales+
                    " Inventory Name : "+s.inventory.inventory_name);
            }
        }
        public void ListSales()
        {
            foreach (var s in sales)
            {
                Console.WriteLine("Ticket Number : " + s.ticket_number +
                    " Quantity : " + s.qty_sales + " Price : " + s.price_sales +
                    " Inventory Name : " + s.inventory.inventory_name);
            }
        }

    }
}
