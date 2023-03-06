using Business.Base;
using System;
using System.Collections.Generic;

namespace Business.User
{
    public class UserAddress : IBase, IActivity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public string PostalCode { get; set; }
        public Phone Phones { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }

        public UserAddress(int ıD, string name, string addressLine1, string addressLine2, Country country, City city, string postalCode,Phone phones)
        {
            ID = ıD;
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            Country = country;
            City = city;
            PostalCode = postalCode;
            Phones = phones;
          
        }
    }
}
