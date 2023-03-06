using OopDesign;
using OopDesign.Customers;
using OopDesign.Products;
using OopDesign.Sales;
using OopDesign.Stores;
using OopDesign.Times;
using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    
    static void Main(string[] args)
    {

       
        // Create Product 1
        while (true)
        {
            Console.WriteLine("****WELCOME SALE PROGRAM****\n");
            Console.WriteLine(
                "1) List Product \n" +
                "2) List Stores \n" +
                "3) List Sales \n" +
                "4) List Time \n" +
                "5) Remove Product \n" +
                "6) Remove Sales \n" +
                "7) Sum Price Product\n"+
                "8) Remove After Sum Price Product\n"+
                "9) Total Sales Count \n"+
                "10) Customer List \n");
            Console.WriteLine("**************************\n");


            Product product1 = new Product();
            product1.product_code = 1;
            product1.product_name = "Computer";
            product1.product_color = Colors.Blue;
            product1.product_size = Sizes.Medium;
            product1.product_weight = 4.2;
            product1.department_code = 1;
            product1.department_name = "Marketing 1";
            product1.category_code = 2;
            product1.category_name = "Elektronik";
            // Create Time 
            DateTime dt = DateTime.Now;
            string dateMonthName = dt.ToString("MMMM");

            Time time1 = new Time();


            time1.time_code = time1.CreaterTimeCode();
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            // Console.WriteLine(wk);
            time1.day = dt.Day;
            time1.qty_time = 5;
            time1.working = true;
            time1.day_number = wk.ToString();
            time1.year_code = dt.Year;
            time1.year_description = "Very Good Year";
            time1.quarter_code = 2;
            time1.quarter_description = "Good Quarter";
            time1.semester_code = 1;
            time1.semester_name = "Noel Days";
            time1.month_code = dt.Month;
            time1.month_name = dateMonthName;
            // Create Store

            Address address1= new Address(1, "Sierra Street No:23 Nevada/CALIFORNIA", "Nemsterburg No:19 london/ENGLAND");
            
            Store store1 = new Store();
            store1.store_code = 101;
            store1.store_name = "Dell Computer LLC";
            store1.store_address = address1;
            store1.telephone = "+13241059566";
            store1.city_code = 17;
            store1.city_name = "California";
            store1.city_population = 23;
            store1.country_code = 1;
            store1.country_name = "America";
            store1.country_population = 85;

            // Create inventory for Sale
            Inventory inventory1 = new Inventory(1, "inventory 1 Satış");

            Sales sale1 = new Sales();
            sale1.Add(product1, time1, store1);
            sale1.ticket_number = 010101;
            sale1.qty_sales = 1;
            sale1.price_sales = 1299.9;
            sale1.inventory = inventory1;

            SalesInformation salesInfo1 = new SalesInformation();
            salesInfo1.AddSales(sale1);
            //salesInfo1.ListSales(sale1);
            //sale1.ListTime(time1);
            //sale1.ListProduct(product1);
            //-----------------------------------------------------------------------------
            Console.WriteLine("***************************\n");

            //-----------------------------------------------------------------------------

            Product product2 = new Product();
            product2.product_code = 2;
            product2.product_name = "Armchair";
            product2.product_color = Colors.Red;
            product2.product_size = Sizes.Big;
            product2.product_weight = 7.8;
            product2.department_code = 1;
            product2.department_name = "Marketing 2";
            product2.category_code = 3;
            product2.category_name = "Home";
            // Create Time 

            Time time2 = new Time();

            time2.time_code = time1.CreaterTimeCode(); ;
            time2.day = dt.Day;
            time2.qty_time = 9;
            time2.working = true;
            time2.day_number = wk.ToString();
            time2.year_code = dt.Year;
            time2.year_description = "Very Nice Year";
            time2.quarter_code = 2;
            time2.quarter_description = "Nice Quarter";
            time2.semester_code = 1;
            time2.semester_name = "Magic Days";
            time2.month_code = dt.Month;
            time2.month_name = dateMonthName;
            // Create Store
            Store store2 = new Store();
            store2.store_code = 202;
            store2.store_name = "Amazon Home LLC";
            store2.store_address = address1;
            store2.telephone = "+449141057766";
            store2.city_code = 020;
            store2.city_name = "London";
            store2.city_population = 56;
            store2.country_code = 44;
            store2.country_name = "ENGLAND";
            store2.country_population = 69;

            // Create inventory for Sale
            Inventory inventory2 = new Inventory(2, "inventory 2 Satış");

            Sales sale2 = new Sales();
            sale2.ticket_number = 020202;
            sale2.qty_sales = 1;
            sale2.price_sales = 1999.9;
            sale2.inventory = inventory2;

            sale1.Add(product2, time2, store2);


            salesInfo1.AddSales(sale2);
            //salesInfo1.ListSales(sale2);
            //sale1.ListTime(time2);
            //sale1.ListProduct(product2);
            Console.WriteLine();


            // ----------------------------

            Product product3 = new Product(3, "Table", Colors.White, Sizes.Small, 3.0, 1, "Marketing 3", 3, "Office");
            Time time3 = new Time(time1.CreaterTimeCode(), dt.Day, 6, false, wk.ToString(), dt.Year, "Very Good Year", 3, "Good Quarter",
               1, "Noel Days", dt.Month, dateMonthName);
            Store store3 = new Store(303, "Ikea LLC", address1, "+17841059006", 19, "Georgia", 59, 1, "America", 38);
            Inventory inventory3 = new Inventory(3, "inventory 3 Satış");

            Sales sale3 = new Sales(020202, 1, 395.3, inventory3);

            sale1.Add(product3, time3, store3);
            salesInfo1.AddSales(sale3);
            //salesInfo1.ListSales(sale3);
            //sale1.ListTime(time3);
            //sale1.ListProduct(product3);
            Profile p1 = new Profile(1, "Mehmet", "+905442310022");
            Profile p2 = new Profile(1, "Benjamin", "+44242010022");

            Customerss customerss1=new Customerss();
            Customer cs1 = new Customer(1, "Ali", "Cengiz", address1, "+12356969996", true);
            Customer cs2 = new Customer(1, "Micheal", "Cool", address1, "+12356969996", true);

            customerss1.AddCustomer(cs1);
            customerss1.AddCustomer(cs2);
           
            Console.WriteLine();

            //------------------------------------------------

            Console.WriteLine("DO YOU WANT MAKE PROCESS ? (y/n)");
            string remove_yes = Console.ReadLine();
            if (remove_yes == "y" || remove_yes == "Y")
            {

                Console.WriteLine("Select Process Number : ");
                string process = Console.ReadLine();
                int pr = Convert.ToInt32(process);

                
                switch (pr)
                {
                
                    case 1:                    
                        sale1.ListProduct();
                        break;
                    case 2:
                        sale1.ListStore();
                        break;
                    case 3:
                        salesInfo1.ListSales(sale1);
                        break;
                    case 4:
                        sale1.ListTime();
                        break;
                    case 5:
                        Console.WriteLine("Enter Index :");
                        string No1 = Console.ReadLine();
                        int productCode1 = Convert.ToInt32(No1);
                        sale1.Remove(productCode1);
                        break;
                    case 6:
                        Console.WriteLine("Enter Index :");
                        string No2 = Console.ReadLine();
                        int productCode2 = Convert.ToInt32(No2);
                        salesInfo1.RemoveSales(productCode2);
                        salesInfo1.GetPriceAfter();
                        break;
                    case 7:
                        salesInfo1.GetSumPrice();
                        break;
                    case 8:
                        salesInfo1.GetPriceAfter();
                        break;
                    case 9:
                        salesInfo1.GetCount();
                        break;
                    case 10:
                        customerss1.ListCustomer();
                        break;
                    default:
                        Console.WriteLine("Exit...");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Exit for Selected (No)...");
                break;
            }

        }

    }

 
}