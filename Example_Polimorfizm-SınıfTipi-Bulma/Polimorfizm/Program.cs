using Polimorfizm;

class Program
{
    static void Main(string[] args)
    {

        #region Old and Gold Code
        //Product p = new Product();
        //Bread b = new Bread(BreadType.AltinEkmek);
        //Console.WriteLine(b.Gram);
        //Console.WriteLine(b.Price);

        //Basket basket = new Basket();
        //basket.Add(b);
        #endregion
        Basket basket= new Basket();
        
        Bread ekmek= new Bread(BreadType.Kepek);
        Bread ekmek1 = new Bread(BreadType.AltinEkmek);

        basket.Add(ekmek);
        basket.Add(ekmek1);


        Console.WriteLine("Toplam KDV HARİÇ : "+basket.TotalPrice());
        Console.WriteLine("Toplam KDV DAHİL : " + basket.TotalPriceWidthKdv());
        Console.WriteLine("Sipariş KDV Toplamı : " + (basket.TotalPriceWidthKdv() - basket.TotalPrice()));
       


        Console.ReadKey();
    }
}