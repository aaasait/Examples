using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FormListe
{
    public class FileWriter
    {

        public void XMLSerilize(string path, int id, string username, string email, string pwd, int countryId, bool onay)
        {
            try
            {
                UsersAll usersx = new UsersAll("User");
                usersx.Users.Add(new User(id, username, email, pwd, countryId, onay));
                XmlSerializer x = new XmlSerializer(typeof(UsersAll));
                //FileStream fs = new FileStream(path, FileMode.Append);
                FileStream fs = new FileStream(path, FileMode.Create);
                x.Serialize(fs, usersx);
                fs.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine("ERROR MESSAGE : " + e.Message);
            }
        }




    }
}
