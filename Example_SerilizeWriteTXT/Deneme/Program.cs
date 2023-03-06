
using System.Net;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;
using System.Security.Cryptography;

class Program
{

    static void Main(string[] args)
    {
        var dog = new LivingObject();
        dog.Age = 4;
        dog.SpecialName = "coco";

        var human = new Human();
        human.Age = 17;
        human.SpecialName = "Mert";
        human.Name = "Alixx";
        human.Job = "Software Engineer";

        var human1 = new Human();
        human1.Age = 28;
        human1.SpecialName = "Ciat";
        human1.Name = "Murat";
        human1.Job = "Test Engineer";

        var earth = new Earth();
        earth.LivingObjects.Add(dog);
        earth.LivingObjects.Add(human);
        earth.LivingObjects.Add(human1);

        var serilizedObject = Newtonsoft.Json.JsonConvert.SerializeObject(earth, Newtonsoft.Json.Formatting.Indented);

        string path = null;
        path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string filePath = Path.Combine(path, "Kaydetfile.txt");
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            sw.Write(serilizedObject);
            Console.WriteLine("Dosya Başarılı Yazdırıldı ");
        }

    }
    public class LivingObject
    {
        public int Age { get; set; }

        public string SpecialName { get; set; }
    }
    public class Human : LivingObject
    {
        public string Name { get; set; }

        public string Job { get; set; }
    }
    public  class Earth
    {
        public List<LivingObject> LivingObjects { get; set; } = new List<LivingObject>();
    }
}