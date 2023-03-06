using System;
using System.IO.Compression;
using System.IO;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("Start Compress File Thread..");
            Thread.Sleep(3000); // thread bekliyor 
            ThreadFileCompresss threadfileCompress = new ThreadFileCompresss(" Thread Compress..");
            Thread thread1 = new Thread(threadfileCompress.CompressCreate);
            thread1.Start();

            do
            {
                Console.WriteLine(".");
                Thread.Sleep(1000);
            } while (threadfileCompress.Count != 1);
            Console.WriteLine("Compress thread close..");

            Console.WriteLine("---------");

            Console.WriteLine("Start Extract File Thread..");
            Thread.Sleep(3000); // thread bekliyor 
            ThreadFileExtract threadfileExtract = new ThreadFileExtract(" Thread Extract..");
            Thread thread2 = new Thread(threadfileExtract.FileExtract);
            thread2.Start();

            do
            {
                Console.WriteLine(".");
                Thread.Sleep(1000);
            } while (threadfileExtract.Count != 2);
            Console.WriteLine("Extract thread close..");

        }
        catch (Exception ex)
        {

            Console.WriteLine("Hata : "+ex.Message);
        }

        
    }
}

class ThreadFileCompresss
{
  //  string extractPath = @"C:\Users\Z004PTKX\source\repos\MultiThread-2";
    string zipPath = @"C:\Users\Z004PTKX\OneDrive - Siemens AG\Desktop\Hocain\threadZip.zip";
    string createPath = @"C:\Users\Z004PTKX\source\repos\MultiThread-2";

    public Thread threadFile;
    public int Count;

    public ThreadFileCompresss(string name)
    {
        threadFile = new Thread(this.CompressCreate); // görev bekler
        threadFile.Name = name;
        threadFile.Start();
    }

    public void CompressCreate()
    {
        try
        {
            ZipFile.CreateFromDirectory(createPath, zipPath);
            do
            {
                Count++;
            } while (Count<2);
        }
        catch (Exception ex)
        {

            Console.WriteLine("Hata : " + ex.Message);
        }
    }

   
}

class ThreadFileExtract
{
    string zipPath = @"C:\Users\Z004PTKX\OneDrive - Siemens AG\Desktop\Hocain\threadZip.zip";
   
    string extractPath = @"C:\Users\Z004PTKX\source\repos\MultiThread-2\threadZip";


    public Thread threadFile;
    public int Count;

    public ThreadFileExtract(string name)
    {
        threadFile = new Thread(this.FileExtract); // görev bekler
        threadFile.Name = name;
        threadFile.Start();
    }


    public void FileExtract()
    {
        ZipFile.ExtractToDirectory(zipPath, extractPath);
        do
        {
            Count++;
        } while (Count < 2);

    }
}

//public void Compress(string path, string zipPath){

//}