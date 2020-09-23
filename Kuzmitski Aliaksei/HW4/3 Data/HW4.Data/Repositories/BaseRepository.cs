using HW4.Domain.Repositories.Interfaces;
using HW4.Domain.UnitOfWork.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace HW4.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IUnitOfWork unitOfWork;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        private DbSet<T> DbSet()
        {
            return unitOfWork.Set<T>();
        }

        public void Add(T item)
        {
            DbSet().Add(item);
        }

        public void Delete(T item)
        {
            DbSet().Remove(item);
        }

        public void DeleteById(int itemId)
        {
            Delete(Get(itemId));
        }

        public T Get(int id)
        {
            return DbSet().Find(id);
        }

        public System.Collections.Generic.List<T> GetAll()
        {
            return DbSet().ToList();
        }
    }
}
