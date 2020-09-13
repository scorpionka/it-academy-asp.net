using System.ComponentModel.DataAnnotations;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Models.Api
{
    public class UserDto
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}