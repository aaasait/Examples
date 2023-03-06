using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FormListe
{
    [XmlRoot("usersAll")]
    public class UsersAll
    {
        private string _name;
        private List<User> _users;

        public UsersAll(string name)
        {
            _name = name;
            _users = new List<User> { };
        }

        public UsersAll()
        {
            _name = "";
            _users = new List<User> { };
        }
        [XmlAttribute("name")]
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        [XmlArray("users")]
        [XmlArrayItem("user")]
        public List<User> Users
        {
            get
            {
                return _users;
            }

            set
            {
                _users = value;
            }
        }
    }
}
