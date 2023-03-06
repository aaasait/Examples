using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSiniflar.entity
{
    class Users
    {
        public int ID { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }

        public bool IsActive { get; set; }
        public bool IsMailActivation { get; set; }

        public void SetUserName(string uname){

            /*
            if (!string.IsNullOrWhiteSpace(uname))
            {
                this.UserName = uname;
            }
            this.UserName = uname;

            RFC KOD STANDARTI Döküman ve Kaynak Kurallar
            w3.org specler (kurallar) takip et teknolojik gelişim kurallaar
            */
            if (!string.IsNullOrWhiteSpace(uname))
                throw new Exception("Boş Değer Girilmez");
            this.UserName = uname;

            if (this.UserName==uname)
                throw new Exception("Boş Değer Girilmez");
            this.UserName = uname;

            if (uname.Length<5 || uname.Length>15)
                throw new Exception("Boş Değer Girilmez");
            this.UserName = uname;

        }
        public void SetStatus(bool isActive)
        {
            this.IsActive = isActive;
        }
        public void SetChangeDate()
        {
            this.ChangeDate = DateTime.Now;
        }
        public void SetChangeDate(DateTime date)
        {
            this.ChangeDate= date;
        }
    }
}
