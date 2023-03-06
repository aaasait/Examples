using Business.Base;
using Business.Order;
using System;
using System.Collections.Generic;

namespace Business.Basket
{
    public class Basket : IBase, IActivity
    {

        public Basket() 
        {

            this.Items = new List<BasketItem>();
        }

        public int ID { get; set; }
        public int UserID { get; set; }
        public decimal Total { get; set; }
        public List<BasketItem> Items { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
