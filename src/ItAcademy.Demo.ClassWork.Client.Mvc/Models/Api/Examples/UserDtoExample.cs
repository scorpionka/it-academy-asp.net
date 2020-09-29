using System;
using Swashbuckle.Swagger;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Models.Api.Examples
{
    public class UserDtoExample : ISchemaFilter
    {
        public void Apply(Schema schema, SchemaRegistry schemaRegistry, Type type)
        {
            schema.@default = new UserDto
            {
                FirstName = "Vasya",
                LastName = "Pupkin"
            };
        }
    }
}