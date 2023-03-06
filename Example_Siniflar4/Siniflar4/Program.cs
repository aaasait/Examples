using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        //
        //ProjectA.ClassA x1 = new ProjectA.ClassA();

        // 
        ProjectA.TeamB.ClassA x2 = new ProjectA.TeamB.ClassA();

        //
        ProjectB.TeamA.ClassA x3 = new ProjectB.TeamA.ClassA();
    }
}

//namespace ProjectA
//{
//    class ClassA
//    {

//    }
//}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjectA.TeamA.ClassA.Print()");
            }
        }
    }

    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjectA.TeamB.ClassA.Print()");
            }
        }
    }
}

namespace ProjectB
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjectB.TeamA.ClassA.Print()");
            }
        }
    }
}