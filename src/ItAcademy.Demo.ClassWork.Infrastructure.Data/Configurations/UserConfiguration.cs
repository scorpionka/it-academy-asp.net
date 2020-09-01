using System.Data.Entity.ModelConfiguration;
using ItAcademy.Demo.ClassWork.Domain.Entities;

namespace ItAcademy.Demo.ClassWork.Infrastructure.Data.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users");

            HasKey(s => s.Id);

            Property(p => p.FirstName);
            Property(p => p.LastName);

            HasOptional(s => s.Role)
               .WithMany(c => c.Users)
               .Map(m => m.MapKey("RoleId")).WillCascadeOnDelete(true);
        }
    }
}
