using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmOrnek
{
    public enum Room
    {
        bir = 1,
        iki = 2,
        üç = 3,
        dört=4    
    }

    
    class Home:Product
    {
        public Room RoomCount { get; set; }

        public int FoundFloor { get; set; }

        public override double Commission()
        {
            
            return this.Price*5.0;

        }
        public Home() { }
        public Home(
           Room roomCount
           )
        {
            switch (roomCount)
            {
                case Room.iki:
                    this.Price = 1000000.0;
                    this.IsSale = true;
                    break;
                case Room.bir:
                    this.Price = 3000000.0;
                    this.IsSale = true;
                    break;

            }
        }
       
        public Home(
           int id,
           string name,
           string description,
           double price,
           string Location,
           bool IsSale,
           Room room,
           int fflour)
        {

            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Location = Location;
            this.IsSale = IsSale;
            this.RoomCount= room;
            this.FoundFloor= fflour;


        }
    }
}
