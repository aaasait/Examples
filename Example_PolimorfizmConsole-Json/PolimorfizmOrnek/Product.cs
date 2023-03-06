using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmOrnek
{


    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public string Location { get; set; }
        public bool IsSale { get; set; }

        public Product() { }

        public Product(
            int id,
            string name,
            string description,
            double price,
            string Location,
            bool IsSale)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Location = Location;
            this.IsSale = IsSale;
        }
        public virtual double Commission()
        {
            this.Price = (this.Price / 100) * 3;
            return this.Price;

        }
   

    }
}
