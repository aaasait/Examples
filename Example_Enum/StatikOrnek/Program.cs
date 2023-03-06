using StatikOrnek;

class Program
{

    static void Main(string[] args)
    {
        // virtual statik ile çalışmaz
        // Bilet bilet = new Bilet(); // hatalı erişim
        Bilet.BiletID = 1;
        Bilet.BiletName="KaziKazan";
        var biletno=Bilet.BiletNumarasi = 2534664;

        Console.WriteLine("Kazanan Numara : "+Bilet.GetNumara()+" Sizin Bilet Numaranız : "+biletno);
        // Bilet konrolü
        if (Bilet.GetNumara() == biletno)
        {
            Console.WriteLine("Kazandınız..");
        }
        else
        {
            Console.WriteLine("Tekrar Deneyiniz....");
        }

    }
}