using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Payment;
using Business.User;
namespace Business.Listed
{
    public class ListPhone
    {
        public List<Phone> phones = new List<Phone>();

        public void AddPhone(Phone phone)
        {
            phones.Add(phone);
        }

        public List<Phone> GetListPhone()
        {
            return phones;
        }

    }
}
