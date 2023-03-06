using Inheritance;

class Program
{
    // INHERİTANCE
    public static void Main(string[] args)
    {
       // A a=new A();
       // a.ProbA = 1;
       //  Console.WriteLine("merahaba");

        ikiBoyut ikib=new ikiBoyut();
        ikib.Genislik = 10;
        ikib.Yukseklik = 20;
        ikib.Goster();

        Console.WriteLine("*****************************");
        Ucgen uc =new Ucgen();
        uc.Genislik = 10;
        uc.Yukseklik = 20;
        uc.Stil = "Üçgen";
        uc.Goster();
        Console.WriteLine(uc.AlanHesapla());
        Console.ReadKey();
    }
}

class A // BASE CLASS
{
    public int ProbA { get; set; }
}
class B:A // DERİVED /  TÜREMİŞ CLASS
{
    public int ProbB { get; set; }
}
class C:B
{
    public int ProbC { get; set; }
}