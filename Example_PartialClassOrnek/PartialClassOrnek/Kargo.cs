using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassOrnek
{
    partial class Kargo
    {
        public int KargoId { get => _kargoId; set => _kargoId = value; }
        public string KargoDescription { get => _kargoDescription; set => _kargoDescription = value; }
        public string KargoDeliveryPerson { get => _kargoDeliveryPerson; set => _kargoDeliveryPerson = value; }
        public string KargoDeliveryAddress { get => _kargoDeliveryAddress; set => _kargoDeliveryAddress = value; }
        public double KargoWeight { get => _kargoWeight; set => _kargoWeight = value; }
        public string KargoFollowCode { get => _kargoFollowCode; set => _kargoFollowCode = value; }
        public string KargoSenderNameSurname { get => _kargoSenderNameSurname; set => _kargoSenderNameSurname = value; }
        public string KargoSenderIdentityCardNumber { get => _kargoSenderIdentityCardNumber; set => _kargoSenderIdentityCardNumber = value; }
        public string KargoSenderPhoneNumber { get => _kargoSenderPhoneNumber; set => _kargoSenderPhoneNumber = value; }
        public double KargoPrice { get => _kargoPrice; set => _kargoPrice = value; }

    }
}
