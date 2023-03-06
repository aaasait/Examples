using System;

class Program
{
    // Paramaters Thread 
    static void Main(string[] args)
    {
        Printer p =new Printer();
        Thread byThread = new Thread(new ThreadStart(p.PrintNumber));
        //Thread byThread = new Thread(p.PrintNumber);
       // byThread.IsBackground = true;
        byThread.Start();

        // Enum Thread Türleri Telefonda var

        Console.WriteLine("Current State : "+Thread.CurrentThread.ThreadState.ToString());
        Console.WriteLine(" byThread Thread State : "+byThread.ThreadState.ToString());

        Console.WriteLine("------------");

        Console.WriteLine("Current Priority : " + Thread.CurrentThread.Priority.ToString());
        Console.WriteLine(" byThread Thread Priority : " + byThread.Priority.ToString());


    }
}

public class Printer
{
    public void PrintNumber() 
    {
        Console.WriteLine("-> is exacting  PrintNumber() ",Thread.CurrentThread.Name);
        Console.WriteLine("Your Number : ");

        for (int i = 0; i < 10; i++)
        {
            Random r= new Random();
            Thread.Sleep(1000);
            Console.WriteLine(i+", ");

        }
        Console.WriteLine();

    }
}