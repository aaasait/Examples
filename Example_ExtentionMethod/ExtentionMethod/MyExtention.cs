using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    public enum DataType
    {
        stringx=0,
        integerx=1,
        doublex=2
    }
    public static class MyExtention
    {
        // extention static sınıf static method ve this parametresi tanımlanır
        public static void DisplayAssemblyInfo(this object obj)
        {
            Console.WriteLine("Object Type : {0}, Assembly : \n",
                obj.GetType().Name,
                Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }

        public static int Square(this int i)
        {
            return i * i;
        }

        public static void ShowItems(this IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
            }
        }

        public static void ShowDataTyoe(this DataType datatype)
        {
            Console.WriteLine(DataType.integerx); ;
        }
    }
}
