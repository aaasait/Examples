using OopDesign.Products;
using OopDesign.Stores;
using OopDesign.Times;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDesign.Sales
{
    public class Sales
    {
        public int ticket_number { get; set; }
        public int qty_sales { get; set; }
        public double price_sales { get; set; }
        public Inventory inventory { get; set; }

        public Sales() { }

        public Sales(int ticket_number, int qty_sales, double price_sales, Inventory inventory)
        {
            this.ticket_number = ticket_number;
            this.qty_sales = qty_sales;
            this.price_sales = price_sales;
            this.inventory = inventory;
        }

        List<Time> times = new List<Time>();      
        List<Product> products = new List<Product>();
        List<Store> stores = new List<Store>();
        public void Add(Product product, Time time, Store store)
        {
            
            stores.Add(store);
            times.Add(time);
            products.Add(product);
        }

        public void Remove(int no)
        {
            stores.RemoveAt(no);
            times.RemoveAt(no);
            products.RemoveAt(no);
        }
        public void ListProduct()
        {
            foreach (var p in products)
            {
                Console.WriteLine("Product Code : " + p.product_code +
                    " Product Name: " + p.product_name + " Department Name : " + p.department_name +
                    " Product Color : " + p.product_color);
            }
        }
        public void ListProduct(Product product)
        {
            foreach (var p in products)
            {
                Console.WriteLine("Product Code : " + p.product_code +
                    " Product Name: " + p.product_name + " Department Name : " + p.department_name +
                    " Product Color : " + p.product_color);
            }
        }

        public void ListTime()
        {
            foreach (var t in times)
            {
                Console.WriteLine("Now Day of Month: " + t.day +
                    " Now Day of Week : " + t.day_number + " Month Number : " + t.month_code +
                    " Year Number : " + t.year_code);
            }
        }

        public void ListTime(Time time)
        {
            foreach (var t in times)
            {
                Console.WriteLine("Now Day of Month: " + t.day +
                    " Now Day of Week : " + t.day_number + " Month Number : " + t.month_code +
                    " Year Number : " + t.year_code);
            }
        }


        public void ListStore()
        {
            foreach (var s in stores)
            {
                Console.WriteLine("Store Code : " + s.store_code +
                    " Store Name : " + s.store_name + " Store Address 1 : " + s.store_address.address1 +
                    " Phone Number : " + s.telephone);
            }
        }

        public void ListStore(Store store)
        {
            foreach (var s in stores)
            {
                Console.WriteLine("Store Code : " + s.store_code +
                    " Store Name : " + s.store_name + " Store Address 2 : " + s.store_address.address2 +
                    " Phone Number : " + s.telephone);
            }
        }
        //public List<Sales> GetSales() { }
        public void Remove(Product product) { }

    }
}
