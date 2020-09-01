using System.Data.Entity;

namespace ItAcademy.Demo.ClassWork.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        int SaveChanges();
    }
}
