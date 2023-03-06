using System;

class Program
{

    delegate void MyGenericDelegate<T>(T obj);
    static void Main(string[] args)
    {

        MyGenericDelegate<string> strDelegate = new MyGenericDelegate<string>(String1);
        strDelegate("AbDullah KoC");
        MyGenericDelegate<int> intDelegate = new MyGenericDelegate<int>(Int1);
        intDelegate(3);

        Console.ReadKey();
    }


    static void String1(string s)
    {
        Console.WriteLine("Arg veri : "+s.ToUpper());
    }

    static void Int1(int i)
    {
        Console.WriteLine("Arg veri : " + ++i);
    }
}