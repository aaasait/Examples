using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Kullanici : IKullanici, IYetki,IDisposable
    {
        public int yetkiId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int kullaniciId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Aktif(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Ata(int kullaniciId, int yetkiId)
        {
            throw new NotImplementedException();
        }

        public void Ekle(string kullaniciAd, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public bool Giris(string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(int kullaniciId, string kullaniciAd, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Kaldir(int kullaniciId, int yetkiId)
        {
            throw new NotImplementedException();
        }

        public KullaniciInfo Getir(int kulllaniciId)
        {
            KullaniciInfo info = new KullaniciInfo();
            info.ID = 10;
            info.Ad="Mert";
            info.Soyad = "Osman";
            return info;
        }
        public List<KullaniciInfo> KullanicilarİGetir()
        {
            List<KullaniciInfo> data=new List<KullaniciInfo>();
            data.Add(new KullaniciInfo() { ID=12,Ad="Ali",Soyad="Koc"});
            data.Add(new KullaniciInfo() { ID = 13, Ad = "Aytekin", Soyad = "Kestek" });
            return data;
        }

        public void Pasif(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Sil(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Dispose() // Sınıfı Kaynak gösterme Using
        {
            GC.SuppressFinalize(this);
        }
    }
}
