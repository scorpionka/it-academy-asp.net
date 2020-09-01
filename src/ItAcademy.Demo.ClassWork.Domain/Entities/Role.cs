using System.Collections.Generic;

namespace ItAcademy.Demo.ClassWork.Domain.Entities
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
