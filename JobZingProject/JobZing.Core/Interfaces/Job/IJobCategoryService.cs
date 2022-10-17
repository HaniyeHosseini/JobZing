using JobZing.Core.ViewModels.Job;
using JobZing.Domain.Models.JobAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobZing.Core.Interfaces.Job
{
    public interface IJobCategoryService
    {
        Task Insert(JobCategoryViewModel model);
        Task Update(JobCategoryViewModel model);
        Task Delete(int id);
        Task<JobCategoryViewModel> GetJobCategoryByID(int id);
        Task<IList<JobCategoryViewModel>> GetJobCategories();
    }
}
