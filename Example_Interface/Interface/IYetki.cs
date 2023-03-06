using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IYetki
    {
        int yetkiId { get; set; }
        int kullaniciId { get; set; }
        void Ata(int kullaniciId,int yetkiId);
        void Kaldir(int kullaniciId, int yetkiId);
    }
}
