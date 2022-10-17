using JobZing.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobZing.Domain.Interfaces.Base
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(long id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(long id);
    }
}
