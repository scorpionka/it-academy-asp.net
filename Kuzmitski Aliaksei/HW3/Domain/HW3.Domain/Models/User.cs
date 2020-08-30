using System;

namespace HW3.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Title Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }

        public Guid CountryId { get; set; }

        public Guid CityId { get; set; }
    }
}
