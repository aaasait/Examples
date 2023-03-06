using Business.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Listed
{
    public class ListProvider
    {

        public List<Provider> providers = new List<Provider>();

        public void AddProvider(Provider provider)
        {
            providers.Add(provider);
        }

        Dictionary<int, string> My_dict =new Dictionary<int, string>();
        public List<Provider> GetListProvider()
        {   
            return providers;
        }


    }
}
