using Business.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.User;

namespace Business.Listed
{
    public static class ListAddress
    {
        public static List<UserAddress> userAddresses = new List<UserAddress>();

        public static void AddUserAddress(UserAddress address)
        {
            userAddresses.Add(address);
        }

        public static List<UserAddress> GetListUserAddress()
        {
            return userAddresses;
        }
    }
}
