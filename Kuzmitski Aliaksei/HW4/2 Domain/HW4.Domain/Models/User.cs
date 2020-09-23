namespace HW4.Domain.Models
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Title Title { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }

        public User(int id, string firstName, string lastName, Title title, Country country, City city, string phone,
            string email, string comments)
            : base(id)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            Country = country;
            City = city;
            Phone = phone;
            Email = email;
            Comments = comments;
        }
    }
}
