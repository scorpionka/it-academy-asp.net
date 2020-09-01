using System.Data.Entity;

namespace ItAcademy.Demo.ClassWork.Infrastructure.Data.Context
{
    public interface ICoreDbContext
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        int SaveChanges();
    }
}
