using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    // method tan parametreli thread oluşturma
    static void Main(string[] args)
    {
        Console.WriteLine("Thread id = "+Thread.CurrentThread.ManagedThreadId);
        Console.WriteLine(" işlem çekirdek sayısı : "+Environment.ProcessorCount);
        Console.WriteLine("**********");

        AddParam ap = new AddParam(10,10);
        Thread th = new Thread(new ParameterizedThreadStart(Add));

        th.Start(ap); 

    }

    public static void Add(object data)
    {
        if(data is AddParam)
        {
            Console.WriteLine("Id of threading.. main ",Thread.CurrentThread.ManagedThreadId);
            AddParam ap = (AddParam)data;
            Console.WriteLine("{0} + {1} = {2}",ap.a,ap.b,ap.a+ap.b);
        }
    }
}




class AddParam
{
    public int a;
    public int b;

   public AddParam(int num1, int num2)
    {
     a = num1;
     b = num2;
    }
}