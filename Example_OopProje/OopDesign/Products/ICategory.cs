﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDesign.Products
{
    public interface ICategory
    {
        public int category_code { get; set; }
        public string category_name { get; set;}
    }
}
