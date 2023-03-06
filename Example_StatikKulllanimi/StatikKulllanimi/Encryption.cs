using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikKulllanimi
{
    static class Encryption
    {
        //private Encryption() { }

        static Encryption()
        {
            _id = new Random().Next(100, 1000);
        }

        private static int _id;
        public static string Encrypt(string data)
        {
            return data + _id;
        }

        public static string Decrypt(string data)
        {
            return data + _id;
        }
    }
}
