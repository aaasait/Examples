using PartialClass;

class Program
{
    static void Main(string[] args)
    {
       
        People p=new People();
        p.FirstName = "aa";
        p.LastName = "bb";
        p.Email = "aaaa@gmail.com";
        p.Password= "password";
        p.BirthDate= new DateTime(1998,1,1);

        Console.WriteLine(p.GetFullName());
        Console.WriteLine(p.GetMail(1)); 

    }
}