using System.Data.Entity;

namespace ItAcademy.Demo.ClassWork.Infrastructure.Data.Context
{
    public class CoreDbContext : DbContext, ICoreDbContext
    {
        public CoreDbContext()
            : base("name=ItAcademyCoreDb")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
        }
    }
}
