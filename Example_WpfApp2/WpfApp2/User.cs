﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class User
    {

        public string Name { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }

        // public User() { }

        public User(string name, string country, string status)
        {
            Name = name;
            Country = country;
            Status = status;
        }
    }
}
