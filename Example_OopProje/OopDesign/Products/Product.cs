using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDesign.Products
{
    public enum Colors
    {
        Black=0, 
        White=1,
        Orange=2,
        Red=3,
        Blue=4, 
        Green=5, 
        Yellow=6

    }

    public enum Sizes
    {
        SmallMax=0,
        Small = 1,
        Medium = 2,
        Big = 3,
        MaxBig = 4,
    

    }


    public class Product:ICategory, IDepartment
    {
        public int product_code { get; set; }
        public string product_name { get; set; }
        public Colors product_color { get; set; }
        public Sizes product_size { get; set; }
        public double product_weight { get; set; }

        // İMPLEMENT
        public int department_code { get; set; }
        public string department_name { get; set; }
        public int category_code { get; set; }
        public string category_name { get; set; }

       public  Product() { }

       public Product(int product_code, string product_name, Colors product_color, Sizes product_size, double product_weight, int department_code, string department_name, int category_code, string category_name)
        {
            this.product_code = product_code;
            this.product_name = product_name;
            this.product_color = product_color;
            this.product_size = product_size;
            this.product_weight = product_weight;
            this.department_code = department_code;
            this.department_name = department_name;
            this.category_code = category_code;
            this.category_name = category_name;
        }
    }
}
