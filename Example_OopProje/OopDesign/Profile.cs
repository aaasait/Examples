using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopDesign.Stores;

namespace OopDesign
{
    public class Profile
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        
        public  Profile() { }
        public Profile(int id, string name, string phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
           
        }

        public virtual void GetContact()
        {
            Console.WriteLine("Name : "+name+" Phone : "+ phone);
        }
    }
}
