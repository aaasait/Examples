using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public enum TextileMarka
    {
        Kigili=1,
        Beymen=2,
        Polo=3,
        AltinYildiz=4,
        PierreCarden=5
    }
    internal class Textile:Product
    {

        public string Tur { get; set; }
        public int Beden { get; set; }
        public string Uretici { get; set; }
        public TextileMarka Marka { get; set; }

        public override double SetKdv()
        {
            return this.Price * 1.08;
        }

        public static List<Textile> SearchByBrand(TextileMarka marka)
        {
            #region Dummy Data

            List<Textile> textileProducts = new List<Textile>();

            textileProducts.Add(new Textile()
            {
                ProductName = "Pantolon",
                Beden = 40,
                Price = 100,
                Marka = TextileMarka.Beymen
            });

            textileProducts.Add(new Textile()
            {
                ProductName = "Ceket",
                Beden = 40,
                Price = 80,
                Marka = TextileMarka.AltinYildiz
            });

            textileProducts.Add(new Textile()
            {
                ProductName = "Kemer",
                Beden = 40,
                Price = 40,
                Marka = TextileMarka.PierreCarden
            });

            textileProducts.Add(new Textile()
            {
                ProductName = "Gömlek",
                Beden = 40,
                Price = 120,
                Marka = TextileMarka.AltinYildiz
            });

            #endregion

            List<Textile> data = new List<Textile>();

            foreach (var t in textileProducts)
            {
                if (t.Marka == marka)
                {
                    data.Add(t);
                }
            }
            return data;
        }

        public static List<Textile> SearchByProductName(string pname)
        {
            #region Dummy Data

            List<Textile> textileProducts = new List<Textile>();

            textileProducts.Add(new Textile()
            {
                ProductName = "Pantolon",
                Beden = 40,
                Price = 100,
                Marka = TextileMarka.Beymen
            });

            textileProducts.Add(new Textile()
            {
                ProductName = "Ceket",
                Beden = 40,
                Price = 80,
                Marka = TextileMarka.AltinYildiz
            });

            textileProducts.Add(new Textile()
            {
                ProductName = "Kemer",
                Beden = 40,
                Price = 40,
                Marka = TextileMarka.PierreCarden
            });

            textileProducts.Add(new Textile()
            {
                ProductName = "Gömlek",
                Beden = 40,
                Price = 120,
                Marka = TextileMarka.AltinYildiz
            });

            #endregion

            List< Textile> data = new List<Textile>();

            foreach (var t in textileProducts)
            {
                if (t.ProductName.Contains(pname))
                {
                    data.Add(t);
                }
            }
            return data;
        }
    }
}
