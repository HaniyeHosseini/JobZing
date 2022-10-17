using JobZing.Core.Interfaces.Job;
using JobZing.Core.ViewModels.Job;
using JobZing.Domain.Interfaces.Job;
using JobZing.Domain.Models.JobAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobZing.Core.Services.Job
{
    public class JobCategoryService : IJobCategoryService
    {
        private readonly IJobCategoryRepository _jobCategoryRepository;
        //private readonly IMapper _mapper;
        public JobCategoryService(IJobCategoryRepository jobCategoryRepository)
        {
            _jobCategoryRepository = jobCategoryRepository;
        }

        public async Task Delete(int id)
        {
            await _jobCategoryRepository.Delete(id);
        }

        public async Task<IList<JobCategoryViewModel>> GetJobCategories()
        {
            var categories = await _jobCategoryRepository.GetAll();
            var result = categories.Select(x => new JobCategoryViewModel()
            {
                ID = x.ID,
                Title = x.Title,
                DateTime = x.CreationDate.ToString(),
                IsActive = x.IsActive,
                ParentID = x.ParentID,
                Picture=x.Picture,
                PictureAlt=x.PictureAlt,
                PictureTitle=x.PictureTitle,
                ParentName = x.Parent.Title,
            }).ToList();
            return result;
        }
        public async Task Insert(JobCategoryViewModel model)
        {
            var category = new JobCategory(model.Title, model.IsActive, "slug",model.Picture,model.PictureAlt,model.PictureTitle, model.ParentID);
            await _jobCategoryRepository.Insert(category);
        }

        public async Task Update(JobCategoryViewModel model)
        {
            JobCategory entity = await GetUpdatedCategory(model);
            await _jobCategoryRepository.Update(entity);
        }

        public async Task<JobCategoryViewModel> GetJobCategoryByID(int id)
        {
            var entity = await _jobCategoryRepository.GetByID(id);
            var result = GetJobCategoryViewModel(entity);
            return result;
        }

        private static JobCategoryViewModel GetJobCategoryViewModel(JobCategory entity)
        {
            var result = new JobCategoryViewModel()
            {
                ID = entity.ID,
                Title = entity.Title,
                IsActive = entity.IsActive,
                DateTime = entity.CreationDate.ToString(),
            };
            if (entity.ParentID != 0)
            {
                result.ParentID = entity.ParentID;
                result.ParentName = entity.Parent.Title;
            }

            return result;
        }

        private async Task<JobCategory> GetUpdatedCategory(JobCategoryViewModel model)
        {
            var entity = await _jobCategoryRepository.GetByID(model.ID);
            entity.Title = model.Title;
            entity.IsActive = model.IsActive;
            entity.PictureTitle = model.PictureTitle;
            entity.PictureAlt = model.PictureAlt;
            entity.Picture = model.Picture;

            if (model.ParentID != null)
            {
                entity.ParentID = model.ParentID;
            }
            return entity;
        }

    }
}
