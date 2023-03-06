using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSiniflar
{
    abstract class Calisan
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }

        public double Maas { get; set; }

        public string GetFullName()
        {
            return this.Ad+" "+this.Soyad;
        }

        public abstract double GetSalary(); // Method gibi tanımlanmaz. sadece adı yazılır.

    }
}
