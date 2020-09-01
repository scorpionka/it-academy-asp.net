using System.Data.Entity.ModelConfiguration;
using ItAcademy.Demo.ClassWork.Domain.Entities;

namespace ItAcademy.Demo.ClassWork.Infrastructure.Data.Configurations
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            ToTable("Roles");

            HasKey(s => s.Id);

            Property(p => p.Name);
        }
    }
}
