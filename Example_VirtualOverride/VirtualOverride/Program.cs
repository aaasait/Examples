using VirtualOverride;

class Program
{
    // Virtual Override
    public static void Main(string[] args)
    {
        // Normal

        //Muhendis m=new Muhendis();
        //m.Ad = "Murtaza";
        //m.Soyad = "Alim";
        //m.Unvan = "Dr";
        //m.Departman = "Bakıcı";
        //Console.WriteLine(m.MaasHesapla());

        Muhendis m = new Muhendis();
        m.Ad = "Murtaza";
        m.Soyad = "Alim";
        m.Unvan = "Dr";
        m.Departman = "Bakıcı";
        Console.WriteLine(m.MaasHesapla());

        Calisan c =new Calisan();
        c.Ad = "abi";
        c.Soyad = "abi";
        c.Unvan = "abi";
        Console.WriteLine(c.MaasHesapla());


    }
}