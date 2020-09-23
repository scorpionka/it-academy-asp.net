using HW4.Domain.Models;
using HW4.Domain.Repositories.Interfaces;
using HW4.Domain.UnitOfWork.Interfaces;

namespace HW4.Data.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        private readonly IUnitOfWork unitOfWork;

        public CountryRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
