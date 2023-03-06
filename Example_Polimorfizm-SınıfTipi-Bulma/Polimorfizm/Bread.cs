using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    // Enumda defaul değer double kullanılmaz
    public enum BreadType
    {
        Beyaz=1,
        Kepek=2,
        Bugday=3,
        Odun=4,
        AltinEkmek=5,
    }
    public enum Gramaj
    {
        Yuz=100,
        YuzYirmiBes=125,
        IkiYuz=200,
    }

    class Bread:Product
    {
        public BreadType Type { get; set; }
        public Gramaj Gram { get; set; }
        public string Uretici { get; set; }

        public override double SetKdv()
        {
            return this.Price*1.18;
        }
        public Bread() { }

        public Bread(
            BreadType type)
        {
            switch(type)
            {
                case BreadType.Beyaz:
                    this.Price = 1.0;
                    this.Gram=Gramaj.Yuz;
                    break;
                case BreadType.Kepek:
                    this.Price = 2.0;
                    this.Gram = Gramaj.IkiYuz;
                    break;
                case BreadType.Bugday:
                    this.Price = 2.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Odun:
                    this.Price = 1.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.AltinEkmek:
                    this.Price = 1.5;
                    this.Gram = Gramaj.Yuz;
                    break;

            }    
        }

        /// <summary>
        /// BEN CUSTUM ÜCRET BELİRLEYEREK X TİPİNDEKİ EKMEGİ SATIYORUM
        /// </summary>
        /// <param name="price"></param>
        /// <param name="type"></param>
        public Bread(
            double price,
           BreadType type)
        {

            double _price=0; // private değer _deger olarak tanımlanır içerdeki
            // public değişkenler büyük harle vbaşlar
            if(price>0)
                _price = price;
            if (price <= 0)
                throw new Exception("Ekmek ücrei sıfır ve sıfırdan küçük olamaz..");

            switch (type)
            {
                case BreadType.Beyaz:
                    this.Price = _price;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Kepek:
                    this.Price = _price;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Bugday:
                    this.Price = _price;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Odun:
                    this.Price = _price;
                    this.Gram = Gramaj.IkiYuz;
                    break;
                case BreadType.AltinEkmek:
                    this.Price = _price;
                    this.Gram = Gramaj.IkiYuz;
                    break;

            }
        }
    }
}
