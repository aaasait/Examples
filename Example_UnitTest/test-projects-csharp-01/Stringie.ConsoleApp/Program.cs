using Stringie;
using System;

class Program
{
    static void Main(string[] args)
    {
        //var helloRemoved = "Hello, world!".Remove("Hello");
        //if (helloRemoved == ", world!")
        //{
        //    Console.WriteLine("Remove Hello OK");
        //}
        //else
        //{
        //    Console.WriteLine($"Remove Hello failed. Expected: ', world!' But it was: '{helloRemoved}'");
        //}

        var empty = "Hello, world!".Remove();
        if (string.IsNullOrEmpty(empty))
        {
            Console.WriteLine("Remove: OK");
        }
        else 
        {
            Console.WriteLine($"Remove failed. Expected: ''. But it was: {empty}");
        }
        Console.ReadKey();
    }
}