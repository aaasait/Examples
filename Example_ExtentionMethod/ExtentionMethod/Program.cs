using ExtentionMethod;
using System;
using System.Collections;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        //Dokker arayüz extention olduğu için çalışır

        object obj1 = new object();
        // obj1=new Program();
        obj1.DisplayAssemblyInfo();

        Console.WriteLine("--------------");
        // Her Sınıf Bu Extention Methodları Çağırabilir..
        Program prg= new Program();
        prg.DisplayAssemblyInfo();

        int x = 3; // Birden fazla parametreli olanı da var methodun
        Console.WriteLine(x.Square());

        Console.WriteLine("--------------");
        ArrayList array= new ArrayList();
        array.Add("Car");
        array.Add("Bike");
        array.ShowItems();

        DataType data = new DataType(); // Enum Extention
       
        data.ShowDataTyoe();

    }
}