using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    internal class Product
    {

        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public string ProductName { get; set; }
        public double Price { get; set; }

        // Boş constructor yapıyorsan prop ları dışarıya açar
        // BAZI LİBRARYLER BOŞ İSTER ÇÜNKÜ BİZİM KODUMUZA MÜDAHALE ETMEK İSTEMEZ
        // Polimorfizm BİR NESNENİN BİRDEN FAZLA ŞEKİLDE KULLANIMI
        public Product() { }

        public Product(
            int productId,
            string productCode,
            string productName,
            double price) 
        {
            this.ProductId = productId;
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.Price = price;
        }

        public virtual double SetKdv()
        {
            return this.Price = 1.18;

        }
    }
}
