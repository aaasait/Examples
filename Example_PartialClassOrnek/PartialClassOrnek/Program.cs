

using PartialClassOrnek;

class Program
{ 
    public static void Main(string[] args)
    {
        Kargo kargo=new Kargo();
        Kargo kargo1 = new Kargo();
        kargo.KargoId = 1;
        kargo.KargoDescription = "Kırılacak";
        kargo.KargoDeliveryPerson = "Abdullah Sait Koç";
        kargo.KargoDeliveryAddress = " Kartal/ISTANBUL";
        kargo.KargoWeight = 10.2;
        kargo.KargoFollowCode = kargo.CargoFollowCode();
        kargo.KargoSenderNameSurname = "Said Bey";
        kargo.KargoSenderIdentityCardNumber = "45815364201";
        kargo.KargoSenderPhoneNumber = "05442542323";
        kargo.KargoPrice = 108.2;
        kargo1.KargoAdd(kargo);
        Console.WriteLine();


    }
}