using System;
using U = Business.User;

namespace Business.App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            U.User usr = new U.User();
            usr.Firstname = "Murtaza";
            usr.Lastname = "Can";
            usr.Addresses.Add(new U.UserAddress() { AddressLine1 = "Istanbul", Name = "İş" });
            usr.Username = "cihanozhan";
            usr.Password = "secretpwd";

            Console.WriteLine(usr.ToString());
        }
    }
}