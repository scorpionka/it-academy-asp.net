using System.Data.Entity;
using System.Linq;
using ItAcademy.Demo.ClassWork.Domain.Repositories;
using ItAcademy.Demo.ClassWork.Domain.UnitOfWork;

namespace ItAcademy.Demo.ClassWork.Infrastructure.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private IUnitOfWork unitOfWork;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public T Get(object id)
        {
            return DbSet().Find(id);
        }

        public virtual int Count()
        {
            return DbSet().Count();
        }

        public virtual void Create(T item)
        {
            DbSet().Add(item);
        }

        public virtual void Delete(T item)
        {
            DbSet().Remove(item);
        }

        protected virtual IQueryable<T> GetAll()
        {
            return DbSet();
        }

        protected virtual IQueryable<T> GetItems()
        {
            return DbSet().AsQueryable();
        }

        private DbSet<T> DbSet()
        {
            return unitOfWork.Set<T>();
        }
    }
}

