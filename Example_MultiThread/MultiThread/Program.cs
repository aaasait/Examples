using System;

class Program
{

    /*
     
     IsActive = Thread'in çalışma durumunu verir
     Name = Thread'in adını atar ve verir
     Priority= Thread' çalışma önceliğini atar ve verir
     Abort =ThreadAbortException hatasını atarak Thread'in çalışmasını iptal eder
     Resume =  Beklemeye geçirilmiş Thread'in çalışmasının devam etmesini sağlar
     Sleep = Belirtilen süre kadar beklemeye geçer
     Suspend= Thread'i geçici süre durdurur.
      
     */

    static void Main(string[] args)
    {

        Console.WriteLine("Start..");
        Thread.Sleep(2000); // thread bekletir
        Console.WriteLine("Finish....\n");

        MyThread mt = new MyThread("Child 1");
        Thread th1 = new Thread(mt.Run);
        th1.Start();

        do
        {
            Console.WriteLine(".");
            Thread.Sleep(1000);
        } while (mt.Count!=10);
        Console.WriteLine("main thread close..");// en son main thread kapanır
    }
}

class MyThread
{
    public Thread th;
    public int Count;
    public MyThread(string name)
    {
        th = new Thread(this.Run); // görev bekler
        th.Name = name;
        th.Start();
    }

    public void Run()
    {
        Console.WriteLine(th.Name+" start..");
        do
        {
            Thread.Sleep(500);
            Console.WriteLine("In "+th.Name+" , Count "+Count);
            Count++;
        } while (Count<10);
        Console.WriteLine(th.Name+" terminating...");
    }

}