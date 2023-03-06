using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSiniflar
{
    internal class Muhendis:Calisan
    {
        public Muhendis()
        {

            Unvan = "mühendis";
        }

        public override double GetSalary()
        {
            throw new NotImplementedException();
        }
    }
}
