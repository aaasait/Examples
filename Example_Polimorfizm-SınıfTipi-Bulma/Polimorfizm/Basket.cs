using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    class Basket
    {
        private List<Product> products=new List<Product>();

        public void Add(Product product) // polimorfizm kullanıldığı yer !!!!
        {
            if (product != null)
            {
                products.Add(product);
            }

            // GELEN SINIF TİPİNİ BULMA 
            /* 
             
            v1---YÖNTEM------------

            if(product.GetType()==typeof(Bread))  // GetType Reflectşon kodudur.
            {
                Console.WriteLine("Bread");
            }

            v2---YÖNTEM------------

            if(product is Bread)
            {
              Bread br=(Bread)product;
            
            }

             v3---YÖNTEM------------

            if(product is Bread)
            {
              Bread br=product as Bread;
            
            }

            LİNKLER


            */



        }


        public double TotalPrice()
        {
            double totalPrice= 0;
            foreach (Product product in products)
            {
                totalPrice += product.Price; 

            }
            return totalPrice;
        }
        public double TotalPriceWidthKdv()
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.SetKdv();

            }
            return totalPrice;
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
