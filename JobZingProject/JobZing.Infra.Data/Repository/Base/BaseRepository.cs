using JobZing.Domain.Interfaces.Base;
using JobZing.Domain.Models.Base;
using JobZing.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobZing.Infra.Data.Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly JobZingContext _jobZingContext;
        public BaseRepository(JobZingContext jobZingContext)
        {
            _jobZingContext = jobZingContext;
        }

        public async Task Insert(T entity)
        {
            await _jobZingContext.AddAsync<T>(entity);
            await Save();
        }

        public async Task Delete(long id)
        {
            var entity =_jobZingContext.Set<T>().SingleOrDefault(x=>x.ID==id);
            _jobZingContext.Remove(entity);
            await Save();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _jobZingContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByID(long id)
        {
            return await _jobZingContext.Set<T>().SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task Update(T entity)
        {
            _jobZingContext.Update<T>(entity);
            await Save();
        }
        async Task Save()
        {
            await _jobZingContext.SaveChangesAsync();
        }
    }
}
