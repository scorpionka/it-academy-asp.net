using System.Collections.Generic;

namespace HW4.Domain.Models
{
    public class Country : BaseModel
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public List<City> Cities { get; set; }

        public Country(int id, string name)
            : base(id)
        {
            Id = id;
            Name = name;
        }
    }
}
