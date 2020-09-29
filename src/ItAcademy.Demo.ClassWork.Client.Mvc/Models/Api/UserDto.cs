using System.ComponentModel.DataAnnotations;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.Api.Examples;
using Swashbuckle.Swagger.Annotations;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Models.Api
{
    /// <summary>
    /// This is a user dto that contains all necessary info.
    /// </summary>
    [SwaggerSchemaFilter(typeof(UserDtoExample))]
    public class UserDto
    {
        /// <summary>
        /// First name of user.
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of user.
        /// </summary>
        public string LastName { get; set; }
    }
}