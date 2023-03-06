using System.Collections;

class Program
{
    // Advanced C#
    // Generic metod ile default operator örneği
    public static void Main(string[] args)
    {
        Islemler<double> sinif = new Islemler<double>();
        double sonuc = sinif.IslemYap(4.3, -2);

        Console.WriteLine(sonuc);
    }
}

class Islemler<T>
{
    public T IslemYap(T t, int param)
    {
        if (param >= 0)
        {
            return t;
        }
        else
        {
            return default(T);
        }
    }
}