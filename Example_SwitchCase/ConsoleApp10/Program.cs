using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int setting = 1;

                //switch (sayi)
                //{
                //    case 1:
                //        Console.WriteLine("bir");
                //        break;
                //    case 3:
                //        Console.WriteLine("Üç");
                //        break;
                //    case 4:
                //        Console.WriteLine("Dört");
                //        break;
                //}

                //switch (setting)
                //{
                //    case 1:
                //    case 3:
                //        Console.WriteLine("Bir ve Üç");
                //        break;
                //    case 4:
                //        Console.WriteLine("Dört");
                //        break;
                //}

                //switch (setting)
                //{
                //    case 1:
                //        Console.WriteLine("Bir");
                //        break;
                //    case 3:
                //        Console.WriteLine("Üç");
                //        break;
                //    case 4:
                //        Console.WriteLine("Dört");
                //        break;
                //    default:
                //        Console.WriteLine("Unknown");
                //        break;
                //}


                Console.WriteLine("Sayfa : ");
                string page = Console.ReadLine();
                switch (page)
                {
                    case "index":
                        Console.WriteLine("http://www.cihanozhan.com");
                        break;
                    case "contact":
                        Console.WriteLine("http://www.cihanozhan.com/contact");
                        break;
                    case "about":
                        Console.WriteLine("http://www.cihanozhan.com/about");
                        break;
                    default:
                        Console.WriteLine("http://www.cihanozhan.com/404");
                        break;
                }

                //

                
                Console.WriteLine("HTTP Verb : ");
                string http_status_code = Console.ReadLine();
                switch (http_status_code)
                {
                    case "GET":
                        Console.WriteLine("GET http://www.cihanozhan.com");
                        break;
                    case "POST":
                        Console.WriteLine("POST http://www.cihanozhan.com");
                        break;
                    case "PUT":
                        Console.WriteLine("PUT http://www.cihanozhan.com");
                        break;
                    case "DELETE":
                        Console.WriteLine("DELETE http://www.cihanozhan.com");
                        break;
                    default:
                        Console.WriteLine("http://www.cihanozhan.com/404");
                        break;
                }

                
                Console.ReadKey();
            }
        }
    }
}