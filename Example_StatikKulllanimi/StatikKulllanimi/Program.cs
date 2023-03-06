
using StatikKulllanimi;
using System.Threading;

class Program
{
    //static int xx = 0;
    //public Program()
    //{
    
    //    xx++;
    
    //}    
    static void Main(string[] args)
    {
        // statik kullanımı sınıf yoksa nesne örneği olarak çağrılmasını sağlar
        // nesnenin doğrudan kendisinden erişmek için kullanılır.

        //Program p;
        //for (int i = 0; i < length; i++)
        //{
        //    p = new Program();
        //}


        // Statik sadece nesne üzerinden erişilebilen nesneler oluşturur.
        // Statik bir nesneye nesne örneği üzerinden erişilemez.
        // Sınıf adını doğrudan yazarak erişilir

        //Kullanici k = new Kullanici();
        //k.Ad = "";
        //k.GetID();
        //Kullanici.ID = 1;

        //

        var x = Encryption.Encrypt("asdada");
        var y = Encryption.Decrypt("adadadada");

        Console.WriteLine(x);
        Console.WriteLine(y);

        //Encryption enc = new Encryption();

        //Encryption.Encrypt("adada");

    }
}