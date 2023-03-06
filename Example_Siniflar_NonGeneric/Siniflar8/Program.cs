//using System.Collections;

class Program
{
    // Advanced C#
    public static void Main(string[] args)
    {
        //MyList<string> liste = new MyList<string>();
        //liste.Ekle("İstanbul");
        //liste.Ekle("Ankara");

        MyList<string> liste = new MyList<string>(20);
        liste.Ekle("İstanbul");
        liste.Ekle("Ankara");

   

       
        //liste[0] = 1;       // Bunun için Indexer oluşturmak gerekiyor

        Console.WriteLine("Eleman Sayı : " + liste.ElemanSayi);

        
       
    }
}

class MyList<T>
{
    T[] dizi;
    private int count;
    public MyList()
    {
        count = 10;
        dizi = new T[count];
    }

    public MyList(int count)
    {
        this.count = count;
        dizi = new T[count];
    }

    public void Ekle(T deger)
    {
        try
        {
            T[] geciciDizi = new T[dizi.Length];
            geciciDizi = dizi;
            dizi = new T[geciciDizi.Length + 1];
            for (int i = 0; i < geciciDizi.Length; i++)
            {
                dizi[i] = geciciDizi[i];
            }
            dizi[dizi.Length - 1] = deger;
           
           


        }
        catch
        {
            dizi = new T[1];
            dizi[0] = deger;
        }
    }

   
    public int ElemanSayi
    {
        get { return dizi.Length; }
    }


}