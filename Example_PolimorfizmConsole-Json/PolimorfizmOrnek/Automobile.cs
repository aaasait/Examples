using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmOrnek
{
    public enum Brand
    {
        Toyota = 1,
        Audi = 2,
        Renault = 3,
        Volkswagen=4,
        Honda=5,
        Cadillac=6,
        Ford=7,
        Buick=8,
        Tesla=9,
        Mercedes=10
      
    }
    class Automobile:Product
    {


        public int Year { get; set; }
        public Brand Brand { get; set; }

        public int Km { get; set; }

        public override double Commission()
        {
            return this.Price * 3.0;

        }

        public Automobile() { }
        public Automobile(
           Brand brand
           )
        {
            switch (brand)
            {
                case Brand.Audi:
                    this.Price = 80000.0;
                    this.IsSale = false;
                    break;
                case Brand.Renault:
                    this.Price = 45000.0;
                    this.IsSale = false;
                    break;
                case Brand.Toyota:
                    this.Price = 57000.0;
                    this.IsSale = false;
                    break;

            }
        }

        public Automobile(
            int id,
            string name,
            string description,
            double price,
            string Location,
            bool IsSale,
            int year,
            Brand brand,
            int km)
        {
            
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;              
            this.Location = Location;
            this.IsSale= IsSale;
            this.Year = year;
            this.Brand = brand;
            this.Km= km;
            
         
        }
       
    }
}
