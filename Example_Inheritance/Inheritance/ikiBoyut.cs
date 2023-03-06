using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ikiBoyut
    {

        public double Genislik { get; set; } // get sete müdahale edilmez
        public double Yukseklik { get; set; }

    
        public void Goster()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Genişlik : " + Genislik);
            builder.Append(Environment.NewLine);
            builder.Append("Yükseklik : " + Yukseklik);
            builder.Append(Environment.NewLine);
            Console.WriteLine(builder.ToString());
        }

        /*
        
        private double x;
        public double X
        {
            get { return x; } // readonly
            set { x = value; } // set-only
        }

        */
    }
}
