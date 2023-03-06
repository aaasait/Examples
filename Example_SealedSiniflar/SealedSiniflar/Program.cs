
using System;

class Program
{
    static void Main(string[] args)
    {

    }

     sealed class A
    {
        public int PropA { get; set; }
    }

    class B : A  //Sealed Class Miras Alınamaz
    {
       sealed public int PropB { get; set;}
    }
}