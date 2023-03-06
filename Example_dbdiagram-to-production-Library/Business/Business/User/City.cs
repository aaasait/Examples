using Business.Base;

namespace Business.User
{
    public class City : IID, IActivity
    {
        public int ID { get; set;  }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public City() { }

        public City(int ıD, string name, bool ısActive)
        {
            ID = ıD;
            Name = name;
            IsActive = ısActive;
        }


    }
}
