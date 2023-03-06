using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IKullanici
    {

        void Ekle(string kullaniciAd, string email, string sifre);
        void Guncelle(int kullaniciId, string kullaniciAd, string email, string sifre);
        void Sil(int kullaniciId); // Delete

        KullaniciInfo Getir(int kulllaniciId); // Get
        List<KullaniciInfo> KullanicilarİGetir(); //GetUser
        void Aktif(int kullaniciId);
        void Pasif(int kullaniciId);
        bool Giris(string email,string sifre);
    }
}
