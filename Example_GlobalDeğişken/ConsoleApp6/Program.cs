using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // değişkenler global  ve local
        int x = 3;
        {
            {
                int y = 6;
                {
                    Console.WriteLine(y+x);
                }
            }
        }
    }


}