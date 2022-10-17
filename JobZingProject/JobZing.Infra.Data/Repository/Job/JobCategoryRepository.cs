using JobZing.Domain.Interfaces.Job;
using JobZing.Domain.Models.JobAgg;
using JobZing.Infra.Data.Context;
using JobZing.Infra.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobZing.Infra.Data.Repository.Job
{
    public class JobCategoryRepository : BaseRepository<JobCategory>, IJobCategoryRepository
    {
        public JobCategoryRepository(JobZingContext jobZingContext) : base(jobZingContext)
        {
        }
    }
}
