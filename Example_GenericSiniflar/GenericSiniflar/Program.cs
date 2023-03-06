using GenericSiniflar.entity;

class Program
{
    // INTERFACE
    public static void Main(string[] args)
    {
        // RFC KOD STANDARTI Döküman ve Kaynak Kurallar
        
        Users u =new Users();
        u.UserName = "asait";
        Console.WriteLine(u.UserName);
        u.SetUserName("ali");
        Console.WriteLine(u.UserName);
        

        /*  PROBLEM PROJE
        en az 2 class farklı cs dosyalarında olacak
        iş kısmı bize ait borsa gibi

        en az 7 method - açıklama satırı 3 /// metodun üstüne 
        metod validasyon alanları oluştur istersen try catch yapamadığında konrol validasyonları boşuk  gibi
        change delete create add aktif mi

        */
    }
}