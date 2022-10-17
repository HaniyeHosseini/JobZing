using JobZing.Domain.Interfaces.Base;
using JobZing.Domain.Models.JobAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobZing.Domain.Interfaces.Job
{
    public interface IJobCategoryRepository :IBaseRepository<JobCategory>
    {
    }
}
