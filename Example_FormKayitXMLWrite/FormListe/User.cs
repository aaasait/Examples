using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FormListe
{
    public class User
    {

        private int _id { get; set; }
        private string _username { get; set; }
        private string  _email { get; set; }
        private string _pwd { get; set; }
        private int  _countryId { get; set; }
        private bool _onay { get; set; }

        public User(int id, string username, string email, string pwd, int countryId, bool onay)
        {
            this._id= id;
            this._username= username;
            this._email= email;
            this._pwd = pwd;
            this._countryId= countryId;
            this._onay= onay;

        }
        public User()
        {
            this._id = -1;
            this._username = "";
            this._email = "";
            this._pwd = "";
            this._countryId = -1;
            this._onay = false;
        }

        [XmlElement("id")]
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        [XmlElement("username")]
        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }
        [XmlElement("email")]
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
        [XmlElement("pwd")]
        public string Pwd
        {
            get
            {
                return _pwd;
            }

            set
            {
                _pwd = value;
            }
        }

        [XmlElement("onay")]
        public bool Onay
        {
            get
            {
                return _onay;
            }

            set
            {
                _onay = value;
            }
        }
        [XmlElement("countryid")]
        public int CountryId
        {
            get
            {
                return _countryId;
            }

            set
            {
                _countryId = value;
            }
        }

    }
}
