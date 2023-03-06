using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassOrnek
{
    partial class Kargo
    {
        List<Kargo> kargos { set; get; } = new List<Kargo>();  
        private int _kargoId;
        private string _kargoDescription;
        private string _kargoDeliveryPerson;
        private string _kargoDeliveryAddress;
        private double _kargoWeight;
        private string _kargoFollowCode;
        private string _kargoSenderNameSurname;
        private string _kargoSenderIdentityCardNumber;
        private string _kargoSenderPhoneNumber;
        private double _kargoPrice;

       
        public void KargoAdd(Kargo k)
        {
            kargos.Add(k);
            if(k != null)
            {
               
                foreach (var i in kargos)
                {
                    Console.WriteLine(i.KargoId+" "+i.KargoDescription+
                        " "+i.KargoDeliveryPerson+" "+i.KargoDeliveryAddress+
                        " "+i.KargoWeight+" "+i.KargoFollowCode+" "+i.KargoSenderNameSurname+
                        " "+i.KargoSenderIdentityCardNumber+" "+i.KargoSenderPhoneNumber+
                        " "+i.KargoPrice);
                }
            }
            else
            {
                throw new Exception("NULL DEĞER");

            }
            
        }

        public string CargoFollowCode(int size=7)
        {
            char[] cr = "0123456789abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string result = string.Empty;
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                result += cr[r.Next(0, cr.Length - 1)].ToString();
            }
            return result.ToString();
        }
    }
}
