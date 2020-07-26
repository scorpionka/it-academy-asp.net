using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Data.Interfaces
{
    public interface IBook<T> : IRepository<T> where T : class
    {
        IEnumerable<T> TopFive();
    }
}
