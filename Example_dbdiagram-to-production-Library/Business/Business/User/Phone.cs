using Business.Base;

namespace Business.User
{
    public class Phone : IID
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneType Type { get; set; }

        public Phone(int id, string name, string phoneNumber)
        {
            ID = id;
            Name = name;
            PhoneNumber = phoneNumber;
            
        }
        public Phone(int id, string name, string phoneNumber, PhoneType type)
        {
            ID = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Type = type;
        }
    }
}
