using System.Collections.Generic;

namespace HW4.Domain.Models
{
    public class City : BaseModel
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public Country Country { get; set; }

        public City(int id, string name)
            : base(id)
        {
            Id = id;
            Name = name;
        }
    }
}
