using System.Data.Entity;
using ItAcademy.Demo.ClassWork.Domain.UnitOfWork;
using ItAcademy.Demo.ClassWork.Infrastructure.Data.Context;

namespace ItAcademy.Demo.ClassWork.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICoreDbContext db;

        public UnitOfWork(ICoreDbContext db)
        {
            this.db = db;
        }

        public DbSet<TEntity> Set<TEntity>()
            where TEntity : class
        {
            return db.Set<TEntity>();
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }
    }
}
