using Business.Base;

namespace Business.User
{
    public class Country : IID, IActivity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public Country()
        {

        }

        public Country(int ıD, string name, bool ısActive)
        {
            ID = ıD;
            Name = name;
            IsActive = ısActive;
        }
    }
}
