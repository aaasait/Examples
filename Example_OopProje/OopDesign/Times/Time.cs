using OopDesign.Times;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDesign.Times
{

    public class Time:IMonth,IYear,IQuarter,ISemester
    {
        public string time_code { get; set; } 
        public int day { get; set; }
        public int qty_time { get; set; }
        public bool working { get; set; }
        public string day_number { get; set; }

        // İMPLEMENT
        public int month_code { get; set; }
        public string month_name { get; set; }
        public int year_code { get; set; }
        public string year_description { get; set; }
        public int quarter_code { get; set; }
        public string quarter_description { get; set; }
        public int semester_code { get; set; }
        public string semester_name { get; set; }

        public Time() { }
        public Time(string time_code, int day, int qty_time, bool working, string day_number, int month_code, string month_name, int year_code, string year_description, int quarter_code, string quarter_description, int semester_code, string semester_name)
        {
            this.time_code = time_code;
            this.day = day;
            this.qty_time = qty_time;
            this.working = working;
            this.day_number = day_number;
            this.month_code = month_code;
            this.month_name = month_name;
            this.year_code = year_code;
            this.year_description = year_description;
            this.quarter_code = quarter_code;
            this.quarter_description = quarter_description;
            this.semester_code = semester_code;
            this.semester_name = semester_name;
        }

        public string CreaterTimeCode()
        {
            string timecode_first = "TIMECODE";
            Random rnd = new Random();
            int number = rnd.Next(1000000, 9999999);
            string number_string = number.ToString();
            string s= timecode_first+number_string;
            return s;   

        }

        public void GetDayName()
        {
            //DateTime dt = new DateTime();
            //string days;
            //if (dt == dt)
            //{
            //    days = "Monday";
            //}
            //else if(d == Day.Tuesday)
            //{
            //    days = "Tuesday";
            //}
            //else if (d == Day.Wednesday)
            //{
            //    days = "Wednesday";
            //}
            //else if (d == Day.Thursday)
            //{
            //    days = "Thursday";
            //}
            //else if (d == Day.Friday)
            //{
            //    days = "Friday";
            //}
            //else if (d == Day.Saturday)
            //{
            //    days = "Saturday";
            //}
            //else if (d == Day.Sunday)
            //{
            //    days = "Sunday";
            //}
            //else
            //{
            //    days = "unknown";
            //}
            //return days;
        }
        public void ShowProcessTime()
        {
            
        }
    }
}
